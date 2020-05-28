using System;
using System.Windows.Forms;
using DSUR_2EP.Modelo;

namespace DSUR_2EP.Properties
{
    public partial class User : UserControl
    {
        private Appuser user;
      
        public User(Appuser pUser)
        {
            InitializeComponent();
            user= pUser;
        }

        private void UpdateControls()
        {
            txtAddressa.Clear();
            cmbaddressModificate.DataSource = null;
            cmbaddressModificate.ValueMember = "idAddress";
            cmbaddressModificate.DisplayMember = "address";
            cmbaddressModificate.DataSource = Address_DAO.getListaforUser(user.idUser);
            txtAddressModification.Clear();
            txtdeleteaddress.Clear();
            cmbPlace.DataSource = null;
            cmbPlace.ValueMember = "idBusiness";
            cmbPlace.DisplayMember = "name";
            cmbPlace.DataSource = BussinessDAO.getLista();
            cmbAddressOrder.DataSource = null;
            cmbAddressOrder.ValueMember = "idAddress";
            cmbAddressOrder.DisplayMember = "address";
            cmbAddressOrder.DataSource = Address_DAO.getListaforUser(user.idUser);
            cmbOrder.DataSource = null;
            cmbOrder.ValueMember = "idOrder";
            cmbOrder.DisplayMember = "productname";
            cmbOrder.DataSource = AppOrderDAO.getListaforUser(user.idUser);
            cmbProduct.DataSource = null;
            actualizarDatagrid();
        }
        private void actualizarDatagrid()
        {
            var dt = Address_DAO.addressUser(user.idUser);
            dtvAddress.DataSource = dt;
            var dt1 = AppOrderDAO.orderuser(user.idUser);
            dtvOrders.DataSource = dt1;
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            try
            {

                Address_DAO.addAdress(user.idUser,txtAddressa.Text);
                MessageBox.Show("¡The address has been added!.",
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                UpdateControls();

            }
            catch (Exception)
            {
                MessageBox.Show("The address can not be added, try again.",
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnModifyAddress_Click(object sender, EventArgs e)
        {
            Address_DAO.updateAddress(Convert.ToInt32(cmbaddressModificate.SelectedValue.ToString()),
                txtAddressModification.Text);
            MessageBox.Show("¡Address has been updated!",
                "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateControls();
            
        }

        

        private void btnDelateAddress_Click(object sender, EventArgs e)
        {
            Address_DAO.delateAddress(Convert.ToInt32(txtdeleteaddress.Text));
            MessageBox.Show("¡Address has been added!",
                "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            UpdateControls();
            
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            AppOrderDAO.Order(Convert.ToInt32(cmbProduct.SelectedValue.ToString()),
                Convert.ToInt32(cmbAddressOrder.SelectedValue.ToString()));
            MessageBox.Show("¡Order has been added!",
                "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            UpdateControls();
        }

        private void cmbDelateOrder_Click(object sender, EventArgs e)
        {
            AppOrderDAO.delateOrder(Convert.ToInt32(cmbOrder.SelectedValue.ToString()));
            MessageBox.Show("¡Order has been deleted!",
                "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            UpdateControls();
            
        }

        private void cmbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProduct.DataSource = null;
            cmbProduct.ValueMember = "idProduct";
            cmbProduct.DisplayMember = "name";
            cmbProduct.DataSource = ProductDAO.getLista(Convert.ToInt32(cmbPlace.SelectedValue.ToString()));
        }

        private void User_Load(object sender, EventArgs e)
        {
            UpdateControls();
        }
    }
}