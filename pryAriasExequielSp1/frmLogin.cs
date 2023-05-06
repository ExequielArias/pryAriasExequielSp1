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
    
    public partial class frmLogin : Form
    {
        //declaracion de variables 

        int cantidadErrores = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            funcionCierre(cantidadErrores);


        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            var usuario = txtUsuario.Text; 
            var contraseña = txtContraseña.Text;
            var modulo = cboModulo.Text;
            frmBienvenida ventanaBienvenida = new frmBienvenida();
            frmError ventanaError = new frmError();
            frmLogin ventanaLogin = new frmLogin(); 
            bool datosOk = false;

            switch (usuario) 
            {
                case "Adm":
                    if (contraseña== "@1a" && (modulo == "ADM (Administracion)" || modulo == "COM (Compras)" || modulo == "VTA (Ventas)"))
                        datosOk = true;
                    break;
                case "Ceci":
                    if (contraseña == "*@3c" && (modulo == "ADM (Administracion)" || modulo == "VTA (Ventas)"))
                        datosOk = true;
                    break;
                case "John":
                    if (contraseña == "*2b" && (modulo == "SIST (Sistemas)"))
                        datosOk = true;
                    break ;
                case "God":
                    if (contraseña == "*@#4d" && modulo != "")
                        datosOk = true; 
                    
                    break;
                    default:                    
                    break;

            }

            if (datosOk)
            {
                cantidadErrores = 0;
                this.Close();
                ventanaBienvenida.ShowDialog();

            }
            else
            {
                cantidadErrores++;
                ventanaError.ShowDialog();
                funcionCierre(cantidadErrores);
            }
        }

        private void funcionCierre(int cantidadErrores)
        {

            if (cantidadErrores == 2)
            {
                this.Close();
            }
        }
}
}
