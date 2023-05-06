using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAriasExequielSp1
{
    public partial class frmSinterpartSRL : Form
    {
        public frmSinterpartSRL()
        {
            InitializeComponent();
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {

        }

        private void cmdComenzar_Click(object sender, EventArgs e)
        {
           frmLogin ventanaLogin = new frmLogin();
            ventanaLogin.ShowDialog();
        }
    }
}
