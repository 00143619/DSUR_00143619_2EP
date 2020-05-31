using Preparcial.Modelo;
using Preparcial.Controlador;
using System.Windows.Forms;
using System.Linq;
using System;

namespace Preparcial.Vista
{
    public partial class FrmMain : Form
    {
        //#14: inicializar variable
        private Usuario u=null;

        public FrmMain(Usuario u)
        {
            InitializeComponent();
            //#3: el group box se tiene que llamar 'Atualizar producto' 
            this.groupBox3.Text = "Actualizar producto";
            this.u = u;
        }

        private void bttnCreateUser_Click(object sender, EventArgs e)
        {
            if (!txtNewUser.Text.Equals(""))
            {
                ControladorUsuario.CrearUsuario(txtNewUser.Text);
                ActualizarCrearUsuario();
            }
        }

        private void ActualizarCrearUsuario()
        {
            dgvCreateUser.DataSource = ControladorUsuario.GetUsuariosTable();
        }

        private void ActualizarInventario()
        {
            dgvInventary.DataSource = ControladorInventario.GetProductosTable();
        }

        private void ActualizarOrdenes()
        {
            dgvAllOrders.DataSource = ControladorPedido.GetPedidosTable();
        }

        private void ActualizarOrdenesUsuario()
        {
            dgvMyOrders.DataSource = ControladorPedido.GetPedidosUsuarioTable(u.IdUsuario);
            //corregir idarticulo por idArticulo 
            //#15: inicializar cmb en null
            cmbProductMakeOrder.DataSource = null;
            cmbProductMakeOrder.ValueMember = "idArticulo";
            cmbProductMakeOrder.DisplayMember = "producto";
            cmbProductMakeOrder.DataSource = ControladorInventario.GetProductos();
        }

        private void bttnAddInventary_Click(object sender, EventArgs e)
        {
            //#4: tienen que cotenplarse el caso de que alguno este vacio no todos
            if (txtProductNameInventary.Text.Equals("")||
                txtDescriptionInventary.Text.Equals("")||
                txtPriceInventary.Text.Equals("") ||
                txtStockInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                //#5: identacion
                ControladorInventario.AnadirProducto(txtProductNameInventary.Text, 
                    txtDescriptionInventary.Text,
                    txtPriceInventary.Text, txtStockInventary.Text);

                ActualizarInventario();
            }
        }

        private void bttnDeleteInventary_Click(object sender, EventArgs e)
        {
            if(txtDeleteInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.EliminarProducto(txtDeleteInventary.Text);
                ActualizarInventario();
            }
        }

        private void bttnUpdateStockInventary_Click(object sender, EventArgs e)
        {
            //#6: tiene que contemplarse de que puede estar un campo vacio y el otro no 
            if (txtUpdateStockIdInventary.Text.Equals("") || txtUpdateStockInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.ActualizarProducto(txtUpdateStockIdInventary.Text, txtUpdateStockInventary.Text);
                ActualizarInventario();
            }
        }

        private void bttnMakeOrder_Click(object sender, EventArgs e)
        {
            if (txtMakeOrderQuantity.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                //#7: identacion
                ControladorPedido.HacerPedido(u.IdUsuario, cmbProductMakeOrder.SelectedValue.ToString(),
                    txtMakeOrderQuantity.Text);
                ActualizarOrdenesUsuario();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name.Equals("createNewUserTab") && u.Admin)
                ActualizarCrearUsuario();

            else if (tabControl1.SelectedTab.Name.Equals("inventaryTab") && u.Admin)
                ActualizarInventario();

            else if (tabControl1.SelectedTab.Name.Equals("createOrderTab") && !u.Admin)
                ActualizarOrdenesUsuario();

            else if (tabControl1.SelectedTab.Name.Equals("viewOrdersTab") && u.Admin)
                ActualizarOrdenes();
            
            else
            {
                //#8: el cambio al regresarse el genralTab no estaba contemplado por eso aparecia el 
                //doble mensaje
                if (!tabControl1.SelectedTab.Name.Equals("generalTab"))
                {
                    MessageBox.Show("No tiene permisos para ver esta pestana");
                    tabControl1.SelectedTab = tabControl1.TabPages[0];
                }
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //#9: identacion
            Application.Exit();
        }

        
    }
}
