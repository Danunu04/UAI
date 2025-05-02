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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using BLL;
using BE;
using iText.Kernel.Events;


namespace Registro_lluvia_Ivan_Dana
{

    public partial class CambiarIdioma : Form
    {
        LanguajeManager LMG = new LanguajeManager();
        Idioma idiom = new Idioma();
        string Idi = "";
        BLLUsuario BLLU = new BLLUsuario();
        BEUsuario user;
        BLLEventos BLLE = new BLLEventos();
        Evento even = null;
        public CambiarIdioma(BEUsuario usuario, string lang)
        {
            InitializeComponent();
            user = usuario;
            Idi = lang;
        }

        private void CambiarIdioma_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
           
            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;

            button3.FlatStyle = FlatStyle.Flat;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            if (Idi == "")
            {
                Idi = "Español";
            }
             (this.MdiParent as Inicio)?.CambiarIdioma(Idi);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Idi = "Ingles";
            (this.MdiParent as Inicio)?.CambiarIdioma(Idi);
            if (user != null)
            {
                DialogResult resultado = MessageBox.Show("¿Desea cargar de forma definitiva en su usuario?",
                                         "Confirmación",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

                // Verificar la respuesta
                if (resultado == DialogResult.Yes)
                {
                    BLLU.SetearIdioma(Idi, user);
                    string evento = "Cuenta del usuario" + user.Usuario + " bloqueada tras 3 intentos fallidos";
                    even = new Evento(user.Usuario.ToString(), DateTime.Now,"Cambiar Idioma", "Guardó el idioma ingles", 3);
                    BLLE.RegistrarEvento(even);
                }
                else
                {
                    MessageBox.Show("Acción cancelada");
                    even = new Evento(user.Usuario.ToString(), DateTime.Now, "Cambiar Idioma", "Accion Cancelada", 3);
                    BLLE.RegistrarEvento(even);
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Idi = "Español";
            (this.MdiParent as Inicio)?.CambiarIdioma(Idi);
            if (user != null)
            {
                DialogResult resultado = MessageBox.Show("¿Desea cargar de forma definitiva en su usuario?",
                                         "Confirmación",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

                // Verificar la respuesta
                if (resultado == DialogResult.Yes)
                {
                    BLLU.SetearIdioma(Idi, user);
                   
                    even = new Evento(user.Usuario.ToString(), DateTime.Now, "Cambiar Idioma", "Guardó el idioma Español", 3);
                    BLLE.RegistrarEvento(even);
                }
                else
                {
                    MessageBox.Show("Acción cancelada");
                    even = new Evento(user.Usuario.ToString(), DateTime.Now, "Cambiar Idioma", "Accion Cancelada", 3);
                    BLLE.RegistrarEvento(even);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Idi = "Portugues";
            (this.MdiParent as Inicio)?.CambiarIdioma(Idi);
            if (user != null)
            {
                DialogResult resultado = MessageBox.Show("¿Desea cargar de forma definitiva en su usuario?",
                                         "Confirmación",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

                // Verificar la respuesta
                if (resultado == DialogResult.Yes)
                {
                    BLLU.SetearIdioma(Idi, user);
                   
                    even = new Evento(user.Usuario.ToString(), DateTime.Now, "Cambiar Idioma", "Guardó el idioma Portugues", 3);
                    BLLE.RegistrarEvento(even);
                }
                else
                {
                    MessageBox.Show("Acción cancelada");
                    
                    even = new Evento(user.Usuario.ToString(), DateTime.Now, "Cambiar Idioma", "Accion Cancelada", 3);
                    BLLE.RegistrarEvento(even);
                }
                
            }
        }
    }
}
