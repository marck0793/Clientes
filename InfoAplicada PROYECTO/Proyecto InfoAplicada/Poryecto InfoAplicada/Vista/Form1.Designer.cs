using System.Data;
using System.Data.SqlClient;
namespace Poryecto_InfoAplicada
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.clientes = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbCategoriasOffer = new System.Windows.Forms.ComboBox();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorks2000DataSet = new Poryecto_InfoAplicada.AdventureWorks2000DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.productSubCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dt = new System.Data.DataTable();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpClientes = new System.Windows.Forms.TabPage();
            this.pDinamico = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedores = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ventas = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.cuentasPorPagar = new System.Windows.Forms.TabPage();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.cuentasPorCobrar = new System.Windows.Forms.TabPage();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.contabilidad = new System.Windows.Forms.TabPage();
            this.tabControl7 = new System.Windows.Forms.TabControl();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.inventarios = new System.Windows.Forms.TabPage();
            this.tabControl8 = new System.Windows.Forms.TabControl();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.seguridad = new System.Windows.Forms.TabPage();
            this.customerTableAdapter = new Poryecto_InfoAplicada.AdventureWorks2000DataSetTableAdapters.CustomerTableAdapter();
            this.adventureWorks2000DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productCategoryTableAdapter = new Poryecto_InfoAplicada.AdventureWorks2000DataSetTableAdapters.ProductCategoryTableAdapter();
            this.adventureWorks2000DataSet1 = new Poryecto_InfoAplicada.AdventureWorks2000DataSet1();
            this.productSubCategoryTableAdapter = new Poryecto_InfoAplicada.AdventureWorks2000DataSet1TableAdapters.ProductSubCategoryTableAdapter();
            this.dad = new System.Data.SqlClient.SqlDataAdapter();
            this.pDinamicoOffer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.clientes.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2000DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSubCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.tpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.proveedores.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.ventas.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.cuentasPorPagar.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.cuentasPorCobrar.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.contabilidad.SuspendLayout();
            this.tabControl7.SuspendLayout();
            this.inventarios.SuspendLayout();
            this.tabControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2000DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2000DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.administraciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Abrir";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Guardar";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clientes);
            this.tabControl1.Controls.Add(this.proveedores);
            this.tabControl1.Controls.Add(this.ventas);
            this.tabControl1.Controls.Add(this.cuentasPorPagar);
            this.tabControl1.Controls.Add(this.cuentasPorCobrar);
            this.tabControl1.Controls.Add(this.contabilidad);
            this.tabControl1.Controls.Add(this.inventarios);
            this.tabControl1.Controls.Add(this.seguridad);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(9, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1094, 577);
            this.tabControl1.TabIndex = 1;
            // 
            // clientes
            // 
            this.clientes.Controls.Add(this.tabControl3);
            this.clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientes.Location = new System.Drawing.Point(4, 28);
            this.clientes.Margin = new System.Windows.Forms.Padding(2);
            this.clientes.Name = "clientes";
            this.clientes.Padding = new System.Windows.Forms.Padding(2);
            this.clientes.Size = new System.Drawing.Size(1086, 545);
            this.clientes.TabIndex = 0;
            this.clientes.Text = "Clientes";
            this.clientes.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Controls.Add(this.tpClientes);
            this.tabControl3.Location = new System.Drawing.Point(2, 2);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1083, 540);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pDinamicoOffer);
            this.tabPage3.Controls.Add(this.cbCategoriasOffer);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.checkBox2);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1075, 511);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Promociones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbCategoriasOffer
            // 
            this.cbCategoriasOffer.DataSource = this.productCategoryBindingSource;
            this.cbCategoriasOffer.DisplayMember = "Name";
            this.cbCategoriasOffer.FormattingEnabled = true;
            this.cbCategoriasOffer.Location = new System.Drawing.Point(18, 97);
            this.cbCategoriasOffer.Name = "cbCategoriasOffer";
            this.cbCategoriasOffer.Size = new System.Drawing.Size(121, 24);
            this.cbCategoriasOffer.TabIndex = 17;
            this.cbCategoriasOffer.ValueMember = "ProductCategoryID";
            this.cbCategoriasOffer.SelectedIndexChanged += new System.EventHandler(this.cbCategoriasOffer_SelectedIndexChanged);
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataMember = "ProductCategory";
            this.productCategoryBindingSource.DataSource = this.adventureWorks2000DataSet;
            // 
            // adventureWorks2000DataSet
            // 
            this.adventureWorks2000DataSet.DataSetName = "AdventureWorks2000DataSet";
            this.adventureWorks2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(459, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 468);
            this.dataGridView1.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cedula";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cedula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.adventureWorks2000DataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(202, 208);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Promociones disponibles:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 152);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(168, 30);
            this.button7.TabIndex = 13;
            this.button7.Text = "Buscar promociones";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar clientes para promoción";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // productSubCategoryBindingSource
            // 
            this.productSubCategoryBindingSource.DataMember = "ProductSubCategory";
            this.productSubCategoryBindingSource.DataSource = this.dt;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione una Categoria/Sub Categoria:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(288, 27);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(124, 21);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Sub Categorias";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(187, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Categorias";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar promociones por:";
            // 
            // tpClientes
            // 
            this.tpClientes.Controls.Add(this.pDinamico);
            this.tpClientes.Controls.Add(this.label6);
            this.tpClientes.Controls.Add(this.cbFiltro);
            this.tpClientes.Controls.Add(this.dgvClientes);
            this.tpClientes.Location = new System.Drawing.Point(4, 25);
            this.tpClientes.Margin = new System.Windows.Forms.Padding(2);
            this.tpClientes.Name = "tpClientes";
            this.tpClientes.Padding = new System.Windows.Forms.Padding(2);
            this.tpClientes.Size = new System.Drawing.Size(1075, 511);
            this.tpClientes.TabIndex = 1;
            this.tpClientes.Text = "Clientes";
            this.tpClientes.UseVisualStyleBackColor = true;
            // 
            // pDinamico
            // 
            this.pDinamico.Location = new System.Drawing.Point(651, 124);
            this.pDinamico.Name = "pDinamico";
            this.pDinamico.Size = new System.Drawing.Size(254, 100);
            this.pDinamico.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Filtro";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Cedula",
            "Region",
            "Categorias",
            "VIP",
            "Todos"});
            this.cbFiltro.Location = new System.Drawing.Point(651, 52);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 24);
            this.cbFiltro.TabIndex = 1;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            this.cbFiltro.SelectedValueChanged += new System.EventHandler(this.cbFiltro_SelectedValueChanged);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.customerBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(24, 21);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(532, 468);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // proveedores
            // 
            this.proveedores.Controls.Add(this.tabControl2);
            this.proveedores.Location = new System.Drawing.Point(4, 28);
            this.proveedores.Margin = new System.Windows.Forms.Padding(2);
            this.proveedores.Name = "proveedores";
            this.proveedores.Padding = new System.Windows.Forms.Padding(2);
            this.proveedores.Size = new System.Drawing.Size(1086, 545);
            this.proveedores.TabIndex = 1;
            this.proveedores.Text = "Proveedores";
            this.proveedores.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(2, 2);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1081, 540);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1073, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1073, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ventas
            // 
            this.ventas.Controls.Add(this.tabControl4);
            this.ventas.Location = new System.Drawing.Point(4, 28);
            this.ventas.Margin = new System.Windows.Forms.Padding(2);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(1086, 545);
            this.ventas.TabIndex = 2;
            this.ventas.Text = "Ventas";
            this.ventas.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage5);
            this.tabControl4.Controls.Add(this.tabPage6);
            this.tabControl4.Location = new System.Drawing.Point(2, 2);
            this.tabControl4.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(1083, 542);
            this.tabControl4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(1075, 510);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(1075, 510);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // cuentasPorPagar
            // 
            this.cuentasPorPagar.Controls.Add(this.tabControl5);
            this.cuentasPorPagar.Location = new System.Drawing.Point(4, 28);
            this.cuentasPorPagar.Margin = new System.Windows.Forms.Padding(2);
            this.cuentasPorPagar.Name = "cuentasPorPagar";
            this.cuentasPorPagar.Size = new System.Drawing.Size(1086, 545);
            this.cuentasPorPagar.TabIndex = 3;
            this.cuentasPorPagar.Text = "Cuentas por pagar";
            this.cuentasPorPagar.UseVisualStyleBackColor = true;
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage7);
            this.tabControl5.Controls.Add(this.tabPage8);
            this.tabControl5.Location = new System.Drawing.Point(2, 2);
            this.tabControl5.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(1083, 542);
            this.tabControl5.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 28);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage7.Size = new System.Drawing.Size(1075, 510);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 28);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage8.Size = new System.Drawing.Size(1075, 510);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // cuentasPorCobrar
            // 
            this.cuentasPorCobrar.Controls.Add(this.tabControl6);
            this.cuentasPorCobrar.Location = new System.Drawing.Point(4, 28);
            this.cuentasPorCobrar.Margin = new System.Windows.Forms.Padding(2);
            this.cuentasPorCobrar.Name = "cuentasPorCobrar";
            this.cuentasPorCobrar.Size = new System.Drawing.Size(1086, 545);
            this.cuentasPorCobrar.TabIndex = 4;
            this.cuentasPorCobrar.Text = "Cuentas por cobrar";
            this.cuentasPorCobrar.UseVisualStyleBackColor = true;
            // 
            // tabControl6
            // 
            this.tabControl6.Controls.Add(this.tabPage9);
            this.tabControl6.Controls.Add(this.tabPage10);
            this.tabControl6.Location = new System.Drawing.Point(2, 2);
            this.tabControl6.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(1083, 542);
            this.tabControl6.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 28);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage9.Size = new System.Drawing.Size(1075, 510);
            this.tabPage9.TabIndex = 0;
            this.tabPage9.Text = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 28);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage10.Size = new System.Drawing.Size(1075, 510);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "tabPage10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // contabilidad
            // 
            this.contabilidad.Controls.Add(this.tabControl7);
            this.contabilidad.Location = new System.Drawing.Point(4, 28);
            this.contabilidad.Margin = new System.Windows.Forms.Padding(2);
            this.contabilidad.Name = "contabilidad";
            this.contabilidad.Size = new System.Drawing.Size(1086, 545);
            this.contabilidad.TabIndex = 5;
            this.contabilidad.Text = "Contabilidad";
            this.contabilidad.UseVisualStyleBackColor = true;
            // 
            // tabControl7
            // 
            this.tabControl7.Controls.Add(this.tabPage11);
            this.tabControl7.Controls.Add(this.tabPage12);
            this.tabControl7.Location = new System.Drawing.Point(2, 2);
            this.tabControl7.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl7.Name = "tabControl7";
            this.tabControl7.SelectedIndex = 0;
            this.tabControl7.Size = new System.Drawing.Size(1083, 542);
            this.tabControl7.TabIndex = 0;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 28);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage11.Size = new System.Drawing.Size(1075, 510);
            this.tabPage11.TabIndex = 0;
            this.tabPage11.Text = "tabPage11";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 28);
            this.tabPage12.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage12.Size = new System.Drawing.Size(1075, 510);
            this.tabPage12.TabIndex = 1;
            this.tabPage12.Text = "tabPage12";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // inventarios
            // 
            this.inventarios.Controls.Add(this.tabControl8);
            this.inventarios.Location = new System.Drawing.Point(4, 28);
            this.inventarios.Margin = new System.Windows.Forms.Padding(2);
            this.inventarios.Name = "inventarios";
            this.inventarios.Size = new System.Drawing.Size(1086, 545);
            this.inventarios.TabIndex = 6;
            this.inventarios.Text = "Inventarios";
            this.inventarios.UseVisualStyleBackColor = true;
            // 
            // tabControl8
            // 
            this.tabControl8.Controls.Add(this.tabPage13);
            this.tabControl8.Controls.Add(this.tabPage14);
            this.tabControl8.Location = new System.Drawing.Point(2, 2);
            this.tabControl8.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl8.Name = "tabControl8";
            this.tabControl8.SelectedIndex = 0;
            this.tabControl8.Size = new System.Drawing.Size(1085, 542);
            this.tabControl8.TabIndex = 0;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 28);
            this.tabPage13.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage13.Size = new System.Drawing.Size(1077, 510);
            this.tabPage13.TabIndex = 0;
            this.tabPage13.Text = "tabPage13";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tabPage14
            // 
            this.tabPage14.Location = new System.Drawing.Point(4, 28);
            this.tabPage14.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage14.Size = new System.Drawing.Size(1077, 510);
            this.tabPage14.TabIndex = 1;
            this.tabPage14.Text = "tabPage14";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // seguridad
            // 
            this.seguridad.Location = new System.Drawing.Point(4, 28);
            this.seguridad.Margin = new System.Windows.Forms.Padding(2);
            this.seguridad.Name = "seguridad";
            this.seguridad.Size = new System.Drawing.Size(1086, 545);
            this.seguridad.TabIndex = 7;
            this.seguridad.Text = "Seguridad";
            this.seguridad.UseVisualStyleBackColor = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // adventureWorks2000DataSetBindingSource
            // 
            this.adventureWorks2000DataSetBindingSource.DataSource = this.adventureWorks2000DataSet;
            this.adventureWorks2000DataSetBindingSource.Position = 0;
            // 
            // productCategoryTableAdapter
            // 
            this.productCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // adventureWorks2000DataSet1
            // 
            this.adventureWorks2000DataSet1.DataSetName = "AdventureWorks2000DataSet1";
            this.adventureWorks2000DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productSubCategoryTableAdapter
            // 
            this.productSubCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // pDinamicoOffer
            // 
            this.pDinamicoOffer.Location = new System.Drawing.Point(202, 97);
            this.pDinamicoOffer.Name = "pDinamicoOffer";
            this.pDinamicoOffer.Size = new System.Drawing.Size(200, 49);
            this.pDinamicoOffer.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.clientes.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2000DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSubCategoryBindingSource)).EndInit();
            
            this.tpClientes.ResumeLayout(false);
            this.tpClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.proveedores.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ventas.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.cuentasPorPagar.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.cuentasPorCobrar.ResumeLayout(false);
            this.tabControl6.ResumeLayout(false);
            this.contabilidad.ResumeLayout(false);
            this.tabControl7.ResumeLayout(false);
            this.inventarios.ResumeLayout(false);
            this.tabControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2000DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2000DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clientes;
        private System.Windows.Forms.TabPage proveedores;
        private System.Windows.Forms.TabPage ventas;
        private System.Windows.Forms.TabPage cuentasPorPagar;
        private System.Windows.Forms.TabPage cuentasPorCobrar;
        private System.Windows.Forms.TabPage contabilidad;
        private System.Windows.Forms.TabPage inventarios;
        private System.Windows.Forms.TabPage seguridad;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabControl tabControl6;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabControl tabControl7;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TabControl tabControl8;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tpClientes;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private AdventureWorks2000DataSet adventureWorks2000DataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private AdventureWorks2000DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource adventureWorks2000DataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pDinamico;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox cbCategoriasOffer;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private AdventureWorks2000DataSetTableAdapters.ProductCategoryTableAdapter productCategoryTableAdapter;
        private AdventureWorks2000DataSet1 adventureWorks2000DataSet1;
        private System.Windows.Forms.BindingSource productSubCategoryBindingSource;
        private AdventureWorks2000DataSet1TableAdapters.ProductSubCategoryTableAdapter productSubCategoryTableAdapter;
        private DataTable dt;
        private SqlDataAdapter dad;
        private System.Windows.Forms.Panel pDinamicoOffer;
    }
}

