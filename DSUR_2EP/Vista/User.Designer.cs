using System.ComponentModel;

namespace DSUR_2EP.Properties
{
    partial class User
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabUser = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtvAddress = new System.Windows.Forms.DataGridView();
            this.groupDelate = new System.Windows.Forms.GroupBox();
            this.txtdeleteaddress = new System.Windows.Forms.TextBox();
            this.btnDelateAddress = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupModify = new System.Windows.Forms.GroupBox();
            this.btnModifyAddress = new System.Windows.Forms.Button();
            this.cmbaddressModificate = new System.Windows.Forms.ComboBox();
            this.txtAddressModification = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxCreate = new System.Windows.Forms.GroupBox();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.txtAddressa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtvOrders = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbDelateOrder = new System.Windows.Forms.Button();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPlace = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAddressOrder = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabUser.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dtvAddress)).BeginInit();
            this.groupDelate.SuspendLayout();
            this.groupModify.SuspendLayout();
            this.gbxCreate.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dtvOrders)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.tabPage1);
            this.tabUser.Controls.Add(this.tabPage2);
            this.tabUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUser.Location = new System.Drawing.Point(0, 0);
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedIndex = 0;
            this.tabUser.Size = new System.Drawing.Size(834, 441);
            this.tabUser.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupDelate);
            this.tabPage1.Controls.Add(this.groupModify);
            this.tabPage1.Controls.Add(this.gbxCreate);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Address";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtvAddress);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox1.Location = new System.Drawing.Point(398, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 208);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View my address";
            // 
            // dtvAddress
            // 
            this.dtvAddress.AllowUserToOrderColumns = true;
            this.dtvAddress.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvAddress.Location = new System.Drawing.Point(6, 22);
            this.dtvAddress.Name = "dtvAddress";
            this.dtvAddress.Size = new System.Drawing.Size(373, 177);
            this.dtvAddress.TabIndex = 0;
            // 
            // groupDelate
            // 
            this.groupDelate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupDelate.Controls.Add(this.txtdeleteaddress);
            this.groupDelate.Controls.Add(this.btnDelateAddress);
            this.groupDelate.Controls.Add(this.label7);
            this.groupDelate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupDelate.Location = new System.Drawing.Point(398, 20);
            this.groupDelate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupDelate.Name = "groupDelate";
            this.groupDelate.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupDelate.Size = new System.Drawing.Size(399, 140);
            this.groupDelate.TabIndex = 5;
            this.groupDelate.TabStop = false;
            this.groupDelate.Text = "Delate";
            // 
            // txtdeleteaddress
            // 
            this.txtdeleteaddress.Location = new System.Drawing.Point(150, 45);
            this.txtdeleteaddress.Name = "txtdeleteaddress";
            this.txtdeleteaddress.Size = new System.Drawing.Size(149, 23);
            this.txtdeleteaddress.TabIndex = 15;
            // 
            // btnDelateAddress
            // 
            this.btnDelateAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelateAddress.Location = new System.Drawing.Point(166, 83);
            this.btnDelateAddress.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDelateAddress.Name = "btnDelateAddress";
            this.btnDelateAddress.Size = new System.Drawing.Size(134, 33);
            this.btnDelateAddress.TabIndex = 14;
            this.btnDelateAddress.Text = "Delate";
            this.btnDelateAddress.UseVisualStyleBackColor = true;
            this.btnDelateAddress.Click += new System.EventHandler(this.btnDelateAddress_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address id: ";
            // 
            // groupModify
            // 
            this.groupModify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupModify.Controls.Add(this.btnModifyAddress);
            this.groupModify.Controls.Add(this.cmbaddressModificate);
            this.groupModify.Controls.Add(this.txtAddressModification);
            this.groupModify.Controls.Add(this.label5);
            this.groupModify.Controls.Add(this.label4);
            this.groupModify.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupModify.Location = new System.Drawing.Point(5, 189);
            this.groupModify.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupModify.Name = "groupModify";
            this.groupModify.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupModify.Size = new System.Drawing.Size(365, 163);
            this.groupModify.TabIndex = 4;
            this.groupModify.TabStop = false;
            this.groupModify.Text = "Modify";
            // 
            // btnModifyAddress
            // 
            this.btnModifyAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModifyAddress.Location = new System.Drawing.Point(135, 111);
            this.btnModifyAddress.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnModifyAddress.Name = "btnModifyAddress";
            this.btnModifyAddress.Size = new System.Drawing.Size(119, 29);
            this.btnModifyAddress.TabIndex = 14;
            this.btnModifyAddress.Text = "Modify";
            this.btnModifyAddress.UseVisualStyleBackColor = true;
            this.btnModifyAddress.Click += new System.EventHandler(this.btnModifyAddress_Click);
            // 
            // cmbaddressModificate
            // 
            this.cmbaddressModificate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbaddressModificate.FormattingEnabled = true;
            this.cmbaddressModificate.Location = new System.Drawing.Point(103, 33);
            this.cmbaddressModificate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbaddressModificate.Name = "cmbaddressModificate";
            this.cmbaddressModificate.Size = new System.Drawing.Size(224, 23);
            this.cmbaddressModificate.TabIndex = 12;
            // 
            // txtAddressModification
            // 
            this.txtAddressModification.Location = new System.Drawing.Point(103, 78);
            this.txtAddressModification.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAddressModification.Name = "txtAddressModification";
            this.txtAddressModification.Size = new System.Drawing.Size(224, 23);
            this.txtAddressModification.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modification: ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address:";
            // 
            // gbxCreate
            // 
            this.gbxCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxCreate.BackColor = System.Drawing.Color.Transparent;
            this.gbxCreate.Controls.Add(this.btnAddAddress);
            this.gbxCreate.Controls.Add(this.txtAddressa);
            this.gbxCreate.Controls.Add(this.label1);
            this.gbxCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbxCreate.Location = new System.Drawing.Point(5, 20);
            this.gbxCreate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxCreate.Name = "gbxCreate";
            this.gbxCreate.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxCreate.Size = new System.Drawing.Size(365, 140);
            this.gbxCreate.TabIndex = 3;
            this.gbxCreate.TabStop = false;
            this.gbxCreate.Text = "Create";
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddAddress.Location = new System.Drawing.Point(107, 87);
            this.btnAddAddress.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(149, 31);
            this.btnAddAddress.TabIndex = 7;
            this.btnAddAddress.Text = "Add";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // txtAddressa
            // 
            this.txtAddressa.Location = new System.Drawing.Point(89, 42);
            this.txtAddressa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAddressa.Name = "txtAddressa";
            this.txtAddressa.Size = new System.Drawing.Size(250, 23);
            this.txtAddressa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtvOrders);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox2.Location = new System.Drawing.Point(93, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 202);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View my Orders";
            // 
            // dtvOrders
            // 
            this.dtvOrders.AllowUserToOrderColumns = true;
            this.dtvOrders.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvOrders.Location = new System.Drawing.Point(6, 22);
            this.dtvOrders.Name = "dtvOrders";
            this.dtvOrders.Size = new System.Drawing.Size(549, 168);
            this.dtvOrders.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.cmbDelateOrder);
            this.groupBox3.Controls.Add(this.cmbOrder);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(400, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Size = new System.Drawing.Size(420, 140);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delate";
            // 
            // cmbDelateOrder
            // 
            this.cmbDelateOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmbDelateOrder.Location = new System.Drawing.Point(143, 78);
            this.cmbDelateOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbDelateOrder.Name = "cmbDelateOrder";
            this.cmbDelateOrder.Size = new System.Drawing.Size(134, 33);
            this.cmbDelateOrder.TabIndex = 14;
            this.cmbDelateOrder.Text = "Delate";
            this.cmbDelateOrder.UseVisualStyleBackColor = true;
            this.cmbDelateOrder.Click += new System.EventHandler(this.cmbDelateOrder_Click);
            // 
            // cmbOrder
            // 
            this.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(83, 42);
            this.cmbOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(276, 23);
            this.cmbOrder.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Order:";
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.cmbPlace);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.cmbAddressOrder);
            this.groupBox5.Controls.Add(this.cmbProduct);
            this.groupBox5.Controls.Add(this.btnOrder);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(7, 16);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Size = new System.Drawing.Size(365, 167);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Order now";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Place:";
            // 
            // cmbPlace
            // 
            this.cmbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlace.FormattingEnabled = true;
            this.cmbPlace.Location = new System.Drawing.Point(118, 18);
            this.cmbPlace.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(224, 23);
            this.cmbPlace.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Address ";
            // 
            // cmbAddressOrder
            // 
            this.cmbAddressOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddressOrder.FormattingEnabled = true;
            this.cmbAddressOrder.Location = new System.Drawing.Point(118, 90);
            this.cmbAddressOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbAddressOrder.Name = "cmbAddressOrder";
            this.cmbAddressOrder.Size = new System.Drawing.Size(224, 23);
            this.cmbAddressOrder.TabIndex = 15;
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(118, 55);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(224, 23);
            this.cmbProduct.TabIndex = 13;
            // 
            // btnOrder
            // 
            this.btnOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOrder.Location = new System.Drawing.Point(135, 121);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(121, 31);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Product:";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tabUser);
            this.Name = "User";
            this.Size = new System.Drawing.Size(834, 441);
            this.Load += new System.EventHandler(this.User_Load);
            this.tabUser.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dtvAddress)).EndInit();
            this.groupDelate.ResumeLayout(false);
            this.groupDelate.PerformLayout();
            this.groupModify.ResumeLayout(false);
            this.groupModify.PerformLayout();
            this.gbxCreate.ResumeLayout(false);
            this.gbxCreate.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dtvOrders)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxCreate;
        private System.Windows.Forms.GroupBox groupModify;
        private System.Windows.Forms.GroupBox groupDelate;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.ComboBox cmbaddressModificate;
        private System.Windows.Forms.TextBox txtAddressModification;
        private System.Windows.Forms.Button btnModifyAddress;
        private System.Windows.Forms.Button btnDelateAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtvAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPlace;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbAddressOrder;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Button cmbDelateOrder;
        private System.Windows.Forms.DataGridView dtvOrders;
        private System.Windows.Forms.TextBox txtAddressa;
        private System.Windows.Forms.TextBox txtdeleteaddress;
    }
}