using System;
using System.Windows.Forms;
using DSUR_2EP.Modelo;

namespace DSUR_2EP.Properties
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }
        
        private void UpdateControls()
        {
            
            cmbUsername.DataSource = null;
            cmbUsername.ValueMember = "password";
            cmbUsername.DisplayMember = "username";
            cmbUsername.DataSource = AppuserDAO.getLista();
            txtPassword.Clear();
        }
        

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword unaVentana = new ChangePassword();
            unaVentana.ShowDialog();
            UpdateControls();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(cmbUsername.SelectedValue.ToString()))
            {
                Appuser u = (Appuser) cmbUsername.SelectedItem;
                MainForm ventana =new MainForm(u);
                ventana.Show();
                this.Hide();
            }
            else
                MessageBox.Show("¡Incorrect Password, try again!", "Hugo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
       
    }
}