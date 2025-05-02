using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public class LanguajeManager : IObserver
    {
        public List<Form> Forms = new List<Form>();
        private Dictionary<string, string> Diccionario;

        public LanguajeManager()
        {
            Diccionario = new Dictionary<string, string>(); // Inicializar Diccionario
        }

        // Registrar formularios para aplicarles la traducción
        public void RegistrarForm(Form form)
        {
            Forms.Add(form);
        }

        // Actualizar el idioma y aplicar a los formularios registrados
        public void ActualizarIdioma(string idioma)
        {
            foreach (var formulario in Forms) // Carga todos los formularios
            {
                string rutaArchivo = Path.Combine(Application.StartupPath, $"{idioma}.txt");

                if (File.Exists(rutaArchivo))
                {
                    var traducciones = LeerTraducciones(rutaArchivo);
                    CargarIdiomaControles(formulario, traducciones);
                }
                else
                {
                    MessageBox.Show($"No se encontró el archivo de idioma para {formulario.Name} en {rutaArchivo}");
                }
            }
        }

        // Leer las traducciones del archivo
        private Dictionary<string, string> LeerTraducciones(string rutaArchivo)
        {
            var traducciones = new Dictionary<string, string>();
            var lineas = File.ReadAllLines(rutaArchivo);

            foreach (var linea in lineas)
            {
                if (!string.IsNullOrWhiteSpace(linea) && linea.Contains('='))
                {
                    var partes = linea.Split('=');
                    var clave = partes[0].Trim();
                    var valor = partes[1].Trim();
                    traducciones[clave] = valor;
                }
            }
            return traducciones;
        }

        // Aplicar traducciones a los controles de un formulario
        public void CargarIdiomaControles(Form form, Dictionary<string, string> traducciones)
        {
            try
            {
                foreach (Control control in form.Controls)
                {
                    if (control.Tag != null && traducciones.ContainsKey(control.Tag.ToString()))
                    {
                        control.Text = traducciones[control.Tag.ToString()];
                    }

                    if (control is MenuStrip menuStrip)
                    {
                        foreach (ToolStripItem item in menuStrip.Items)
                        {
                            ActualizarMenuStripItems(item, traducciones);
                        }
                    }

                    // Aplicar traducciones recursivamente a controles anidados
                    if (control.Controls.Count > 0)
                    {
                        CargarIdiomaControlesRecursivo(control, traducciones); // Llamada a método recursivo para controles
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al traducir controles: {ex.Message}");
            }
        }

        // Nuevo método para manejar controles que no son formularios
        private void CargarIdiomaControlesRecursivo(Control parentControl, Dictionary<string, string> traducciones)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control.Tag != null && traducciones.ContainsKey(control.Tag.ToString()))
                {
                    control.Text = traducciones[control.Tag.ToString()];
                }

                if (control is MenuStrip menuStrip)
                {
                    foreach (ToolStripItem item in menuStrip.Items)
                    {
                        ActualizarMenuStripItems(item, traducciones);
                    }
                }

                // Llamada recursiva para controles anidados
                if (control.Controls.Count > 0)
                {
                    CargarIdiomaControlesRecursivo(control, traducciones);
                }
            }
        }

        // Recursivamente actualizar los items del menú
        private void ActualizarMenuStripItems(ToolStripItem item, Dictionary<string, string> traducciones)
        {
            if (item.Tag != null && traducciones.ContainsKey(item.Tag.ToString()))
            {
                item.Text = traducciones[item.Tag.ToString()];
            }

            if (item is ToolStripMenuItem menuItem)
            {
                foreach (ToolStripItem subItem in menuItem.DropDownItems)
                {
                    ActualizarMenuStripItems(subItem, traducciones);
                }
            }
        }
    }
}
