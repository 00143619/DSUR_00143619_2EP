using System.ComponentModel;

namespace DSUR_2EP.Properties
{
    partial class Administrator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtvusers = new System.Windows.Forms.DataGridView();
            this.groupDelate = new System.Windows.Forms.GroupBox();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.btnDelateuser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxCreate = new System.Windows.Forms.GroupBox();
            this.rdioAdNo = new System.Windows.Forms.RadioButton();
            this.rdioAdSi = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtnewUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbBusiness = new System.Windows.Forms.ComboBox();
            this.delatebusi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddBusi = new System.Windows.Forms.Button();
            this.txtNameB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbProductsex = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBussinesP = new System.Windows.Forms.ComboBox();
            this.btnDelateProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbCreatP = new System.Windows.Forms.ComboBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.dtvOrders = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dtvusers)).BeginInit();
            this.groupDelate.SuspendLayout();
            this.gbxCreate.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dtvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupDelate);
            this.tabPage1.Controls.Add(this.gbxCreate);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtvusers);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox1.Location = new System.Drawing.Point(82, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 188);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View all users";
            // 
            // dtvusers
            // 
            this.dtvusers.AllowUserToOrderColumns = true;
            this.dtvusers.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvusers.Location = new System.Drawing.Point(6, 22);
            this.dtvusers.Name = "dtvusers";
            this.dtvusers.Size = new System.Drawing.Size(531, 152);
            this.dtvusers.TabIndex = 0;
            // 
            // groupDelate
            // 
            this.groupDelate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupDelate.Controls.Add(this.cmbUsers);
            this.groupDelate.Controls.Add(this.btnDelateuser);
            this.groupDelate.Controls.Add(this.label7);
            this.groupDelate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupDelate.Location = new System.Drawing.Point(447, 33);
            this.groupDelate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupDelate.Name = "groupDelate";
            this.groupDelate.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupDelate.Size = new System.Drawing.Size(360, 140);
            this.groupDelate.TabIndex = 9;
            this.groupDelate.TabStop = false;
            this.groupDelate.Text = "Delate";
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(111, 42);
            this.cmbUsers.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(224, 23);
            this.cmbUsers.TabIndex = 15;
            // 
            // btnDelateuser
            // 
            this.btnDelateuser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelateuser.Location = new System.Drawing.Point(164, 87);
            this.btnDelateuser.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDelateuser.Name = "btnDelateuser";
            this.btnDelateuser.Size = new System.Drawing.Size(134, 33);
            this.btnDelateuser.TabIndex = 14;
            this.btnDelateuser.Text = "Delate";
            this.btnDelateuser.UseVisualStyleBackColor = true;
            this.btnDelateuser.Click += new System.EventHandler(this.btnDelateuser_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "User:";
            // 
            // gbxCreate
            // 
            this.gbxCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxCreate.BackColor = System.Drawing.Color.Transparent;
            this.gbxCreate.Controls.Add(this.rdioAdNo);
            this.gbxCreate.Controls.Add(this.rdioAdSi);
            this.gbxCreate.Controls.Add(this.label11);
            this.gbxCreate.Controls.Add(this.txtUsername);
            this.gbxCreate.Controls.Add(this.label2);
            this.gbxCreate.Controls.Add(this.btnAddUser);
            this.gbxCreate.Controls.Add(this.txtnewUser);
            this.gbxCreate.Controls.Add(this.label1);
            this.gbxCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbxCreate.Location = new System.Drawing.Point(17, 33);
            this.gbxCreate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxCreate.Name = "gbxCreate";
            this.gbxCreate.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbxCreate.Size = new System.Drawing.Size(413, 165);
            this.gbxCreate.TabIndex = 7;
            this.gbxCreate.TabStop = false;
            this.gbxCreate.Text = "Create";
            // 
            // rdioAdNo
            // 
            this.rdioAdNo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdioAdNo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdioAdNo.Location = new System.Drawing.Point(211, 87);
            this.rdioAdNo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rdioAdNo.Name = "rdioAdNo";
            this.rdioAdNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdioAdNo.Size = new System.Drawing.Size(65, 23);
            this.rdioAdNo.TabIndex = 20;
            this.rdioAdNo.Text = "No";
            this.rdioAdNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdioAdNo.UseVisualStyleBackColor = true;
            // 
            // rdioAdSi
            // 
            this.rdioAdSi.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdioAdSi.Checked = true;
            this.rdioAdSi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdioAdSi.Location = new System.Drawing.Point(143, 87);
            this.rdioAdSi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rdioAdSi.Name = "rdioAdSi";
            this.rdioAdSi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdioAdSi.Size = new System.Drawing.Size(65, 23);
            this.rdioAdSi.TabIndex = 19;
            this.rdioAdSi.TabStop = true;
            this.rdioAdSi.Text = "Si";
            this.rdioAdSi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdioAdSi.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(9, 87);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 30);
            this.label11.TabIndex = 18;
            this.label11.Text = "Administrator:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(128, 54);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 23);
            this.txtUsername.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "User name:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUser.Location = new System.Drawing.Point(245, 121);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(149, 31);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // txtnewUser
            // 
            this.txtnewUser.Location = new System.Drawing.Point(128, 18);
            this.txtnewUser.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtnewUser.Name = "txtnewUser";
            this.txtnewUser.Size = new System.Drawing.Size(250, 23);
            this.txtnewUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Business";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.cmbBusiness);
            this.groupBox3.Controls.Add(this.delatebusi);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(448, 36);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Size = new System.Drawing.Size(360, 140);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delate";
            // 
            // cmbBusiness
            // 
            this.cmbBusiness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusiness.FormattingEnabled = true;
            this.cmbBusiness.Location = new System.Drawing.Point(111, 42);
            this.cmbBusiness.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbBusiness.Name = "cmbBusiness";
            this.cmbBusiness.Size = new System.Drawing.Size(224, 23);
            this.cmbBusiness.TabIndex = 15;
            // 
            // delatebusi
            // 
            this.delatebusi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delatebusi.Location = new System.Drawing.Point(164, 87);
            this.delatebusi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.delatebusi.Name = "delatebusi";
            this.delatebusi.Size = new System.Drawing.Size(134, 33);
            this.delatebusi.TabIndex = 14;
            this.delatebusi.Text = "Delate";
            this.delatebusi.UseVisualStyleBackColor = true;
            this.delatebusi.Click += new System.EventHandler(this.delatebusi_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Business:";
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txtDescription);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnAddBusi);
            this.groupBox4.Controls.Add(this.txtNameB);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(17, 36);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Size = new System.Drawing.Size(413, 153);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Create";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(128, 54);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 23);
            this.txtDescription.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Description:";
            // 
            // btnAddBusi
            // 
            this.btnAddBusi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddBusi.Location = new System.Drawing.Point(177, 108);
            this.btnAddBusi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddBusi.Name = "btnAddBusi";
            this.btnAddBusi.Size = new System.Drawing.Size(149, 31);
            this.btnAddBusi.TabIndex = 7;
            this.btnAddBusi.Text = "Add";
            this.btnAddBusi.UseVisualStyleBackColor = true;
            this.btnAddBusi.Click += new System.EventHandler(this.btnAddBusi_Click);
            // 
            // txtNameB
            // 
            this.txtNameB.Location = new System.Drawing.Point(128, 18);
            this.txtNameB.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtNameB.Name = "txtNameB";
            this.txtNameB.Size = new System.Drawing.Size(250, 23);
            this.txtNameB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(826, 431);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Products";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.cmbProductsex);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbBussinesP);
            this.groupBox2.Controls.Add(this.btnDelateProduct);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(448, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Size = new System.Drawing.Size(360, 153);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delate";
            // 
            // cmbProductsex
            // 
            this.cmbProductsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductsex.FormattingEnabled = true;
            this.cmbProductsex.Location = new System.Drawing.Point(111, 68);
            this.cmbProductsex.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbProductsex.Name = "cmbProductsex";
            this.cmbProductsex.Size = new System.Drawing.Size(224, 23);
            this.cmbProductsex.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Product:";
            // 
            // cmbBussinesP
            // 
            this.cmbBussinesP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBussinesP.FormattingEnabled = true;
            this.cmbBussinesP.Location = new System.Drawing.Point(111, 21);
            this.cmbBussinesP.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbBussinesP.Name = "cmbBussinesP";
            this.cmbBussinesP.Size = new System.Drawing.Size(224, 23);
            this.cmbBussinesP.TabIndex = 15;
            this.cmbBussinesP.SelectedIndexChanged += new System.EventHandler(this.cmbBussinesP_SelectedIndexChanged);
            // 
            // btnDelateProduct
            // 
            this.btnDelateProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelateProduct.Location = new System.Drawing.Point(157, 108);
            this.btnDelateProduct.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDelateProduct.Name = "btnDelateProduct";
            this.btnDelateProduct.Size = new System.Drawing.Size(134, 33);
            this.btnDelateProduct.TabIndex = 14;
            this.btnDelateProduct.Text = "Delate";
            this.btnDelateProduct.UseVisualStyleBackColor = true;
            this.btnDelateProduct.Click += new System.EventHandler(this.btnDelateProduct_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Business:";
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.cmbCreatP);
            this.groupBox5.Controls.Add(this.txtProduct);
            this.groupBox5.Controls.Add(this.label);
            this.groupBox5.Controls.Add(this.btnAddProduct);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(16, 37);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Size = new System.Drawing.Size(413, 153);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Create";
            // 
            // cmbCreatP
            // 
            this.cmbCreatP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreatP.FormattingEnabled = true;
            this.cmbCreatP.Location = new System.Drawing.Point(128, 21);
            this.cmbCreatP.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbCreatP.Name = "cmbCreatP";
            this.cmbCreatP.Size = new System.Drawing.Size(250, 23);
            this.cmbCreatP.TabIndex = 16;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(128, 72);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(250, 23);
            this.txtProduct.TabIndex = 17;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(9, 75);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 24);
            this.label.TabIndex = 16;
            this.label.Text = "Product:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddProduct.Location = new System.Drawing.Point(177, 108);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(149, 31);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(9, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bussines name:";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(826, 431);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Graphics";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.dtvOrders);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(826, 431);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Orders";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.Location = new System.Drawing.Point(261, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(282, 33);
            this.label10.TabIndex = 1;
            this.label10.Text = "All Orders:";
            // 
            // dtvOrders
            // 
            this.dtvOrders.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvOrders.Location = new System.Drawing.Point(101, 84);
            this.dtvOrders.Name = "dtvOrders";
            this.dtvOrders.Size = new System.Drawing.Size(570, 277);
            this.dtvOrders.TabIndex = 0;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tabControl1);
            this.Name = "Administrator";
            this.Size = new System.Drawing.Size(834, 457);
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dtvusers)).EndInit();
            this.groupDelate.ResumeLayout(false);
            this.gbxCreate.ResumeLayout(false);
            this.gbxCreate.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dtvOrders)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxCreate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupDelate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtnewUser;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.DataGridView dtvusers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameB;
        private System.Windows.Forms.Button btnAddBusi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button delatebusi;
        private System.Windows.Forms.Button btnDelateuser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox cmbBusiness;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnDelateProduct;
        private System.Windows.Forms.ComboBox cmbBussinesP;
        private System.Windows.Forms.ComboBox cmbCreatP;
        private System.Windows.Forms.ComboBox cmbProductsex;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtvOrders;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdioAdSi;
        private System.Windows.Forms.RadioButton rdioAdNo;
    }
}