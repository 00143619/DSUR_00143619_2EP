using System;
using System.Windows.Forms;
using DSUR_2EP.Modelo;

namespace DSUR_2EP.Properties
{
    public partial class MainForm : Form
    {
        private Appuser user;
        private UserControl current = null;
        public MainForm(Appuser Puser)
        {
            InitializeComponent();
            user = Puser;
            current= new User(user);
            tbl1.Controls.Add(current, 0, 1);
            current.Dock= DockStyle.Fill;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (user.userType)
            {
                tbl1.Controls.Remove(current);
                current = new Administrator();
                tbl1.Controls.Add(current, 0, 0);
                current.Dock = DockStyle.Fill;
            }
            else
            {
                tbl1.Controls.Remove(current);
                current = new User(user);
                tbl1.Controls.Add(current, 0, 0);
                current.Dock = DockStyle.Fill;
            }
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}