using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using BLL;
using BE;

namespace Registro_lluvia_Ivan_Dana
{
    public partial class Inicio : Form //IObserver
    {
        LanguajeManager LMG = new LanguajeManager();
        Idioma idiom =  new Idioma();
        string lang="";//Traer idioma -> Lang de languaje
        

        BLLUsuario BLLU = new BLLUsuario();
        public Inicio()
        {
            InitializeComponent();
            IsMdiContainer=true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void usuario_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            LogIN logIN = new LogIN(lang);
            logIN. MdiParent = this;
            logIN.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            usuario.Enabled = true;
            cambiarclave.Enabled = false;
            admin.Enabled = false;
            reportes.Enabled = false;

            LMG.RegistrarForm(this); // Registrar el formulario actual
            idiom.AgregarObservador(LMG); // Agregar observador

        }

        private void verReportes_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes(lang);
            r.MdiParent = this;
            r.Show();
        }

        private void cargarReportes_Click(object sender, EventArgs e)
        {
            var usuario= Validación.usuario;
            Tareas t = new Tareas(lang, usuario);
            t.MdiParent = this;
            t.Show();
        }

        private void GestionUsuarios_Click(object sender, EventArgs e)
        {
            
            GestionUsuarios us = new GestionUsuarios(lang);
            us.MdiParent = this;
            us.Show();
        }

        private void GestionPerfiles_Click(object sender, EventArgs e)
        {
            GestionarPerfiles gf = new GestionarPerfiles(lang);
            gf.MdiParent = this;
            gf.Show();
        }

        private void Bitacora_Click(object sender, EventArgs e)
        {
            Bitacora b = new Bitacora(lang);
            b.MdiParent = this;
            b.Show();
        }

        private void cambiarclave_Click(object sender, EventArgs e)
        {
            //Hacer
        }


        public void CambiarIdioma(string idioma)
        {
            if (idioma == null) { idioma = "Español"; }

            if (!LMG.Forms.Contains(this))
            {
                LMG.RegistrarForm(this); // Registrar el formulario si no está registrado
            }

            idiom.AgregarObservador(LMG); // Agregar observador si aún no lo es
            idiom.CambiarIdioma(idioma); // Cambiar idioma
            MessageBox.Show($"Idioma cambiado a: {idioma}");
            lang = idioma;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro?", "Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Validación.LogOut();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                admin.Enabled = false;
                reportes.Enabled = false;
            }
            else
            {
                CancelarOperacion();
            }
           
        }

        private void CancelarOperacion()
        {
            // Crear y configurar el Label
            Label lblCancelando = new Label
            {
                Text = "Cancelando operación...",
                Location = new System.Drawing.Point(30, 50), // Cambia la posición según tu diseño
                AutoSize = true
            };

            // Crear y configurar el ProgressBar
            ProgressBar progressBar = new ProgressBar
            {
                Location = new System.Drawing.Point(30, 60), // Cambia la posición según tu diseño
                Width = 300,
                Height = 30,
                Minimum = 0,
                Maximum = 100,
                Value = 0,
                Step = 1,
            };

            // Añadir el Label y el ProgressBar al formulario
            this.Controls.Add(lblCancelando);
            this.Controls.Add(progressBar);

            // Usar un hilo en segundo plano para evitar bloquear la UI
            System.Threading.Thread thread = new System.Threading.Thread(() =>
            {
                // Simular el proceso de cancelación
                for (int i = 0; i <= 100; i++)
                {
                    System.Threading.Thread.Sleep(50); // Simular trabajo (50 ms por paso)
                    // Actualizar el ProgressBar en el hilo de la UI
                    this.Invoke((Action)(() => progressBar.Value = i));
                }

                // Mostrar el mensaje de operación cancelada en el hilo de la UI
                this.Invoke((Action)(() =>
                {
                    MessageBox.Show("Operación cancelada.");
                    this.Controls.Remove(lblCancelando); // Quitar el Label después de usarlo
                    this.Controls.Remove(progressBar); // Quitar el ProgressBar después de usarlo
                }));
            });

            // Iniciar el hilo
            thread.Start();
        }

        internal void ActivarIngeniero()
        {
            reportes.Enabled = true;
        }

        internal void ActivarUsuario()
        {
            throw new NotImplementedException();
        }

        internal void ActivarAdministrador()
        {
            admin.Enabled = true;
        }

        private void idioma_Click(object sender, EventArgs e)
        {
            var usuario = Validación.usuario;
            CambiarIdioma ci = new CambiarIdioma(usuario, lang);
            ci.MdiParent = this;
            ci.Show();
        }
    }
}
