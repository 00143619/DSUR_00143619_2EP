using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DSUR_2EP.Modelo;


namespace DSUR_2EP.Properties
{
    public partial class Administrator : UserControl
    {
        
        public Administrator()
        {
            InitializeComponent();
            
        }
        
        private void updatecontrols()
        {
            txtnewUser.Clear();
            txtUsername.Clear();
            cmbUsers.DataSource = null;
            cmbUsers.ValueMember = "idUser";
            cmbUsers.DisplayMember = "username";
            cmbUsers.DataSource = AppuserDAO.getLista();
            txtDescription.Clear();
            txtNameB.Clear();
            cmbBusiness.DataSource = null;
            cmbBusiness.ValueMember = "idBusiness";
            cmbBusiness.DisplayMember = "name";
            cmbBusiness.DataSource = BussinessDAO.getLista();
            cmbCreatP.DataSource = null;
            cmbCreatP.ValueMember = "idBusiness";
            cmbCreatP.DisplayMember = "name";
            cmbCreatP.DataSource = BussinessDAO.getLista();
            cmbBussinesP.DataSource = null;
            cmbBussinesP.ValueMember = "idBusiness";
            cmbBussinesP.DisplayMember = "name";
            cmbBussinesP.DataSource = BussinessDAO.getLista();
            cmbProductsex.DataSource = null;
            txtProduct.Clear();
            actualizarDatagrid();
        }

        private void actualizarDatagrid()
        {
            var dt = AppuserDAO.allusers();
            dtvusers.DataSource = dt;
            var dtTable = AppOrderDAO.ordertable();
            dtvOrders.DataSource = dtTable;

        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            updatecontrols();
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            bool equals = true;
            foreach (Appuser a in AppuserDAO.getLista())
            {
                if (a.username.Equals(txtUsername.Text))
                    equals = true;
                else
                {
                    equals = false;
                }
            }

            if (!equals)
            {
                AppuserDAO.CreateUser(txtnewUser.Text, txtUsername.Text, txtUsername.Text,
                    rdioAdSi.Checked);
                MessageBox.Show("¡User has been added!",
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                updatecontrols();
            }
            else
            {
                MessageBox.Show("¡User already exist!",
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                updatecontrols();
            }
        }

        private void btnDelateuser_Click(object sender, EventArgs e)
        {
            AppuserDAO.delateUser(Convert.ToInt32(cmbUsers.SelectedValue.ToString()));
            MessageBox.Show("¡User has been deleted!",
                "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updatecontrols();
        }

        private void btnAddBusi_Click(object sender, EventArgs e)
        {
            BussinessDAO.CreateBusiness(txtNameB.Text,txtDescription.Text);
            MessageBox.Show("¡Business has been added!",
                "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updatecontrols();
            
        }

        private void delatebusi_Click(object sender, EventArgs e)
        {
            BussinessDAO.delateBusiness(Convert.ToInt32(cmbBusiness.SelectedValue.ToString()));
            MessageBox.Show("¡Business has been deleted!",
                "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updatecontrols();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductDAO.CreateProduct(Convert.ToInt32(cmbCreatP.SelectedValue.ToString()),txtProduct.Text);
            MessageBox.Show("¡Product has been added!",
                "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updatecontrols();
        }


        private void cmbBussinesP_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProductsex.DataSource = null;
            cmbProductsex.ValueMember = "idProduct";
            cmbProductsex.DisplayMember = "name";
            cmbProductsex.DataSource = ProductDAO.getLista(
                Convert.ToInt32(cmbBussinesP.SelectedValue.ToString()));
            
        }

        private void btnDelateProduct_Click(object sender, EventArgs e)
        {
            ProductDAO.delateproduct(Convert.ToInt32(cmbProductsex.SelectedValue.ToString()));
            MessageBox.Show("¡Product has been deleted!",
                "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updatecontrols();
        }
    }
}