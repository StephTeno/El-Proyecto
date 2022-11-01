namespace ElProyecto
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Inicio", 5, 5);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Quienes Somos", 4, 4);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Página Principal", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Registrar Donante", 0, 0);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Modificar Datos", 3, 3);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Consultar Donante", 2, 2);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Donantes", 7, 7);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Grupo Sanguineo", 1, 1);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Ver los Donantes", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalirOficial = new System.Windows.Forms.Button();
            this.tvLista = new System.Windows.Forms.TreeView();
            this.imglTreeView = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plVerGrupoSanguineo = new System.Windows.Forms.Panel();
            this.dgvGrupoSanguineo = new System.Windows.Forms.DataGridView();
            this.lblVerGrupoSanguineo = new System.Windows.Forms.Label();
            this.plVerDonantes = new System.Windows.Forms.Panel();
            this.dgvVerDonantes = new System.Windows.Forms.DataGridView();
            this.lblVerDonantes = new System.Windows.Forms.Label();
            this.plModificarDatos = new System.Windows.Forms.Panel();
            this.txtABuscar = new System.Windows.Forms.TextBox();
            this.btnCancelar2 = new System.Windows.Forms.Button();
            this.btnHecho = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mtxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.mtxtPeso = new System.Windows.Forms.MaskedTextBox();
            this.rbMas = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.Id_Mo = new System.Windows.Forms.Label();
            this.RH_Mo = new System.Windows.Forms.Label();
            this.cmb_RH = new System.Windows.Forms.ComboBox();
            this.lblGrupoSang = new System.Windows.Forms.Label();
            this.cmbGrupoSang = new System.Windows.Forms.ComboBox();
            this.lblCentroDonación = new System.Windows.Forms.Label();
            this.txtCentroDonacion = new System.Windows.Forms.TextBox();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.lblBusMod = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.plConsultarDonante = new System.Windows.Forms.Panel();
            this.btnBuscarConsultar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.gbConsultar = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblConsultarDonante = new System.Windows.Forms.Label();
            this.plRegistrarDonante = new System.Windows.Forms.Panel();
            this.btnCance = new System.Windows.Forms.Button();
            this.btnAcep = new System.Windows.Forms.Button();
            this.tcInformacion = new System.Windows.Forms.TabControl();
            this.tpPersonal = new System.Windows.Forms.TabPage();
            this.mtxtCed = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPe = new System.Windows.Forms.MaskedTextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPes = new System.Windows.Forms.Label();
            this.lblCed = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.tpPrincipal = new System.Windows.Forms.TabPage();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblRh = new System.Windows.Forms.Label();
            this.cmbRh = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.lblCentro = new System.Windows.Forms.Label();
            this.txtCentro = new System.Windows.Forms.TextBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.plInicio = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGrupoSanguineo = new System.Windows.Forms.Button();
            this.btnTodosDonantes = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btnQuienesSomos = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblFotos = new System.Windows.Forms.Label();
            this.imglFoos = new System.Windows.Forms.ImageList(this.components);
            this.lblInicio = new System.Windows.Forms.Label();
            this.tmrFotos = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tsHerramientas = new System.Windows.Forms.ToolStrip();
            this.tsbPrincipal = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRegistro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDatos = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiTLD = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPGS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.rtextQuienesSomos = new System.Windows.Forms.RichTextBox();
            this.plQuienesSomos = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plVerGrupoSanguineo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoSanguineo)).BeginInit();
            this.plVerDonantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerDonantes)).BeginInit();
            this.plModificarDatos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.plConsultarDonante.SuspendLayout();
            this.gbConsultar.SuspendLayout();
            this.plRegistrarDonante.SuspendLayout();
            this.tcInformacion.SuspendLayout();
            this.tpPersonal.SuspendLayout();
            this.tpPrincipal.SuspendLayout();
            this.plInicio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbBotones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tsHerramientas.SuspendLayout();
            this.plQuienesSomos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSalirOficial);
            this.panel1.Controls.Add(this.tvLista);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 417);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(1, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 45);
            this.panel2.TabIndex = 5;
            // 
            // btnSalirOficial
            // 
            this.btnSalirOficial.BackColor = System.Drawing.Color.White;
            this.btnSalirOficial.FlatAppearance.BorderSize = 0;
            this.btnSalirOficial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnSalirOficial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSalirOficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirOficial.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSalirOficial.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSalirOficial.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirOficial.Image")));
            this.btnSalirOficial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirOficial.Location = new System.Drawing.Point(6, 342);
            this.btnSalirOficial.Name = "btnSalirOficial";
            this.btnSalirOficial.Size = new System.Drawing.Size(144, 45);
            this.btnSalirOficial.TabIndex = 4;
            this.btnSalirOficial.Text = "SALIR";
            this.btnSalirOficial.UseVisualStyleBackColor = false;
            this.btnSalirOficial.Click += new System.EventHandler(this.btnSalirOficial_Click);
            // 
            // tvLista
            // 
            this.tvLista.BackColor = System.Drawing.Color.White;
            this.tvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvLista.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tvLista.ImageIndex = 0;
            this.tvLista.ImageList = this.imglTreeView;
            this.tvLista.LineColor = System.Drawing.Color.White;
            this.tvLista.Location = new System.Drawing.Point(1, 123);
            this.tvLista.Name = "tvLista";
            treeNode1.ImageIndex = 5;
            treeNode1.Name = "Inicio";
            treeNode1.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode1.SelectedImageIndex = 5;
            treeNode1.Text = "Inicio";
            treeNode1.ToolTipText = "Inicio";
            treeNode2.ImageIndex = 4;
            treeNode2.Name = "Informacion";
            treeNode2.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode2.SelectedImageIndex = 4;
            treeNode2.Text = "Quienes Somos";
            treeNode2.ToolTipText = "Información";
            treeNode3.ImageIndex = 8;
            treeNode3.Name = "Principal";
            treeNode3.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode3.SelectedImageIndex = 8;
            treeNode3.Text = "Página Principal";
            treeNode3.ToolTipText = "Página Principal (Ver inicio)";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "RegistrarDonante";
            treeNode4.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Text = "Registrar Donante";
            treeNode4.ToolTipText = "Agregar un nuevo donante";
            treeNode5.ImageIndex = 3;
            treeNode5.Name = "ModificarDatos";
            treeNode5.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode5.SelectedImageIndex = 3;
            treeNode5.Text = "Modificar Datos";
            treeNode5.ToolTipText = "Modificar datos de un Donante";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "ConsultarDonante";
            treeNode6.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Text = "Consultar Donante";
            treeNode6.ToolTipText = "Encontrar un Donante";
            treeNode7.ImageIndex = 7;
            treeNode7.Name = "TodosDonantes";
            treeNode7.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode7.SelectedImageIndex = 7;
            treeNode7.Text = "Donantes";
            treeNode7.ToolTipText = "Ver todos los donantes";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "VerPorGrupo";
            treeNode8.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode8.SelectedImageIndex = 1;
            treeNode8.Text = "Grupo Sanguineo";
            treeNode8.ToolTipText = "Ver los donantes por grupo sanguineo";
            treeNode9.ImageIndex = 8;
            treeNode9.Name = "VerDonantes";
            treeNode9.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode9.SelectedImageIndex = 8;
            treeNode9.Text = "Ver los Donantes";
            treeNode9.ToolTipText = "Lista de todos los donantes";
            this.tvLista.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode9});
            this.tvLista.SelectedImageIndex = 0;
            this.tvLista.ShowNodeToolTips = true;
            this.tvLista.Size = new System.Drawing.Size(166, 168);
            this.tvLista.TabIndex = 3;
            this.tvLista.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvLista_AfterSelect);
            // 
            // imglTreeView
            // 
            this.imglTreeView.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imglTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglTreeView.ImageStream")));
            this.imglTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imglTreeView.Images.SetKeyName(0, "Agregar.png");
            this.imglTreeView.Images.SetKeyName(1, "BaseDatos.png");
            this.imglTreeView.Images.SetKeyName(2, "Consultar.png");
            this.imglTreeView.Images.SetKeyName(3, "Editar.png");
            this.imglTreeView.Images.SetKeyName(4, "Info.png");
            this.imglTreeView.Images.SetKeyName(5, "Inicio.png");
            this.imglTreeView.Images.SetKeyName(6, "Salir.png");
            this.imglTreeView.Images.SetKeyName(7, "TodosBaseDatos.png");
            this.imglTreeView.Images.SetKeyName(8, "Pin.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // plVerGrupoSanguineo
            // 
            this.plVerGrupoSanguineo.Controls.Add(this.dgvGrupoSanguineo);
            this.plVerGrupoSanguineo.Controls.Add(this.lblVerGrupoSanguineo);
            this.plVerGrupoSanguineo.Location = new System.Drawing.Point(742, 409);
            this.plVerGrupoSanguineo.Name = "plVerGrupoSanguineo";
            this.plVerGrupoSanguineo.Size = new System.Drawing.Size(20, 20);
            this.plVerGrupoSanguineo.TabIndex = 11;
            // 
            // dgvGrupoSanguineo
            // 
            this.dgvGrupoSanguineo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoSanguineo.Location = new System.Drawing.Point(29, 56);
            this.dgvGrupoSanguineo.Name = "dgvGrupoSanguineo";
            this.dgvGrupoSanguineo.RowTemplate.Height = 25;
            this.dgvGrupoSanguineo.Size = new System.Drawing.Size(537, 311);
            this.dgvGrupoSanguineo.TabIndex = 2;
            // 
            // lblVerGrupoSanguineo
            // 
            this.lblVerGrupoSanguineo.AutoSize = true;
            this.lblVerGrupoSanguineo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVerGrupoSanguineo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVerGrupoSanguineo.Location = new System.Drawing.Point(32, 19);
            this.lblVerGrupoSanguineo.Name = "lblVerGrupoSanguineo";
            this.lblVerGrupoSanguineo.Size = new System.Drawing.Size(428, 25);
            this.lblVerGrupoSanguineo.TabIndex = 1;
            this.lblVerGrupoSanguineo.Text = "VER DONANTES POR GRUPO SANGUINEO";
            this.lblVerGrupoSanguineo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plVerDonantes
            // 
            this.plVerDonantes.Controls.Add(this.dgvVerDonantes);
            this.plVerDonantes.Controls.Add(this.lblVerDonantes);
            this.plVerDonantes.Location = new System.Drawing.Point(723, 409);
            this.plVerDonantes.Name = "plVerDonantes";
            this.plVerDonantes.Size = new System.Drawing.Size(20, 20);
            this.plVerDonantes.TabIndex = 10;
            // 
            // dgvVerDonantes
            // 
            this.dgvVerDonantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerDonantes.Location = new System.Drawing.Point(29, 56);
            this.dgvVerDonantes.Name = "dgvVerDonantes";
            this.dgvVerDonantes.RowTemplate.Height = 25;
            this.dgvVerDonantes.Size = new System.Drawing.Size(537, 311);
            this.dgvVerDonantes.TabIndex = 2;
            // 
            // lblVerDonantes
            // 
            this.lblVerDonantes.AutoSize = true;
            this.lblVerDonantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVerDonantes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVerDonantes.Location = new System.Drawing.Point(32, 19);
            this.lblVerDonantes.Name = "lblVerDonantes";
            this.lblVerDonantes.Size = new System.Drawing.Size(168, 25);
            this.lblVerDonantes.TabIndex = 1;
            this.lblVerDonantes.Text = "VER DONANTES";
            this.lblVerDonantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plModificarDatos
            // 
            this.plModificarDatos.Controls.Add(this.txtABuscar);
            this.plModificarDatos.Controls.Add(this.btnCancelar2);
            this.plModificarDatos.Controls.Add(this.btnHecho);
            this.plModificarDatos.Controls.Add(this.tabControl1);
            this.plModificarDatos.Controls.Add(this.cmbBuscar);
            this.plModificarDatos.Controls.Add(this.lblBusMod);
            this.plModificarDatos.Controls.Add(this.lblModificar);
            this.plModificarDatos.Location = new System.Drawing.Point(687, 409);
            this.plModificarDatos.Name = "plModificarDatos";
            this.plModificarDatos.Size = new System.Drawing.Size(20, 20);
            this.plModificarDatos.TabIndex = 6;
            this.plModificarDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.plModificarDatos_Paint);
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(337, 62);
            this.txtABuscar.Name = "txtABuscar";
            this.txtABuscar.Size = new System.Drawing.Size(197, 21);
            this.txtABuscar.TabIndex = 7;
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar2.FlatAppearance.BorderSize = 0;
            this.btnCancelar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar2.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCancelar2.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar2.Image")));
            this.btnCancelar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar2.Location = new System.Drawing.Point(331, 304);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(113, 43);
            this.btnCancelar2.TabIndex = 5;
            this.btnCancelar2.Text = "CANCELAR";
            this.btnCancelar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar2.UseVisualStyleBackColor = false;
            // 
            // btnHecho
            // 
            this.btnHecho.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHecho.FlatAppearance.BorderSize = 0;
            this.btnHecho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnHecho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnHecho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHecho.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHecho.ForeColor = System.Drawing.Color.Firebrick;
            this.btnHecho.Image = ((System.Drawing.Image)(resources.GetObject("btnHecho.Image")));
            this.btnHecho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHecho.Location = new System.Drawing.Point(155, 304);
            this.btnHecho.Name = "btnHecho";
            this.btnHecho.Size = new System.Drawing.Size(113, 43);
            this.btnHecho.TabIndex = 6;
            this.btnHecho.Text = "CONFIRMAR";
            this.btnHecho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHecho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHecho.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(32, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(525, 162);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mtxtCedula);
            this.tabPage1.Controls.Add(this.lblSexo);
            this.tabPage1.Controls.Add(this.mtxtPeso);
            this.tabPage1.Controls.Add(this.rbMas);
            this.tabPage1.Controls.Add(this.rbFem);
            this.tabPage1.Controls.Add(this.dtpFechaNac);
            this.tabPage1.Controls.Add(this.lblFechaNac);
            this.tabPage1.Controls.Add(this.lblPeso);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.lblCedula);
            this.tabPage1.Controls.Add(this.lblApellido);
            this.tabPage1.Controls.Add(this.txtApellido);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(517, 133);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Información Personal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mtxtCedula
            // 
            this.mtxtCedula.Location = new System.Drawing.Point(82, 98);
            this.mtxtCedula.Mask = "000-000000-0000L";
            this.mtxtCedula.Name = "mtxtCedula";
            this.mtxtCedula.Size = new System.Drawing.Size(165, 21);
            this.mtxtCedula.TabIndex = 16;
            this.mtxtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSexo.ForeColor = System.Drawing.Color.Maroon;
            this.lblSexo.Location = new System.Drawing.Point(278, 45);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(36, 15);
            this.lblSexo.TabIndex = 12;
            this.lblSexo.Text = "Sexo:";
            // 
            // mtxtPeso
            // 
            this.mtxtPeso.Location = new System.Drawing.Point(319, 17);
            this.mtxtPeso.Mask = "000.00 lbs";
            this.mtxtPeso.Name = "mtxtPeso";
            this.mtxtPeso.Size = new System.Drawing.Size(118, 21);
            this.mtxtPeso.TabIndex = 15;
            this.mtxtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbMas
            // 
            this.rbMas.AutoSize = true;
            this.rbMas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbMas.ForeColor = System.Drawing.Color.Maroon;
            this.rbMas.Location = new System.Drawing.Point(404, 44);
            this.rbMas.Name = "rbMas";
            this.rbMas.Size = new System.Drawing.Size(81, 19);
            this.rbMas.TabIndex = 11;
            this.rbMas.TabStop = true;
            this.rbMas.Text = "Masculino";
            this.rbMas.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbFem.ForeColor = System.Drawing.Color.Maroon;
            this.rbFem.Location = new System.Drawing.Point(320, 44);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(78, 19);
            this.rbFem.TabIndex = 10;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Femenino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(137, 71);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(95, 21);
            this.dtpFechaNac.TabIndex = 9;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFechaNac.ForeColor = System.Drawing.Color.Maroon;
            this.lblFechaNac.Location = new System.Drawing.Point(25, 74);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(109, 15);
            this.lblFechaNac.TabIndex = 8;
            this.lblFechaNac.Text = "Fecha Nacimiento:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPeso.ForeColor = System.Drawing.Color.Maroon;
            this.lblPeso.Location = new System.Drawing.Point(278, 18);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(35, 15);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(335, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 21);
            this.textBox1.TabIndex = 6;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCedula.ForeColor = System.Drawing.Color.Maroon;
            this.lblCedula.Location = new System.Drawing.Point(25, 101);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(50, 15);
            this.lblCedula.TabIndex = 5;
            this.lblCedula.Text = "Cedula:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblApellido.ForeColor = System.Drawing.Color.Maroon;
            this.lblApellido.Location = new System.Drawing.Point(25, 46);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(55, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(82, 43);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(165, 21);
            this.txtApellido.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.Maroon;
            this.lblNombre.Location = new System.Drawing.Point(25, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 21);
            this.txtNombre.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.Id_Mo);
            this.tabPage2.Controls.Add(this.RH_Mo);
            this.tabPage2.Controls.Add(this.cmb_RH);
            this.tabPage2.Controls.Add(this.lblGrupoSang);
            this.tabPage2.Controls.Add(this.cmbGrupoSang);
            this.tabPage2.Controls.Add(this.lblCentroDonación);
            this.tabPage2.Controls.Add(this.txtCentroDonacion);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(517, 134);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Información para Donar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(51, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 9;
            // 
            // Id_Mo
            // 
            this.Id_Mo.AutoSize = true;
            this.Id_Mo.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Id_Mo.ForeColor = System.Drawing.Color.Maroon;
            this.Id_Mo.Location = new System.Drawing.Point(25, 27);
            this.Id_Mo.Name = "Id_Mo";
            this.Id_Mo.Size = new System.Drawing.Size(20, 15);
            this.Id_Mo.TabIndex = 8;
            this.Id_Mo.Text = "Id:";
            // 
            // RH_Mo
            // 
            this.RH_Mo.AutoSize = true;
            this.RH_Mo.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.RH_Mo.ForeColor = System.Drawing.Color.Maroon;
            this.RH_Mo.Location = new System.Drawing.Point(106, 80);
            this.RH_Mo.Name = "RH_Mo";
            this.RH_Mo.Size = new System.Drawing.Size(24, 15);
            this.RH_Mo.TabIndex = 7;
            this.RH_Mo.Text = "RH:";
            // 
            // cmb_RH
            // 
            this.cmb_RH.BackColor = System.Drawing.Color.RosyBrown;
            this.cmb_RH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_RH.FormattingEnabled = true;
            this.cmb_RH.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmb_RH.Location = new System.Drawing.Point(133, 76);
            this.cmb_RH.Name = "cmb_RH";
            this.cmb_RH.Size = new System.Drawing.Size(121, 24);
            this.cmb_RH.TabIndex = 6;
            // 
            // lblGrupoSang
            // 
            this.lblGrupoSang.AutoSize = true;
            this.lblGrupoSang.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblGrupoSang.ForeColor = System.Drawing.Color.Maroon;
            this.lblGrupoSang.Location = new System.Drawing.Point(25, 51);
            this.lblGrupoSang.Name = "lblGrupoSang";
            this.lblGrupoSang.Size = new System.Drawing.Size(105, 15);
            this.lblGrupoSang.TabIndex = 5;
            this.lblGrupoSang.Text = "Grupo Sanguineo:";
            // 
            // cmbGrupoSang
            // 
            this.cmbGrupoSang.BackColor = System.Drawing.Color.RosyBrown;
            this.cmbGrupoSang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGrupoSang.FormattingEnabled = true;
            this.cmbGrupoSang.Items.AddRange(new object[] {
            "O",
            "AB",
            "A",
            "B"});
            this.cmbGrupoSang.Location = new System.Drawing.Point(133, 46);
            this.cmbGrupoSang.Name = "cmbGrupoSang";
            this.cmbGrupoSang.Size = new System.Drawing.Size(121, 24);
            this.cmbGrupoSang.TabIndex = 4;
            // 
            // lblCentroDonación
            // 
            this.lblCentroDonación.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCentroDonación.ForeColor = System.Drawing.Color.Maroon;
            this.lblCentroDonación.Location = new System.Drawing.Point(273, 45);
            this.lblCentroDonación.Name = "lblCentroDonación";
            this.lblCentroDonación.Size = new System.Drawing.Size(66, 35);
            this.lblCentroDonación.TabIndex = 3;
            this.lblCentroDonación.Text = "Centro de Donación:";
            // 
            // txtCentroDonacion
            // 
            this.txtCentroDonacion.Location = new System.Drawing.Point(345, 49);
            this.txtCentroDonacion.Name = "txtCentroDonacion";
            this.txtCentroDonacion.Size = new System.Drawing.Size(165, 21);
            this.txtCentroDonacion.TabIndex = 2;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.BackColor = System.Drawing.Color.RosyBrown;
            this.cmbBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "Nombre",
            "Id"});
            this.cmbBuscar.Location = new System.Drawing.Point(197, 61);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(121, 24);
            this.cmbBuscar.TabIndex = 3;
            // 
            // lblBusMod
            // 
            this.lblBusMod.AutoSize = true;
            this.lblBusMod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBusMod.Location = new System.Drawing.Point(51, 64);
            this.lblBusMod.Name = "lblBusMod";
            this.lblBusMod.Size = new System.Drawing.Size(140, 17);
            this.lblBusMod.TabIndex = 2;
            this.lblBusMod.Text = "Buscar Donante por:";
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblModificar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModificar.Location = new System.Drawing.Point(20, 14);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(205, 25);
            this.lblModificar.TabIndex = 1;
            this.lblModificar.Text = "MODIFICAR DATOS";
            this.lblModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plConsultarDonante
            // 
            this.plConsultarDonante.Controls.Add(this.btnBuscarConsultar);
            this.plConsultarDonante.Controls.Add(this.lbResultado);
            this.plConsultarDonante.Controls.Add(this.gbConsultar);
            this.plConsultarDonante.Controls.Add(this.lblConsultarDonante);
            this.plConsultarDonante.Location = new System.Drawing.Point(706, 409);
            this.plConsultarDonante.Name = "plConsultarDonante";
            this.plConsultarDonante.Size = new System.Drawing.Size(20, 20);
            this.plConsultarDonante.TabIndex = 6;
            // 
            // btnBuscarConsultar
            // 
            this.btnBuscarConsultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarConsultar.FlatAppearance.BorderSize = 0;
            this.btnBuscarConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnBuscarConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnBuscarConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarConsultar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarConsultar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnBuscarConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarConsultar.Image")));
            this.btnBuscarConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarConsultar.Location = new System.Drawing.Point(26, 229);
            this.btnBuscarConsultar.Name = "btnBuscarConsultar";
            this.btnBuscarConsultar.Size = new System.Drawing.Size(113, 43);
            this.btnBuscarConsultar.TabIndex = 4;
            this.btnBuscarConsultar.Text = "CONSULTAR";
            this.btnBuscarConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarConsultar.UseVisualStyleBackColor = false;
            // 
            // lbResultado
            // 
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.ItemHeight = 16;
            this.lbResultado.Location = new System.Drawing.Point(166, 61);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(400, 276);
            this.lbResultado.TabIndex = 3;
            // 
            // gbConsultar
            // 
            this.gbConsultar.Controls.Add(this.checkedListBox1);
            this.gbConsultar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbConsultar.Location = new System.Drawing.Point(13, 76);
            this.gbConsultar.Name = "gbConsultar";
            this.gbConsultar.Size = new System.Drawing.Size(140, 130);
            this.gbConsultar.TabIndex = 2;
            this.gbConsultar.TabStop = false;
            this.gbConsultar.Text = "Filtro de Busqueda";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Maroon;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBox1.ForeColor = System.Drawing.Color.White;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "ID",
            "Grupo Sanguineo",
            "RH",
            "Centro de Donación",
            "Peso"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 14);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(135, 112);
            this.checkedListBox1.TabIndex = 0;
            // 
            // lblConsultarDonante
            // 
            this.lblConsultarDonante.AutoSize = true;
            this.lblConsultarDonante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConsultarDonante.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConsultarDonante.Location = new System.Drawing.Point(32, 15);
            this.lblConsultarDonante.Name = "lblConsultarDonante";
            this.lblConsultarDonante.Size = new System.Drawing.Size(251, 25);
            this.lblConsultarDonante.TabIndex = 1;
            this.lblConsultarDonante.Text = "CONSULTAR DONANTES";
            this.lblConsultarDonante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plRegistrarDonante
            // 
            this.plRegistrarDonante.Controls.Add(this.btnCance);
            this.plRegistrarDonante.Controls.Add(this.btnAcep);
            this.plRegistrarDonante.Controls.Add(this.tcInformacion);
            this.plRegistrarDonante.Controls.Add(this.lblRegistro);
            this.plRegistrarDonante.Location = new System.Drawing.Point(668, 409);
            this.plRegistrarDonante.Name = "plRegistrarDonante";
            this.plRegistrarDonante.Size = new System.Drawing.Size(20, 20);
            this.plRegistrarDonante.TabIndex = 1;
            this.plRegistrarDonante.Visible = false;
            // 
            // btnCance
            // 
            this.btnCance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCance.FlatAppearance.BorderSize = 0;
            this.btnCance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCance.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCance.Image = ((System.Drawing.Image)(resources.GetObject("btnCance.Image")));
            this.btnCance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCance.Location = new System.Drawing.Point(326, 271);
            this.btnCance.Name = "btnCance";
            this.btnCance.Size = new System.Drawing.Size(113, 43);
            this.btnCance.TabIndex = 4;
            this.btnCance.Text = "CANCELAR";
            this.btnCance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCance.UseVisualStyleBackColor = false;
            // 
            // btnAcep
            // 
            this.btnAcep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAcep.FlatAppearance.BorderSize = 0;
            this.btnAcep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnAcep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnAcep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcep.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAcep.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAcep.Image = ((System.Drawing.Image)(resources.GetObject("btnAcep.Image")));
            this.btnAcep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcep.Location = new System.Drawing.Point(150, 271);
            this.btnAcep.Name = "btnAcep";
            this.btnAcep.Size = new System.Drawing.Size(113, 43);
            this.btnAcep.TabIndex = 4;
            this.btnAcep.Text = "REGISTAR";
            this.btnAcep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcep.UseVisualStyleBackColor = false;
            // 
            // tcInformacion
            // 
            this.tcInformacion.Controls.Add(this.tpPersonal);
            this.tcInformacion.Controls.Add(this.tpPrincipal);
            this.tcInformacion.Location = new System.Drawing.Point(20, 48);
            this.tcInformacion.Name = "tcInformacion";
            this.tcInformacion.SelectedIndex = 0;
            this.tcInformacion.Size = new System.Drawing.Size(525, 162);
            this.tcInformacion.TabIndex = 2;
            // 
            // tpPersonal
            // 
            this.tpPersonal.Controls.Add(this.mtxtCed);
            this.tpPersonal.Controls.Add(this.mtxtPe);
            this.tpPersonal.Controls.Add(this.lblSex);
            this.tpPersonal.Controls.Add(this.rbtnMasculino);
            this.tpPersonal.Controls.Add(this.rbtnFemenino);
            this.tpPersonal.Controls.Add(this.dateTimePicker1);
            this.tpPersonal.Controls.Add(this.lblFecha);
            this.tpPersonal.Controls.Add(this.lblPes);
            this.tpPersonal.Controls.Add(this.lblCed);
            this.tpPersonal.Controls.Add(this.lblApe);
            this.tpPersonal.Controls.Add(this.txtApe);
            this.tpPersonal.Controls.Add(this.lblNom);
            this.tpPersonal.Controls.Add(this.txtNom);
            this.tpPersonal.Location = new System.Drawing.Point(4, 25);
            this.tpPersonal.Name = "tpPersonal";
            this.tpPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonal.Size = new System.Drawing.Size(517, 133);
            this.tpPersonal.TabIndex = 0;
            this.tpPersonal.Text = "Información Personal";
            this.tpPersonal.UseVisualStyleBackColor = true;
            // 
            // mtxtCed
            // 
            this.mtxtCed.Location = new System.Drawing.Point(78, 95);
            this.mtxtCed.Mask = "000-000000-0000L";
            this.mtxtCed.Name = "mtxtCed";
            this.mtxtCed.Size = new System.Drawing.Size(169, 21);
            this.mtxtCed.TabIndex = 14;
            this.mtxtCed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtPe
            // 
            this.mtxtPe.Location = new System.Drawing.Point(315, 14);
            this.mtxtPe.Mask = "000.00 lbs";
            this.mtxtPe.Name = "mtxtPe";
            this.mtxtPe.Size = new System.Drawing.Size(118, 21);
            this.mtxtPe.TabIndex = 13;
            this.mtxtPe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSex.ForeColor = System.Drawing.Color.Maroon;
            this.lblSex.Location = new System.Drawing.Point(275, 42);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(36, 15);
            this.lblSex.TabIndex = 12;
            this.lblSex.Text = "Sexo:";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnMasculino.ForeColor = System.Drawing.Color.Maroon;
            this.rbtnMasculino.Location = new System.Drawing.Point(401, 41);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(81, 19);
            this.rbtnMasculino.TabIndex = 11;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnFemenino.ForeColor = System.Drawing.Color.Maroon;
            this.rbtnFemenino.Location = new System.Drawing.Point(317, 41);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbtnFemenino.TabIndex = 10;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 21);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Maroon;
            this.lblFecha.Location = new System.Drawing.Point(22, 71);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(109, 15);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha Nacimiento:";
            // 
            // lblPes
            // 
            this.lblPes.AutoSize = true;
            this.lblPes.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPes.ForeColor = System.Drawing.Color.Maroon;
            this.lblPes.Location = new System.Drawing.Point(275, 17);
            this.lblPes.Name = "lblPes";
            this.lblPes.Size = new System.Drawing.Size(35, 15);
            this.lblPes.TabIndex = 7;
            this.lblPes.Text = "Peso:";
            // 
            // lblCed
            // 
            this.lblCed.AutoSize = true;
            this.lblCed.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCed.ForeColor = System.Drawing.Color.Maroon;
            this.lblCed.Location = new System.Drawing.Point(22, 98);
            this.lblCed.Name = "lblCed";
            this.lblCed.Size = new System.Drawing.Size(50, 15);
            this.lblCed.TabIndex = 5;
            this.lblCed.Text = "Cedula:";
            this.lblCed.Click += new System.EventHandler(this.lblCed_Click);
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblApe.ForeColor = System.Drawing.Color.Maroon;
            this.lblApe.Location = new System.Drawing.Point(22, 42);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(55, 15);
            this.lblApe.TabIndex = 3;
            this.lblApe.Text = "Apellido:";
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(82, 39);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(165, 21);
            this.txtApe.TabIndex = 2;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNom.ForeColor = System.Drawing.Color.Maroon;
            this.lblNom.Location = new System.Drawing.Point(22, 15);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 15);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(82, 12);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(165, 21);
            this.txtNom.TabIndex = 0;
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.Controls.Add(this.lbl_Id);
            this.tpPrincipal.Controls.Add(this.lblId);
            this.tpPrincipal.Controls.Add(this.lblRh);
            this.tpPrincipal.Controls.Add(this.cmbRh);
            this.tpPrincipal.Controls.Add(this.lblGrupo);
            this.tpPrincipal.Controls.Add(this.cmbGrupo);
            this.tpPrincipal.Controls.Add(this.lblCentro);
            this.tpPrincipal.Controls.Add(this.txtCentro);
            this.tpPrincipal.Location = new System.Drawing.Point(4, 24);
            this.tpPrincipal.Name = "tpPrincipal";
            this.tpPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrincipal.Size = new System.Drawing.Size(517, 134);
            this.tpPrincipal.TabIndex = 1;
            this.tpPrincipal.Text = "Información para Donar";
            this.tpPrincipal.UseVisualStyleBackColor = true;
            this.tpPrincipal.Click += new System.EventHandler(this.tpPrincipal_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Id.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Id.Location = new System.Drawing.Point(48, 24);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(0, 15);
            this.lbl_Id.TabIndex = 9;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.Color.Maroon;
            this.lblId.Location = new System.Drawing.Point(22, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Id:";
            // 
            // lblRh
            // 
            this.lblRh.AutoSize = true;
            this.lblRh.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblRh.ForeColor = System.Drawing.Color.Maroon;
            this.lblRh.Location = new System.Drawing.Point(103, 77);
            this.lblRh.Name = "lblRh";
            this.lblRh.Size = new System.Drawing.Size(24, 15);
            this.lblRh.TabIndex = 7;
            this.lblRh.Text = "RH:";
            // 
            // cmbRh
            // 
            this.cmbRh.BackColor = System.Drawing.Color.RosyBrown;
            this.cmbRh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRh.FormattingEnabled = true;
            this.cmbRh.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbRh.Location = new System.Drawing.Point(133, 74);
            this.cmbRh.Name = "cmbRh";
            this.cmbRh.Size = new System.Drawing.Size(121, 24);
            this.cmbRh.TabIndex = 6;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblGrupo.ForeColor = System.Drawing.Color.Maroon;
            this.lblGrupo.Location = new System.Drawing.Point(22, 48);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(105, 15);
            this.lblGrupo.TabIndex = 5;
            this.lblGrupo.Text = "Grupo Sanguineo:";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.BackColor = System.Drawing.Color.RosyBrown;
            this.cmbGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Items.AddRange(new object[] {
            "O",
            "AB",
            "A",
            "B"});
            this.cmbGrupo.Location = new System.Drawing.Point(133, 44);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(121, 24);
            this.cmbGrupo.TabIndex = 4;
            // 
            // lblCentro
            // 
            this.lblCentro.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCentro.ForeColor = System.Drawing.Color.Maroon;
            this.lblCentro.Location = new System.Drawing.Point(273, 45);
            this.lblCentro.Name = "lblCentro";
            this.lblCentro.Size = new System.Drawing.Size(66, 35);
            this.lblCentro.TabIndex = 3;
            this.lblCentro.Text = "Centro de Donación:";
            // 
            // txtCentro
            // 
            this.txtCentro.Location = new System.Drawing.Point(345, 49);
            this.txtCentro.Name = "txtCentro";
            this.txtCentro.Size = new System.Drawing.Size(165, 21);
            this.txtCentro.TabIndex = 2;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRegistro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegistro.Location = new System.Drawing.Point(15, 11);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(248, 25);
            this.lblRegistro.TabIndex = 1;
            this.lblRegistro.Text = "REGISTRO DE DONANTE";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plInicio
            // 
            this.plInicio.Controls.Add(this.groupBox1);
            this.plInicio.Controls.Add(this.gbBotones);
            this.plInicio.Controls.Add(this.lblInformacion);
            this.plInicio.Controls.Add(this.lblFotos);
            this.plInicio.Controls.Add(this.lblInicio);
            this.plInicio.Location = new System.Drawing.Point(170, 38);
            this.plInicio.Name = "plInicio";
            this.plInicio.Size = new System.Drawing.Size(592, 370);
            this.plInicio.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGrupoSanguineo);
            this.groupBox1.Controls.Add(this.btnTodosDonantes);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(32, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 123);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnGrupoSanguineo
            // 
            this.btnGrupoSanguineo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGrupoSanguineo.FlatAppearance.BorderSize = 0;
            this.btnGrupoSanguineo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnGrupoSanguineo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnGrupoSanguineo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrupoSanguineo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGrupoSanguineo.ForeColor = System.Drawing.Color.Firebrick;
            this.btnGrupoSanguineo.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupoSanguineo.Image")));
            this.btnGrupoSanguineo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrupoSanguineo.Location = new System.Drawing.Point(373, 71);
            this.btnGrupoSanguineo.Name = "btnGrupoSanguineo";
            this.btnGrupoSanguineo.Size = new System.Drawing.Size(113, 43);
            this.btnGrupoSanguineo.TabIndex = 3;
            this.btnGrupoSanguineo.Text = "GRUPO SANGUINEO";
            this.btnGrupoSanguineo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrupoSanguineo.UseVisualStyleBackColor = false;
            // 
            // btnTodosDonantes
            // 
            this.btnTodosDonantes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTodosDonantes.FlatAppearance.BorderSize = 0;
            this.btnTodosDonantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnTodosDonantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnTodosDonantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosDonantes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTodosDonantes.ForeColor = System.Drawing.Color.Firebrick;
            this.btnTodosDonantes.Image = ((System.Drawing.Image)(resources.GetObject("btnTodosDonantes.Image")));
            this.btnTodosDonantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosDonantes.Location = new System.Drawing.Point(373, 22);
            this.btnTodosDonantes.Name = "btnTodosDonantes";
            this.btnTodosDonantes.Size = new System.Drawing.Size(113, 43);
            this.btnTodosDonantes.TabIndex = 3;
            this.btnTodosDonantes.Text = "VER DONANTES";
            this.btnTodosDonantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTodosDonantes.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(254, 22);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(113, 43);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "CONSULTAR DONANTE";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(135, 22);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 43);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "MODIFICAR DATOS";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(16, 22);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(113, 43);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "REGISTAR DONANTE";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // gbBotones
            // 
            this.gbBotones.Controls.Add(this.btnQuienesSomos);
            this.gbBotones.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbBotones.Location = new System.Drawing.Point(32, 128);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(150, 79);
            this.gbBotones.TabIndex = 4;
            this.gbBotones.TabStop = false;
            this.gbBotones.Text = "Información";
            // 
            // btnQuienesSomos
            // 
            this.btnQuienesSomos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuienesSomos.FlatAppearance.BorderSize = 0;
            this.btnQuienesSomos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnQuienesSomos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnQuienesSomos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuienesSomos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuienesSomos.ForeColor = System.Drawing.Color.Firebrick;
            this.btnQuienesSomos.Image = ((System.Drawing.Image)(resources.GetObject("btnQuienesSomos.Image")));
            this.btnQuienesSomos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuienesSomos.Location = new System.Drawing.Point(19, 24);
            this.btnQuienesSomos.Name = "btnQuienesSomos";
            this.btnQuienesSomos.Size = new System.Drawing.Size(113, 43);
            this.btnQuienesSomos.TabIndex = 3;
            this.btnQuienesSomos.Text = "QUIENES SOMOS";
            this.btnQuienesSomos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuienesSomos.UseVisualStyleBackColor = false;
            // 
            // lblInformacion
            // 
            this.lblInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInformacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInformacion.Location = new System.Drawing.Point(20, 45);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(299, 59);
            this.lblInformacion.TabIndex = 2;
            this.lblInformacion.Text = "Bienvenido al programa de Registro del Banco de Sangre \"Por Más Vidas\" ";
            this.lblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFotos
            // 
            this.lblFotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFotos.ImageList = this.imglFoos;
            this.lblFotos.Location = new System.Drawing.Point(391, 19);
            this.lblFotos.Name = "lblFotos";
            this.lblFotos.Size = new System.Drawing.Size(150, 150);
            this.lblFotos.TabIndex = 1;
            this.lblFotos.Click += new System.EventHandler(this.lblFotos_Click);
            // 
            // imglFoos
            // 
            this.imglFoos.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imglFoos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglFoos.ImageStream")));
            this.imglFoos.TransparentColor = System.Drawing.Color.Transparent;
            this.imglFoos.Images.SetKeyName(0, "Picsart_22-10-30_13-28-20-434.jpg");
            this.imglFoos.Images.SetKeyName(1, "Picsart_22-10-30_13-28-33-342.jpg");
            this.imglFoos.Images.SetKeyName(2, "Picsart_22-10-30_13-28-45-343.jpg");
            this.imglFoos.Images.SetKeyName(3, "Picsart_22-10-30_13-28-59-312.jpg");
            this.imglFoos.Images.SetKeyName(4, "Picsart_22-10-30_13-29-17-906.jpg");
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInicio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInicio.Location = new System.Drawing.Point(32, 19);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(80, 25);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "INICIO";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrFotos
            // 
            this.tmrFotos.Interval = 900;
            this.tmrFotos.Tick += new System.EventHandler(this.tmrFotos_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tsHerramientas, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(170, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(592, 39);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tsHerramientas
            // 
            this.tsHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrincipal,
            this.toolStripSeparator6,
            this.tsbRegistro,
            this.toolStripSeparator7,
            this.tsbModificar,
            this.toolStripSeparator8,
            this.tsbConsultar,
            this.toolStripSeparator9,
            this.tsbDatos,
            this.toolStripSeparator10,
            this.tsbSalir});
            this.tsHerramientas.Location = new System.Drawing.Point(0, 0);
            this.tsHerramientas.Name = "tsHerramientas";
            this.tsHerramientas.Size = new System.Drawing.Size(592, 38);
            this.tsHerramientas.TabIndex = 0;
            this.tsHerramientas.Text = "toolStrip2";
            // 
            // tsbPrincipal
            // 
            this.tsbPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInicio,
            this.tsmiQS});
            this.tsbPrincipal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsbPrincipal.ForeColor = System.Drawing.Color.Maroon;
            this.tsbPrincipal.Image = global::ElProyecto.Properties.Resources.Inicio;
            this.tsbPrincipal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrincipal.Name = "tsbPrincipal";
            this.tsbPrincipal.Size = new System.Drawing.Size(98, 35);
            this.tsbPrincipal.Text = "Pag. Principal";
            this.tsbPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiInicio
            // 
            this.tsmiInicio.Name = "tsmiInicio";
            this.tsmiInicio.Size = new System.Drawing.Size(156, 22);
            this.tsmiInicio.Text = "Inicio";
            // 
            // tsmiQS
            // 
            this.tsmiQS.Name = "tsmiQS";
            this.tsmiQS.Size = new System.Drawing.Size(156, 22);
            this.tsmiQS.Text = "Quienes Somos";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbRegistro
            // 
            this.tsbRegistro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsbRegistro.ForeColor = System.Drawing.Color.Maroon;
            this.tsbRegistro.Image = global::ElProyecto.Properties.Resources.Agregar;
            this.tsbRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRegistro.Name = "tsbRegistro";
            this.tsbRegistro.Size = new System.Drawing.Size(103, 35);
            this.tsbRegistro.Text = "Registro Donante";
            this.tsbRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbModificar
            // 
            this.tsbModificar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsbModificar.ForeColor = System.Drawing.Color.Maroon;
            this.tsbModificar.Image = global::ElProyecto.Properties.Resources.Editar;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(111, 35);
            this.tsbModificar.Text = "Modificar Donante";
            this.tsbModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbConsultar
            // 
            this.tsbConsultar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsbConsultar.ForeColor = System.Drawing.Color.Maroon;
            this.tsbConsultar.Image = global::ElProyecto.Properties.Resources.Consultar;
            this.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultar.Name = "tsbConsultar";
            this.tsbConsultar.Size = new System.Drawing.Size(111, 35);
            this.tsbConsultar.Text = "Consultar Donante";
            this.tsbConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbConsultar.ToolTipText = "Consultar Donante";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbDatos
            // 
            this.tsbDatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTLD,
            this.tsmiPGS});
            this.tsbDatos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsbDatos.ForeColor = System.Drawing.Color.Maroon;
            this.tsbDatos.Image = global::ElProyecto.Properties.Resources.BaseDatos;
            this.tsbDatos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDatos.Name = "tsbDatos";
            this.tsbDatos.Size = new System.Drawing.Size(53, 35);
            this.tsbDatos.Text = "Datos";
            this.tsbDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDatos.ToolTipText = "Datos de los Donantes";
            // 
            // tsmiTLD
            // 
            this.tsmiTLD.Name = "tsmiTLD";
            this.tsmiTLD.Size = new System.Drawing.Size(190, 22);
            this.tsmiTLD.Text = "Todos los Donantes";
            // 
            // tsmiPGS
            // 
            this.tsmiPGS.Name = "tsmiPGS";
            this.tsmiPGS.Size = new System.Drawing.Size(190, 22);
            this.tsmiPGS.Text = "Por Grupo Sanguineo";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbSalir
            // 
            this.tsbSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsbSalir.ForeColor = System.Drawing.Color.Maroon;
            this.tsbSalir.Image = global::ElProyecto.Properties.Resources.Salir;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(55, 35);
            this.tsbSalir.Text = "SALIR";
            this.tsbSalir.ToolTipText = "Salir del Programa";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // rtextQuienesSomos
            // 
            this.rtextQuienesSomos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtextQuienesSomos.BackColor = System.Drawing.Color.Maroon;
            this.rtextQuienesSomos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtextQuienesSomos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtextQuienesSomos.ForeColor = System.Drawing.Color.White;
            this.rtextQuienesSomos.Location = new System.Drawing.Point(22, 32);
            this.rtextQuienesSomos.Name = "rtextQuienesSomos";
            this.rtextQuienesSomos.ReadOnly = true;
            this.rtextQuienesSomos.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtextQuienesSomos.Size = new System.Drawing.Size(0, 0);
            this.rtextQuienesSomos.TabIndex = 12;
            this.rtextQuienesSomos.Text = resources.GetString("rtextQuienesSomos.Text");
            // 
            // plQuienesSomos
            // 
            this.plQuienesSomos.BackColor = System.Drawing.Color.Maroon;
            this.plQuienesSomos.Controls.Add(this.rtextQuienesSomos);
            this.plQuienesSomos.Location = new System.Drawing.Point(649, 409);
            this.plQuienesSomos.Name = "plQuienesSomos";
            this.plQuienesSomos.Size = new System.Drawing.Size(20, 20);
            this.plQuienesSomos.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(762, 415);
            this.Controls.Add(this.plQuienesSomos);
            this.Controls.Add(this.plVerGrupoSanguineo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.plInicio);
            this.Controls.Add(this.plVerDonantes);
            this.Controls.Add(this.plModificarDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plRegistrarDonante);
            this.Controls.Add(this.plConsultarDonante);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Sangre Por Más Vidas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plVerGrupoSanguineo.ResumeLayout(false);
            this.plVerGrupoSanguineo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoSanguineo)).EndInit();
            this.plVerDonantes.ResumeLayout(false);
            this.plVerDonantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerDonantes)).EndInit();
            this.plModificarDatos.ResumeLayout(false);
            this.plModificarDatos.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.plConsultarDonante.ResumeLayout(false);
            this.plConsultarDonante.PerformLayout();
            this.gbConsultar.ResumeLayout(false);
            this.plRegistrarDonante.ResumeLayout(false);
            this.plRegistrarDonante.PerformLayout();
            this.tcInformacion.ResumeLayout(false);
            this.tpPersonal.ResumeLayout(false);
            this.tpPersonal.PerformLayout();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            this.plInicio.ResumeLayout(false);
            this.plInicio.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbBotones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tsHerramientas.ResumeLayout(false);
            this.tsHerramientas.PerformLayout();
            this.plQuienesSomos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TreeView tvLista;
        private Panel panel1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrFotos;
        private ImageList imglFoos;
        private Panel plInicio;
        private Label lblFotos;
        private Label lblInicio;
        private Label lblInformacion;
        private GroupBox gbBotones;
        private Button btnQuienesSomos;
        private GroupBox groupBox1;
        private Button btnGrupoSanguineo;
        private Button btnTodosDonantes;
        private Button btnConsultar;
        private Button btnModificar;
        private Button btnRegistrar;
        private ImageList imglTreeView;
        private Panel panel2;
        private Button btnSalirOficial;
        private Panel plRegistrarDonante;
        private TabControl tcInformacion;
        private TabPage tpPersonal;
        private Label lblApe;
        private TextBox txtApe;
        private Label lblNom;
        private TextBox txtNom;
        private TabPage tpPrincipal;
        private Label lblRegistro;
        private Label lblCed;
        private DateTimePicker dateTimePicker1;
        private Label lblFecha;
        private Label lblPes;
        private Label lblRh;
        private ComboBox cmbRh;
        private Label lblGrupo;
        private ComboBox cmbGrupo;
        private Label lblCentro;
        private TextBox txtCentro;
        private Label lblSex;
        private RadioButton rbtnMasculino;
        private RadioButton rbtnFemenino;
        private Label lblId;
        private Label lbl_Id;
        private Button btnCance;
        private Button btnAcep;
        private Panel plModificarDatos;
        private Label lblModificar;
        private ComboBox cmbBuscar;
        private Label lblBusMod;
        private Button btnCancelar2;
        private Button btnHecho;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label lblSexo;
        private RadioButton rbMas;
        private RadioButton rbFem;
        private DateTimePicker dtpFechaNac;
        private Label lblFechaNac;
        private Label lblPeso;
        private TextBox textBox1;
        private Label lblCedula;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblNombre;
        private TextBox txtNombre;
        private TabPage tabPage2;
        private Label label7;
        private Label Id_Mo;
        private Label RH_Mo;
        private ComboBox cmb_RH;
        private Label lblGrupoSang;
        private ComboBox cmbGrupoSang;
        private Label lblCentroDonación;
        private TextBox txtCentroDonacion;
        private Panel plConsultarDonante;
        private Label lblConsultarDonante;
        private Button btnBuscarConsultar;
        private ListBox lbResultado;
        private GroupBox gbConsultar;
        private CheckedListBox checkedListBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStrip tsHerramientas;
        private ToolStripSplitButton tsbPrincipal;
        private ToolStripMenuItem tsmiInicio;
        private ToolStripMenuItem tsmiQS;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton tsbRegistro;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton tsbModificar;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton tsbConsultar;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripSplitButton tsbDatos;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripButton tsbSalir;
        private MaskedTextBox mtxtCed;
        private MaskedTextBox mtxtPe;
        private MaskedTextBox mtxtCedula;
        private MaskedTextBox mtxtPeso;
        private TextBox txtABuscar;
        private Panel plVerDonantes;
        private DataGridView dgvVerDonantes;
        private Label lblVerDonantes;
        private Panel plVerGrupoSanguineo;
        private DataGridView dgvGrupoSanguineo;
        private Label lblVerGrupoSanguineo;
        private ToolStripMenuItem tsmiTLD;
        private ToolStripMenuItem tsmiPGS;
        private RichTextBox rtextQuienesSomos;
        private Panel plQuienesSomos;
    }
}