using BLL;
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


namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    public partial class GestionDePerfiles : Form, IObserver
    {
       Negocios negocios = new Negocios();
       BLLPerfil NegociosFamilia = new BLLPerfil();
       BLLPermiso NegociosPermiso = new BLLPermiso();

        frmInicio parent;
      
        public GestionDePerfiles()
        {
            InitializeComponent();
            LanguageManager.ObtenerInstancia().Agregar(this);
        }
        public void ActualizarIdioma()
        {
            LanguageManager.ObtenerInstancia().CambiarIdiomaControles(this);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GestionDePerfiles_Load(object sender, EventArgs e)
        {
            parent = this.MdiParent as frmInicio;
            LlenarCombobox();
        }

        public void LlenarCombobox()
        {
            

            CBPermisos.DataSource = NegociosPermiso.ObtenerPermisos();
            CBPermisos.DisplayMember = "Nombre";
            CBPermisos.ValueMember = "CodPermiso";

            CBFamilias.DataSource = NegociosFamilia.ObtenerFamilias();
            CBFamilias.DisplayMember = "Nombre";
            CBFamilias.ValueMember = "CodFamilia";

            CBPerfiles.DataSource = NegociosFamilia.ObtenerPerfiles();
            CBPerfiles.DisplayMember = "Nombre";
            CBFamilias.ValueMember = "CodFamilia";

            
        }

        private void BTNAplicar_Click(object sender, EventArgs e)
        {
            NegociosFamilia.ActualizarPerfil(treeView1.Nodes[0], CBPermisos, CBFamilias, CBPerfiles);

            MessageBox.Show("Perfil actualizado");

            frmInicio parent = this.MdiParent as frmInicio;

            parent.login.ModificarMenu(SessionManager.ObtenerInstancia().Usuario.Rol);
        }

        private void BTNConfigurarFamilias_Click(object sender, EventArgs e)
        {
            parent.formGestionFamilias.Show();
        }

        private void BTNAgregarFamilia_Click_1(object sender, EventArgs e)
        {
            bool FamiliaYaAgregada = false;
            bool PermisoYaAgregado = false;

            try
            {
                foreach (TreeNode n in treeView1.Nodes[0].Nodes)
                {
                    if (n.Text == CBFamilias.Text)
                    {
                        FamiliaYaAgregada = true;
                    }
                }

                if (FamiliaYaAgregada == false)
                {
                    TreeNode nodo = treeView1.Nodes[0].Nodes.Add(CBFamilias.Text);

                    foreach (DataRow dr2 in NegociosFamilia.ObtenerPermisosPorNombreFamilia(CBFamilias.Text).Rows)
                    {
                        foreach (TreeNode n in treeView1.Nodes[0].Nodes)
                        {
                            if (n.Text == dr2[0].ToString())
                            {
                                PermisoYaAgregado = true;
                            }
                            else if (n.Nodes.Count != 0)
                            {
                                foreach (TreeNode n1 in n.Nodes)
                                {
                                    if (n1.Text == dr2[0].ToString())
                                    {
                                        PermisoYaAgregado = true;
                                    }
                                }
                            }
                        }

                        nodo.Nodes.Add(dr2[0].ToString());
                    }
                }
               

                if (PermisoYaAgregado == true)
                {
                    foreach (TreeNode n in treeView1.Nodes[0].Nodes)
                    {
                        if (n.Text == CBFamilias.Text)
                        {
                            treeView1.Nodes.Remove(n);
                        }
                    }
                    MessageBox.Show("PermisoDeFamiliaRepetido");

                }
            }
            catch (Exception) { }
        }

        private void BTNAgregarPermiso_Click(object sender, EventArgs e)
        {
            bool PermisoYaAgregado = false;

            try
            {
                foreach (TreeNode n in treeView1.Nodes[0].Nodes)
                {
                    if (n.Text == CBPermisos.Text)
                    {
                        PermisoYaAgregado = true;
                    }
                    else if (n.Nodes.Count != 0)
                    {
                        foreach (TreeNode n1 in n.Nodes)
                        {
                            if (n1.Text == CBPermisos.Text)
                            {
                                PermisoYaAgregado = true;
                            }
                        }
                    }
                }

                if (PermisoYaAgregado == false)
                {
                    treeView1.Nodes[0].Nodes.Add(CBPermisos.Text);
                }
                else
                {
                    MessageBox.Show("PermisoYaSeleccionado");
                }
            }
            catch (Exception) { }
        }

        private void BTNCrearPerfil_Click(object sender, EventArgs e)
        {
            if (negocios.RevisarDisponibilidad(TXTPerfil.Text, "Nombre", "Familia") == false)
            {
                int CodPerfil = NegociosFamilia.ObtenerSiguienteCodigo();

                NegociosFamilia.CrearComponente(CodPerfil, TXTPerfil.Text, true);
                LlenarCombobox();

                MessageBox.Show("Perfil creado");

                parent.formGestionUsuarios.comboBox1.DataSource = NegociosFamilia.ObtenerPerfiles();
                parent.formGestionUsuarios.comboBox1.DisplayMember = "Nombre";
            }
        }

        private void BTNEliminarPerfil_Click(object sender, EventArgs e)
        {
             if (negocios.RevisarDisponibilidad(TXTPerfil.Text, "Rol", "Usuario"))
             {
                MessageBox.Show("PerfilEnUso");
             }
            else if (negocios.RevisarDisponibilidad(TXTPerfil.Text, "Nombre", "Familia") && NegociosFamilia.VerificarTipo(TXTPerfil.Text) == true)
            {
                NegociosFamilia.EliminarRegistro(TXTPerfil.Text, "Nombre", "Familia");

                LlenarCombobox();

                MessageBox.Show("PerfilEliminado");

                parent.formGestionUsuarios.comboBox1.DataSource = NegociosFamilia.ObtenerPerfiles();
                parent.formGestionUsuarios.comboBox1.DisplayMember = "Nombre";
            }
        }

        private void CBPerfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count == 0 || treeView1.Nodes[0].Text != CBPerfiles.Text)
            {
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(CBPerfiles.Text);

                DataRowView r = CBPerfiles.SelectedItem as DataRowView;

                foreach (DataRow dr in NegociosFamilia.ObtenerPermisosFamilia(r.Row[0].ToString()).Rows)
                {
                    treeView1.Nodes[0].Nodes.Add(dr[0].ToString());
                }

                foreach (DataRow dr in NegociosFamilia.ObtenerFamiliasPerfil(r.Row[0].ToString()).Rows)
                {
                    TreeNode nodo = treeView1.Nodes[0].Nodes.Add(dr[0].ToString());

                    foreach (DataRow dr2 in NegociosFamilia.ObtenerPermisosPorNombreFamilia(dr[0].ToString()).Rows)
                    {
                        nodo.Nodes.Add(dr2[0].ToString());
                    }
                }
            }
            
        }

        private void GestionDePerfiles_VisibleChanged(object sender, EventArgs e)
        {
            LlenarCombobox();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeViewHitTestInfo hitTest = treeView1.HitTest(e.Location);

            if (hitTest.Location != TreeViewHitTestLocations.PlusMinus)
            {
                if (e.Node.Parent != null)
                {
                    if (e.Node.Parent != treeView1.Nodes[0])
                    {
                        treeView1.Nodes.Remove(e.Node.Parent);
                    }
                    else
                    {
                        treeView1.Nodes.Remove(e.Node);
                    }
                }
            }
        }

        private void GestionDePerfiles_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();

            }
        }
    }
}

