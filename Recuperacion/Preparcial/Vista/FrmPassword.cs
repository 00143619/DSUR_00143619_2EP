using Preparcial.Controlador;
using Preparcial.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preparcial.Vista
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        private void FrmPassword_Load(object sender, EventArgs e)
        {
            //#10: identacion
            pictureBox1.BackgroundImage = Image.FromFile("../../Recursos/UCA.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            ActualizarControlers();
         }

        //#11: identacion
        private void ActualizarControlers()
        { 
            //#16: inicializar cmb en null
            comboBox1.ValueMember = "Contrasena";
            comboBox1.DataSource = ControladorUsuario.GetUsuarios();
            comboBox1.DisplayMember = "NombreUsuario";
        }

        //#12: identacion
        private void Button1_Click(object sender, EventArgs e)
        { 
            if (txtOldPassword.Text.Equals(comboBox1.SelectedValue.ToString())) 
            {
                var obtenerUsuario = (Usuario)comboBox1.SelectedItem;
                
                ControladorUsuario.ActualizarContrasena(obtenerUsuario.IdUsuario, txtNewPassword.Text); 
                //#13: se debe actualizar los controles hasta despues para que pueda cargarse la nueva contraseña
                ActualizarControlers();
            }
            else 
                MessageBox.Show("Contrasena actual incorrecta");
        }
    }
}
