namespace Heladeria
{
    partial class frmHeladeria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnLimpiar_Helado = new Button();
            btnBorrar_Helado = new Button();
            btnModificar_Helado = new Button();
            btnAgregar_Helado = new Button();
            dgvDatos_Helados = new DataGridView();
            groupBox2 = new GroupBox();
            txtPrecio_Helado = new TextBox();
            txtCantidad_Helado = new TextBox();
            lblPrecio_Helado = new Label();
            lblCantidad_Helado = new Label();
            groupBox1 = new GroupBox();
            txtNombre_Helado = new TextBox();
            txtId_Helado = new TextBox();
            lblNombre_Helado = new Label();
            lblId_Helado = new Label();
            tabPage2 = new TabPage();
            btnLimpiar_Topping = new Button();
            btnBorrar_Topping = new Button();
            btnModificar_Topping = new Button();
            btnAgregar_Topping = new Button();
            dgvDatos_Topping = new DataGridView();
            groupBox3 = new GroupBox();
            txtPrecio_Topping = new TextBox();
            txtCantidad_Topping = new TextBox();
            lblPrecio_Topping = new Label();
            lblCantidad_Topping = new Label();
            groupBox4 = new GroupBox();
            txtNombre_Topping = new TextBox();
            txtId_Topping = new TextBox();
            lblNombre_Topping = new Label();
            lblId_Topping = new Label();
            tabPage3 = new TabPage();
            txtId_Ventas = new TextBox();
            lblId_Ventas = new Label();
            btnLimpiar_Ventas = new Button();
            btnBorrar_Ventas = new Button();
            btnModificar_Ventas = new Button();
            btnAgregar_Ventas = new Button();
            dgvDatos_Ventas = new DataGridView();
            groupBox5 = new GroupBox();
            lblTotal_Topping = new Label();
            label4 = new Label();
            nudTopping = new NumericUpDown();
            cmdTopping = new ComboBox();
            groupBox6 = new GroupBox();
            lblTotal_Helado = new Label();
            label2 = new Label();
            nudHelado = new NumericUpDown();
            cmbHelados = new ComboBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos_Helados).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos_Topping).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos_Ventas).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTopping).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHelado).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(39, 116);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(842, 474);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = Properties.Resources.WhatsApp_Image_2023_06_19_at_4_34_19_PM;
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(btnLimpiar_Helado);
            tabPage1.Controls.Add(btnBorrar_Helado);
            tabPage1.Controls.Add(btnModificar_Helado);
            tabPage1.Controls.Add(btnAgregar_Helado);
            tabPage1.Controls.Add(dgvDatos_Helados);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(834, 438);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Helado";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnLimpiar_Helado
            // 
            btnLimpiar_Helado.Location = new Point(603, 203);
            btnLimpiar_Helado.Name = "btnLimpiar_Helado";
            btnLimpiar_Helado.Size = new Size(122, 56);
            btnLimpiar_Helado.TabIndex = 9;
            btnLimpiar_Helado.Text = "Limpiar";
            btnLimpiar_Helado.UseVisualStyleBackColor = true;
            btnLimpiar_Helado.Click += btnLimpiar_Helado_Click;
            // 
            // btnBorrar_Helado
            // 
            btnBorrar_Helado.Location = new Point(429, 203);
            btnBorrar_Helado.Name = "btnBorrar_Helado";
            btnBorrar_Helado.Size = new Size(122, 56);
            btnBorrar_Helado.TabIndex = 8;
            btnBorrar_Helado.Text = "Borrar";
            btnBorrar_Helado.UseVisualStyleBackColor = true;
            btnBorrar_Helado.Click += btnBorrar_Helado_Click;
            // 
            // btnModificar_Helado
            // 
            btnModificar_Helado.Location = new Point(268, 203);
            btnModificar_Helado.Name = "btnModificar_Helado";
            btnModificar_Helado.Size = new Size(122, 56);
            btnModificar_Helado.TabIndex = 7;
            btnModificar_Helado.Text = "Modificar";
            btnModificar_Helado.UseVisualStyleBackColor = true;
            btnModificar_Helado.Click += btnModificar_Helado_Click;
            // 
            // btnAgregar_Helado
            // 
            btnAgregar_Helado.Location = new Point(115, 203);
            btnAgregar_Helado.Name = "btnAgregar_Helado";
            btnAgregar_Helado.Size = new Size(122, 56);
            btnAgregar_Helado.TabIndex = 6;
            btnAgregar_Helado.Text = "Agregar";
            btnAgregar_Helado.UseVisualStyleBackColor = true;
            btnAgregar_Helado.Click += button1_Click;
            // 
            // dgvDatos_Helados
            // 
            dgvDatos_Helados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos_Helados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos_Helados.Dock = DockStyle.Bottom;
            dgvDatos_Helados.Location = new Point(3, 285);
            dgvDatos_Helados.Name = "dgvDatos_Helados";
            dgvDatos_Helados.RowTemplate.Height = 25;
            dgvDatos_Helados.Size = new Size(828, 150);
            dgvDatos_Helados.TabIndex = 5;
            dgvDatos_Helados.CellClick += dgvDatos_Helados_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 128);
            groupBox2.Controls.Add(txtPrecio_Helado);
            groupBox2.Controls.Add(txtCantidad_Helado);
            groupBox2.Controls.Add(lblPrecio_Helado);
            groupBox2.Controls.Add(lblCantidad_Helado);
            groupBox2.Location = new Point(473, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 133);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // txtPrecio_Helado
            // 
            txtPrecio_Helado.Location = new Point(196, 72);
            txtPrecio_Helado.Name = "txtPrecio_Helado";
            txtPrecio_Helado.Size = new Size(100, 31);
            txtPrecio_Helado.TabIndex = 3;
            // 
            // txtCantidad_Helado
            // 
            txtCantidad_Helado.Location = new Point(196, 34);
            txtCantidad_Helado.Name = "txtCantidad_Helado";
            txtCantidad_Helado.Size = new Size(100, 31);
            txtCantidad_Helado.TabIndex = 2;
            // 
            // lblPrecio_Helado
            // 
            lblPrecio_Helado.AutoSize = true;
            lblPrecio_Helado.Location = new Point(16, 78);
            lblPrecio_Helado.Name = "lblPrecio_Helado";
            lblPrecio_Helado.Size = new Size(159, 23);
            lblPrecio_Helado.TabIndex = 1;
            lblPrecio_Helado.Text = "Precio Helado";
            // 
            // lblCantidad_Helado
            // 
            lblCantidad_Helado.AutoSize = true;
            lblCantidad_Helado.Location = new Point(6, 37);
            lblCantidad_Helado.Name = "lblCantidad_Helado";
            lblCantidad_Helado.Size = new Size(185, 23);
            lblCantidad_Helado.TabIndex = 0;
            lblCantidad_Helado.Text = "Cantidad Helado";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 128);
            groupBox1.Controls.Add(txtNombre_Helado);
            groupBox1.Controls.Add(txtId_Helado);
            groupBox1.Controls.Add(lblNombre_Helado);
            groupBox1.Controls.Add(lblId_Helado);
            groupBox1.Location = new Point(54, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtNombre_Helado
            // 
            txtNombre_Helado.Location = new Point(198, 72);
            txtNombre_Helado.Name = "txtNombre_Helado";
            txtNombre_Helado.Size = new Size(100, 31);
            txtNombre_Helado.TabIndex = 3;
            // 
            // txtId_Helado
            // 
            txtId_Helado.Location = new Point(198, 34);
            txtId_Helado.Name = "txtId_Helado";
            txtId_Helado.Size = new Size(100, 31);
            txtId_Helado.TabIndex = 2;
            // 
            // lblNombre_Helado
            // 
            lblNombre_Helado.AutoSize = true;
            lblNombre_Helado.Location = new Point(16, 78);
            lblNombre_Helado.Name = "lblNombre_Helado";
            lblNombre_Helado.Size = new Size(168, 23);
            lblNombre_Helado.TabIndex = 1;
            lblNombre_Helado.Text = "Nombre Helado";
            // 
            // lblId_Helado
            // 
            lblId_Helado.AutoSize = true;
            lblId_Helado.Location = new Point(16, 37);
            lblId_Helado.Name = "lblId_Helado";
            lblId_Helado.Size = new Size(111, 23);
            lblId_Helado.TabIndex = 0;
            lblId_Helado.Text = "Id Helado";
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.WhatsApp_Image_2023_06_19_at_4_35_26_PM;
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(btnLimpiar_Topping);
            tabPage2.Controls.Add(btnBorrar_Topping);
            tabPage2.Controls.Add(btnModificar_Topping);
            tabPage2.Controls.Add(btnAgregar_Topping);
            tabPage2.Controls.Add(dgvDatos_Topping);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(834, 438);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Topping";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar_Topping
            // 
            btnLimpiar_Topping.Location = new Point(603, 192);
            btnLimpiar_Topping.Name = "btnLimpiar_Topping";
            btnLimpiar_Topping.Size = new Size(122, 56);
            btnLimpiar_Topping.TabIndex = 16;
            btnLimpiar_Topping.Text = "Limpiar";
            btnLimpiar_Topping.UseVisualStyleBackColor = true;
            btnLimpiar_Topping.Click += btnLimpiar_Topping_Click;
            // 
            // btnBorrar_Topping
            // 
            btnBorrar_Topping.Location = new Point(429, 192);
            btnBorrar_Topping.Name = "btnBorrar_Topping";
            btnBorrar_Topping.Size = new Size(122, 56);
            btnBorrar_Topping.TabIndex = 15;
            btnBorrar_Topping.Text = "Borrar";
            btnBorrar_Topping.UseVisualStyleBackColor = true;
            btnBorrar_Topping.Click += btnBorrar_Topping_Click;
            // 
            // btnModificar_Topping
            // 
            btnModificar_Topping.Location = new Point(268, 192);
            btnModificar_Topping.Name = "btnModificar_Topping";
            btnModificar_Topping.Size = new Size(122, 56);
            btnModificar_Topping.TabIndex = 14;
            btnModificar_Topping.Text = "Modificar";
            btnModificar_Topping.UseVisualStyleBackColor = true;
            btnModificar_Topping.Click += btnModificar_Topping_Click;
            // 
            // btnAgregar_Topping
            // 
            btnAgregar_Topping.Location = new Point(115, 192);
            btnAgregar_Topping.Name = "btnAgregar_Topping";
            btnAgregar_Topping.Size = new Size(122, 56);
            btnAgregar_Topping.TabIndex = 13;
            btnAgregar_Topping.Text = "Agregar";
            btnAgregar_Topping.UseVisualStyleBackColor = true;
            btnAgregar_Topping.Click += btnAgregar_Topping_Click;
            // 
            // dgvDatos_Topping
            // 
            dgvDatos_Topping.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos_Topping.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos_Topping.Dock = DockStyle.Bottom;
            dgvDatos_Topping.Location = new Point(3, 285);
            dgvDatos_Topping.Name = "dgvDatos_Topping";
            dgvDatos_Topping.RowTemplate.Height = 25;
            dgvDatos_Topping.Size = new Size(828, 150);
            dgvDatos_Topping.TabIndex = 12;
            dgvDatos_Topping.CellClick += dgvDatos_Topping_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 192, 128);
            groupBox3.Controls.Add(txtPrecio_Topping);
            groupBox3.Controls.Add(txtCantidad_Topping);
            groupBox3.Controls.Add(lblPrecio_Topping);
            groupBox3.Controls.Add(lblCantidad_Topping);
            groupBox3.Location = new Point(473, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(323, 133);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            // 
            // txtPrecio_Topping
            // 
            txtPrecio_Topping.Location = new Point(196, 72);
            txtPrecio_Topping.Name = "txtPrecio_Topping";
            txtPrecio_Topping.Size = new Size(100, 31);
            txtPrecio_Topping.TabIndex = 3;
            // 
            // txtCantidad_Topping
            // 
            txtCantidad_Topping.Location = new Point(196, 34);
            txtCantidad_Topping.Name = "txtCantidad_Topping";
            txtCantidad_Topping.Size = new Size(100, 31);
            txtCantidad_Topping.TabIndex = 2;
            // 
            // lblPrecio_Topping
            // 
            lblPrecio_Topping.AutoSize = true;
            lblPrecio_Topping.Location = new Point(16, 78);
            lblPrecio_Topping.Name = "lblPrecio_Topping";
            lblPrecio_Topping.Size = new Size(168, 23);
            lblPrecio_Topping.TabIndex = 1;
            lblPrecio_Topping.Text = "Precio Topping";
            // 
            // lblCantidad_Topping
            // 
            lblCantidad_Topping.AutoSize = true;
            lblCantidad_Topping.Location = new Point(6, 37);
            lblCantidad_Topping.Name = "lblCantidad_Topping";
            lblCantidad_Topping.Size = new Size(194, 23);
            lblCantidad_Topping.TabIndex = 0;
            lblCantidad_Topping.Text = "Cantidad Topping";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(255, 192, 128);
            groupBox4.Controls.Add(txtNombre_Topping);
            groupBox4.Controls.Add(txtId_Topping);
            groupBox4.Controls.Add(lblNombre_Topping);
            groupBox4.Controls.Add(lblId_Topping);
            groupBox4.Location = new Point(54, 14);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(318, 133);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            // 
            // txtNombre_Topping
            // 
            txtNombre_Topping.Location = new Point(198, 72);
            txtNombre_Topping.Name = "txtNombre_Topping";
            txtNombre_Topping.Size = new Size(100, 31);
            txtNombre_Topping.TabIndex = 3;
            // 
            // txtId_Topping
            // 
            txtId_Topping.Location = new Point(198, 34);
            txtId_Topping.Name = "txtId_Topping";
            txtId_Topping.Size = new Size(100, 31);
            txtId_Topping.TabIndex = 2;
            // 
            // lblNombre_Topping
            // 
            lblNombre_Topping.AutoSize = true;
            lblNombre_Topping.Location = new Point(16, 78);
            lblNombre_Topping.Name = "lblNombre_Topping";
            lblNombre_Topping.Size = new Size(177, 23);
            lblNombre_Topping.TabIndex = 1;
            lblNombre_Topping.Text = "Nombre Topping";
            // 
            // lblId_Topping
            // 
            lblId_Topping.AutoSize = true;
            lblId_Topping.Location = new Point(16, 37);
            lblId_Topping.Name = "lblId_Topping";
            lblId_Topping.Size = new Size(120, 23);
            lblId_Topping.TabIndex = 0;
            lblId_Topping.Text = "Id Topping";
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources.WhatsApp_Image_2023_06_19_at_3_07_08_PM;
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(txtId_Ventas);
            tabPage3.Controls.Add(lblId_Ventas);
            tabPage3.Controls.Add(btnLimpiar_Ventas);
            tabPage3.Controls.Add(btnBorrar_Ventas);
            tabPage3.Controls.Add(btnModificar_Ventas);
            tabPage3.Controls.Add(btnAgregar_Ventas);
            tabPage3.Controls.Add(dgvDatos_Ventas);
            tabPage3.Controls.Add(groupBox5);
            tabPage3.Controls.Add(groupBox6);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(834, 438);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ventas";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // txtId_Ventas
            // 
            txtId_Ventas.Location = new Point(131, 196);
            txtId_Ventas.Name = "txtId_Ventas";
            txtId_Ventas.Size = new Size(100, 31);
            txtId_Ventas.TabIndex = 20;
            // 
            // lblId_Ventas
            // 
            lblId_Ventas.AutoSize = true;
            lblId_Ventas.Location = new Point(8, 199);
            lblId_Ventas.Name = "lblId_Ventas";
            lblId_Ventas.Size = new Size(105, 23);
            lblId_Ventas.TabIndex = 19;
            lblId_Ventas.Text = "Id Ventas";
            // 
            // btnLimpiar_Ventas
            // 
            btnLimpiar_Ventas.Location = new Point(344, 232);
            btnLimpiar_Ventas.Name = "btnLimpiar_Ventas";
            btnLimpiar_Ventas.Size = new Size(131, 47);
            btnLimpiar_Ventas.TabIndex = 18;
            btnLimpiar_Ventas.Text = "Limpiar";
            btnLimpiar_Ventas.UseVisualStyleBackColor = true;
            btnLimpiar_Ventas.Click += btnLimpiar_Ventas_Click;
            // 
            // btnBorrar_Ventas
            // 
            btnBorrar_Ventas.Location = new Point(344, 150);
            btnBorrar_Ventas.Name = "btnBorrar_Ventas";
            btnBorrar_Ventas.Size = new Size(131, 47);
            btnBorrar_Ventas.TabIndex = 17;
            btnBorrar_Ventas.Text = "Borrar";
            btnBorrar_Ventas.UseVisualStyleBackColor = true;
            btnBorrar_Ventas.Click += btnBorrar_Ventas_Click;
            // 
            // btnModificar_Ventas
            // 
            btnModificar_Ventas.Location = new Point(344, 75);
            btnModificar_Ventas.Name = "btnModificar_Ventas";
            btnModificar_Ventas.Size = new Size(131, 47);
            btnModificar_Ventas.TabIndex = 16;
            btnModificar_Ventas.Text = "Modificar";
            btnModificar_Ventas.UseVisualStyleBackColor = true;
            btnModificar_Ventas.Click += btnModificar_Ventas_Click;
            // 
            // btnAgregar_Ventas
            // 
            btnAgregar_Ventas.Location = new Point(344, 0);
            btnAgregar_Ventas.Name = "btnAgregar_Ventas";
            btnAgregar_Ventas.Size = new Size(131, 47);
            btnAgregar_Ventas.TabIndex = 15;
            btnAgregar_Ventas.Text = "Agregar";
            btnAgregar_Ventas.UseVisualStyleBackColor = true;
            btnAgregar_Ventas.Click += btnAgregar_Ventas_Click;
            // 
            // dgvDatos_Ventas
            // 
            dgvDatos_Ventas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos_Ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos_Ventas.Dock = DockStyle.Bottom;
            dgvDatos_Ventas.Location = new Point(3, 285);
            dgvDatos_Ventas.Name = "dgvDatos_Ventas";
            dgvDatos_Ventas.RowTemplate.Height = 25;
            dgvDatos_Ventas.Size = new Size(828, 150);
            dgvDatos_Ventas.TabIndex = 14;
            dgvDatos_Ventas.CellClick += dgvDatos_Ventas_CellClick;
            dgvDatos_Ventas.Click += dgvDatos_Ventas_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(255, 192, 128);
            groupBox5.Controls.Add(lblTotal_Topping);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(nudTopping);
            groupBox5.Controls.Add(cmdTopping);
            groupBox5.Location = new Point(511, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(323, 162);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "Toppings";
            // 
            // lblTotal_Topping
            // 
            lblTotal_Topping.AutoSize = true;
            lblTotal_Topping.Location = new Point(136, 110);
            lblTotal_Topping.Name = "lblTotal_Topping";
            lblTotal_Topping.Size = new Size(66, 23);
            lblTotal_Topping.TabIndex = 5;
            lblTotal_Topping.Text = "XXXX";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 75);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 4;
            label4.Text = "Total";
            // 
            // nudTopping
            // 
            nudTopping.Location = new Point(188, 39);
            nudTopping.Name = "nudTopping";
            nudTopping.Size = new Size(123, 31);
            nudTopping.TabIndex = 3;
            // 
            // cmdTopping
            // 
            cmdTopping.FormattingEnabled = true;
            cmdTopping.Location = new Point(32, 38);
            cmdTopping.Name = "cmdTopping";
            cmdTopping.Size = new Size(121, 31);
            cmdTopping.TabIndex = 2;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.FromArgb(255, 192, 128);
            groupBox6.Controls.Add(lblTotal_Helado);
            groupBox6.Controls.Add(label2);
            groupBox6.Controls.Add(nudHelado);
            groupBox6.Controls.Add(cmbHelados);
            groupBox6.Location = new Point(0, 0);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(318, 162);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            groupBox6.Text = "Helados";
            // 
            // lblTotal_Helado
            // 
            lblTotal_Helado.AutoSize = true;
            lblTotal_Helado.Location = new Point(122, 110);
            lblTotal_Helado.Name = "lblTotal_Helado";
            lblTotal_Helado.Size = new Size(66, 23);
            lblTotal_Helado.TabIndex = 3;
            lblTotal_Helado.Text = "XXXX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 75);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 2;
            label2.Text = "Total";
            // 
            // nudHelado
            // 
            nudHelado.Location = new Point(164, 38);
            nudHelado.Name = "nudHelado";
            nudHelado.Size = new Size(123, 31);
            nudHelado.TabIndex = 1;
            // 
            // cmbHelados
            // 
            cmbHelados.FormattingEnabled = true;
            cmbHelados.Location = new Point(8, 37);
            cmbHelados.Name = "cmbHelados";
            cmbHelados.Size = new Size(121, 31);
            cmbHelados.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 20);
            label1.Name = "label1";
            label1.Size = new Size(724, 79);
            label1.TabIndex = 1;
            label1.Text = "HELADERIA BAJO CERO";
            // 
            // frmHeladeria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(945, 602);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "frmHeladeria";
            Text = "Form1";
            Load += frmHeladeria_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos_Helados).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos_Topping).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos_Ventas).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTopping).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHelado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private DataGridView dgvDatos_Helados;
        private GroupBox groupBox2;
        private TextBox txtPrecio_Helado;
        private TextBox txtCantidad_Helado;
        private Label lblPrecio_Helado;
        private Label lblCantidad_Helado;
        private GroupBox groupBox1;
        private TextBox txtNombre_Helado;
        private TextBox txtId_Helado;
        private Label lblNombre_Helado;
        private Label lblId_Helado;
        private TabPage tabPage3;
        private Button btnLimpiar_Helado;
        private Button btnBorrar_Helado;
        private Button btnModificar_Helado;
        private Button btnAgregar_Helado;
        private Button btnLimpiar_Topping;
        private Button btnBorrar_Topping;
        private Button btnModificar_Topping;
        private Button btnAgregar_Topping;
        private DataGridView dgvDatos_Topping;
        private GroupBox groupBox3;
        private TextBox txtPrecio_Topping;
        private TextBox txtCantidad_Topping;
        private Label lblPrecio_Topping;
        private Label lblCantidad_Topping;
        private GroupBox groupBox4;
        private TextBox txtNombre_Topping;
        private TextBox txtId_Topping;
        private Label lblNombre_Topping;
        private Label lblId_Topping;
        private TextBox txtId_Ventas;
        private Label lblId_Ventas;
        private Button btnLimpiar_Ventas;
        private Button btnBorrar_Ventas;
        private Button btnModificar_Ventas;
        private Button btnAgregar_Ventas;
        private DataGridView dgvDatos_Ventas;
        private GroupBox groupBox5;
        private NumericUpDown nudTopping;
        private ComboBox cmdTopping;
        private GroupBox groupBox6;
        private NumericUpDown nudHelado;
        private ComboBox cmbHelados;
        private Label lblTotal_Topping;
        private Label label4;
        private Label lblTotal_Helado;
        private Label label2;
    }
}