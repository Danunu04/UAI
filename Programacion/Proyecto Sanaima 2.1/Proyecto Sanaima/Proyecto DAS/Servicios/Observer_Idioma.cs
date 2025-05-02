using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios
{
    public class Observer_Idioma : IObserver
    {
        public List<Form> Forms = new List<Form>();


        public Observer_Idioma()
        {
                Forms = new List<Form>();
        }
        public void RegistrarForm(Form form)
        {
            Forms.Add(form);
        }

        public void Actualizar(string Idioma)
        {
            

            foreach (var formulario in Forms) //carga todos los formularios
            {

                
                string RutaArchivo = Path.Combine(formulario.Name, $"{Idioma}.txt");
                                     

                if (File.Exists(RutaArchivo))
                {
                    var traducciones = LeerTraducciones(RutaArchivo);
                    ActualizarControlesFormulario(formulario,traducciones);
                    
                }
                else
                {
                    MessageBox.Show($"No se encontró el archivo idioma para {formulario.Name} en {RutaArchivo}");//probar con poner nomas el formulario.name
                }
            }
            
        }

        private Dictionary<string, List<string>> LeerTraducciones(string rutaArchivo)
        {
            var traducciones = new Dictionary<string, List<string>>();
            var lineas = File.ReadAllLines(rutaArchivo);

            foreach (var line in lineas)
            {
                var partes = line.Split(';');
                if (partes.Length >= 2) 
                { 
                    var listaTraducciones = new List<string>();
                    for (int i = 1; i < partes.Length; i++)
                    {
                        listaTraducciones.Add(partes[i]);//??
                    }
                    traducciones[(partes[0])] = listaTraducciones;//??
                }
            }
            return traducciones;
        }

        private void ActualizarControlesFormulario(Form formulario, Dictionary<string, List <string>> traducciones)
        {
            foreach (Control control in formulario.Controls)
            {
                if (control.Tag != null && traducciones.ContainsKey(control.Tag.ToString()))
                {
                    var traduccion = traducciones[control.Tag.ToString()];
                    if (control is ComboBox comboBox)//si es un combobox, entra
                    {
                        comboBox.Items.Clear();
                        comboBox.Items.AddRange(traduccion.ToArray());
                        comboBox.SelectedIndex = 0;
                    }
                    else
                    {
                        control.Text = traduccion[0];
                    }
                    if (control is CheckedListBox checkedListBox)
                    {
                        checkedListBox.Items.Clear();
                        checkedListBox.Items.AddRange(traduccion.ToArray());
                    }
                    else
                    {
                        control.Text = traduccion[0];
                    }
                }

                if (control is MenuStrip menuStrip)
                {
                    foreach (ToolStripItem item in menuStrip.Items) 
                    { 
                        ActualizarMenuStripItems(item,traducciones);
                    }
                }
                   
                if(control is GroupBox groupBox)
                {
                    foreach (Control innerControl in groupBox.Controls)
                    {
                        ActualizarControl(innerControl, traducciones);
                    }
                }

            }
        }


        private void ActualizarMenuStripItems(ToolStripItem item, Dictionary<string, List<string>> traducciones)
        {
            if (item.Tag != null && traducciones.ContainsKey(item.Tag.ToString())) 
            { 
                var traduccion = traducciones[item.Tag.ToString()];
                item.Text = traduccion[0];
            }

            if (item is ToolStripMenuItem menuItem)
            {
                foreach (ToolStripItem subItem in menuItem.DropDownItems)
                {
                    ActualizarMenuStripItems(subItem,traducciones);
                }
            }
        }

        private void ActualizarControl(Control control, Dictionary<string, List<string>> traducciones)
        {
            if (control is TabPage tabPage)
            {
                if (tabPage.Tag != null && traducciones.ContainsKey(tabPage.Tag.ToString())) 
                { 
                    var traduccion = traducciones[tabPage.Tag.ToString()];
                    tabPage.Text = traduccion[0];
                }

                foreach(Control innerControl in tabPage.Controls)
                {
                    ActualizarControl(innerControl, traducciones);
                }
            }

            if(control is GroupBox groupBox)
            {
                foreach(Control innerControl in groupBox.Controls)
                {
                    ActualizarControl(innerControl, traducciones);
                }
            }
            if(control.Tag != null && traducciones.ContainsKey(control.Tag.ToString()))
            {
                var traduccion = traducciones[control.Tag.ToString()];
                if(control is ComboBox comboBox)
                {
                    comboBox.Items.Clear();
                    comboBox.Items.AddRange(traduccion.ToArray());
                    comboBox.SelectedIndex = 0; // selecciona el 1er item x defecto
                }
                else
                {
                    control.Text = traduccion[0]; //usar la 1ra traduccion para el texto del control
                }
            }
        }
    }
}
