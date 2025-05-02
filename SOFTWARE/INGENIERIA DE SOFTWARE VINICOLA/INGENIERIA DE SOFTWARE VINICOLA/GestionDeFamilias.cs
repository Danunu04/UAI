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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace INGENIERIA_DE_SOFTWARE_VINICOLA
{
    public partial class GestionDeFamilias : Form
    {
        BLLPerfil NegociosFamilia = new BLLPerfil();
        BLLPermiso NegociosPermiso = new BLLPermiso();
        Negocios negocios = new Negocios();

        frmInicio parent;
        public GestionDeFamilias()
        {
            InitializeComponent();
        }

        private void BTNCrearFamilia_Click(object sender, EventArgs e)
        {
            if (TXTFamilia.Text == "")
            {
                MessageBox.Show("Ingresar Nombre de Familia");
            }
            else if (negocios.RevisarDisponibilidad(TXTFamilia.Text, "Nombre", "Familia") == false)
            {
                int CodFamilia = NegociosFamilia.ObtenerSiguienteCodigo();

                NegociosFamilia.CrearComponente(CodFamilia, TXTFamilia.Text, false);

                LlenarCombobox();

                MessageBox.Show("Familia Creada");

                parent.FormGestionDePerfiles.LlenarCombobox();
            }
          
        }
        private void LlenarCombobox()
        {
            

            CBPermisos.DataSource = NegociosPermiso.ObtenerPermisos();
            CBPermisos.DisplayMember = "Nombre";
            CBPermisos.ValueMember = "CodPermiso";

            CBFamilias.DataSource = NegociosFamilia.ObtenerFamilias();
            CBFamilias.DisplayMember = "Nombre";
            CBFamilias.ValueMember = "CodFamilia";

            
        }

        private void GestionDeFamilias_Load(object sender, EventArgs e)
        {
            LlenarCombobox();
            parent = this.MdiParent as frmInicio;
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
                }

                if (PermisoYaAgregado == false)
                {
                    treeView1.Nodes[0].Nodes.Add(CBPermisos.Text);
                }
            }catch (Exception)
            {



            }
        }
        private void CBFamilias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count == 0 || treeView1.Nodes[0].Text != CBFamilias.Text)
            {
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(CBFamilias.Text);

                DataRowView r = CBFamilias.SelectedItem as DataRowView;

                foreach (DataRow dr in NegociosFamilia.ObtenerPermisosFamilia(r.Row[0].ToString()).Rows)
                {
                    treeView1.Nodes[0].Nodes.Add(dr[0].ToString());
                }
            }
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

        private void GestionDeFamilias_VisibleChanged(object sender, EventArgs e)
        {
            LlenarCombobox();
        }

        private void BTNAplicar_Click(object sender, EventArgs e)
        {
            NegociosFamilia.ActualizarFamilia(treeView1.Nodes[0], CBPermisos, CBFamilias);

            MessageBox.Show("Familia actualizada");

            frmInicio parent = this.MdiParent as frmInicio;

            parent.login.ModificarMenu(SessionManager.ObtenerInstancia().Usuario.Rol);
        }

        private void BTNEliminarFamilia_Click(object sender, EventArgs e)
        {
            if (TXTFamilia.Text == "")
            {
                MessageBox.Show("Ingresar Nombre de Familia");
            }
            else if (negocios.RevisarDisponibilidad(TXTFamilia.Text, "F2.Nombre", "Familia INNER JOIN Familia F2 ON Familia.CodComp = F2.CodFamilia"))
            {
                MessageBox.Show("FamiliaEnUso");
            }
            else if (negocios.RevisarDisponibilidad(TXTFamilia.Text, "Nombre", "Familia") && NegociosFamilia.VerificarTipo(TXTFamilia.Text) == false)
            {
                NegociosFamilia.EliminarRegistro(TXTFamilia.Text, "Nombre", "Familia");

                LlenarCombobox();

                MessageBox.Show("FamiliaEliminada");

                parent.FormGestionDePerfiles.LlenarCombobox();
            }
        }

        private void GestionDeFamilias_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}