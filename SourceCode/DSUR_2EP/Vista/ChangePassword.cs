using System;
using System.Windows.Forms;
using DSUR_2EP.Modelo;

namespace DSUR_2EP.Properties
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            cmbUsername.DataSource = null;
            cmbUsername.ValueMember = "password";
            cmbUsername.DisplayMember = "username";
            cmbUsername.DataSource = AppuserDAO.getLista();
        }

        private void btnChangeP_Click(object sender, EventArgs e)
        {
            Appuser u = (Appuser) cmbUsername.SelectedItem;
            bool actualIgual = txtCurrent.Text.Equals(cmbUsername.SelectedValue.ToString());
            bool nuevaIgual = txtNew.Text.Equals(txtConfirm.Text);
            bool nuevavalida = false;
            try
            {
                if (txtNew.Text.Length < 3)
                    throw new InvalidPasswordException();
                else
                {
                    nuevavalida = true;
                }
                
            }
            catch (InvalidPasswordException)
            {
                MessageBox.Show("¡Ups! the password is too short!.", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


            if (actualIgual && nuevaIgual && nuevavalida)
            {
                try
                {
                    AppuserDAO.updatePassword(u.idUser, txtNew.Text);
                    MessageBox.Show("¡The password has been changed succesfully!", 
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Ups! Please try later.", 
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("¡Verify if the password is correct!", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}