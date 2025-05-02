using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_lluvia_Ivan_Dana
{
    public partial class GestionarPerfiles : Form
    {
        string Idi;
        public GestionarPerfiles(string idi)
        {
            InitializeComponent();
            Idi = idi;
        }

        private void GestionarPerfiles_Load(object sender, EventArgs e)
        {

        }
    }
}
