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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalirOficial = new System.Windows.Forms.Button();
            this.tvLista = new System.Windows.Forms.TreeView();
            this.imglTreeView = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.plRegistrarDonante = new System.Windows.Forms.Panel();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.tcInformacion = new System.Windows.Forms.TabControl();
            this.tpPersonal = new System.Windows.Forms.TabPage();
            this.tpPrincipal = new System.Windows.Forms.TabPage();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.lblCed = new System.Windows.Forms.Label();
            this.txtCed = new System.Windows.Forms.TextBox();
            this.lblPes = new System.Windows.Forms.Label();
            this.txtPes = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblRh = new System.Windows.Forms.Label();
            this.cmbRh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plInicio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbBotones.SuspendLayout();
            this.plRegistrarDonante.SuspendLayout();
            this.tcInformacion.SuspendLayout();
            this.tpPersonal.SuspendLayout();
            this.tpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.plRegistrarDonante);
            this.splitContainer1.Panel2.Controls.Add(this.plInicio);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(761, 405);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSalirOficial);
            this.panel1.Controls.Add(this.tvLista);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 412);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(3, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 43);
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
            this.btnSalirOficial.Location = new System.Drawing.Point(7, 353);
            this.btnSalirOficial.Name = "btnSalirOficial";
            this.btnSalirOficial.Size = new System.Drawing.Size(140, 43);
            this.btnSalirOficial.TabIndex = 4;
            this.btnSalirOficial.Text = "SALIR";
            this.btnSalirOficial.UseVisualStyleBackColor = false;
            this.btnSalirOficial.Click += new System.EventHandler(this.btnSalirOficial_Click);
            // 
            // tvLista
            // 
            this.tvLista.BackColor = System.Drawing.Color.White;
            this.tvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvLista.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tvLista.ImageIndex = 0;
            this.tvLista.ImageList = this.imglTreeView;
            this.tvLista.LineColor = System.Drawing.Color.White;
            this.tvLista.Location = new System.Drawing.Point(-3, 123);
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
            treeNode4.Name = "AgregarDonante";
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
            this.tvLista.Size = new System.Drawing.Size(165, 168);
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
            // plInicio
            // 
            this.plInicio.Controls.Add(this.groupBox1);
            this.plInicio.Controls.Add(this.gbBotones);
            this.plInicio.Controls.Add(this.lblInformacion);
            this.plInicio.Controls.Add(this.lblFotos);
            this.plInicio.Controls.Add(this.lblInicio);
            this.plInicio.Location = new System.Drawing.Point(550, 387);
            this.plInicio.Name = "plInicio";
            this.plInicio.Size = new System.Drawing.Size(596, 405);
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
            this.groupBox1.Location = new System.Drawing.Point(32, 249);
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
            this.gbBotones.Location = new System.Drawing.Point(32, 164);
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
            this.lblInformacion.Location = new System.Drawing.Point(20, 81);
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
            this.lblFotos.Location = new System.Drawing.Point(391, 29);
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
            this.lblInicio.Location = new System.Drawing.Point(32, 29);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(80, 25);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "INICIO";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrFotos
            // 
            this.tmrFotos.Interval = 800;
            this.tmrFotos.Tick += new System.EventHandler(this.tmrFotos_Tick);
            // 
            // plRegistrarDonante
            // 
            this.plRegistrarDonante.Controls.Add(this.tcInformacion);
            this.plRegistrarDonante.Controls.Add(this.lblRegistro);
            this.plRegistrarDonante.Location = new System.Drawing.Point(-1, 0);
            this.plRegistrarDonante.Name = "plRegistrarDonante";
            this.plRegistrarDonante.Size = new System.Drawing.Size(596, 405);
            this.plRegistrarDonante.TabIndex = 1;
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
            // tcInformacion
            // 
            this.tcInformacion.Controls.Add(this.tpPersonal);
            this.tcInformacion.Controls.Add(this.tpPrincipal);
            this.tcInformacion.Location = new System.Drawing.Point(27, 54);
            this.tcInformacion.Name = "tcInformacion";
            this.tcInformacion.SelectedIndex = 0;
            this.tcInformacion.Size = new System.Drawing.Size(525, 174);
            this.tcInformacion.TabIndex = 2;
            // 
            // tpPersonal
            // 
            this.tpPersonal.Controls.Add(this.dateTimePicker1);
            this.tpPersonal.Controls.Add(this.lblFecha);
            this.tpPersonal.Controls.Add(this.lblPes);
            this.tpPersonal.Controls.Add(this.txtPes);
            this.tpPersonal.Controls.Add(this.lblCed);
            this.tpPersonal.Controls.Add(this.txtCed);
            this.tpPersonal.Controls.Add(this.lblApe);
            this.tpPersonal.Controls.Add(this.txtApe);
            this.tpPersonal.Controls.Add(this.lblNom);
            this.tpPersonal.Controls.Add(this.txtNom);
            this.tpPersonal.Location = new System.Drawing.Point(4, 25);
            this.tpPersonal.Name = "tpPersonal";
            this.tpPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonal.Size = new System.Drawing.Size(517, 145);
            this.tpPersonal.TabIndex = 0;
            this.tpPersonal.Text = "Información Personal";
            this.tpPersonal.UseVisualStyleBackColor = true;
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.Controls.Add(this.lblRh);
            this.tpPrincipal.Controls.Add(this.cmbRh);
            this.tpPrincipal.Controls.Add(this.lblGrupo);
            this.tpPrincipal.Controls.Add(this.cmbGrupo);
            this.tpPrincipal.Controls.Add(this.label1);
            this.tpPrincipal.Controls.Add(this.textBox1);
            this.tpPrincipal.Location = new System.Drawing.Point(4, 25);
            this.tpPrincipal.Name = "tpPrincipal";
            this.tpPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrincipal.Size = new System.Drawing.Size(517, 145);
            this.tpPrincipal.TabIndex = 1;
            this.tpPrincipal.Text = "Información para Donar";
            this.tpPrincipal.UseVisualStyleBackColor = true;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(82, 28);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(165, 21);
            this.txtNom.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNom.ForeColor = System.Drawing.Color.Maroon;
            this.lblNom.Location = new System.Drawing.Point(22, 31);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 15);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre:";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblApe.ForeColor = System.Drawing.Color.Maroon;
            this.lblApe.Location = new System.Drawing.Point(22, 58);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(55, 15);
            this.lblApe.TabIndex = 3;
            this.lblApe.Text = "Apellido:";
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(82, 55);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(165, 21);
            this.txtApe.TabIndex = 2;
            // 
            // lblCed
            // 
            this.lblCed.AutoSize = true;
            this.lblCed.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCed.ForeColor = System.Drawing.Color.Maroon;
            this.lblCed.Location = new System.Drawing.Point(274, 31);
            this.lblCed.Name = "lblCed";
            this.lblCed.Size = new System.Drawing.Size(50, 15);
            this.lblCed.TabIndex = 5;
            this.lblCed.Text = "Cedula:";
            this.lblCed.Click += new System.EventHandler(this.lblCed_Click);
            // 
            // txtCed
            // 
            this.txtCed.Location = new System.Drawing.Point(334, 28);
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(123, 21);
            this.txtCed.TabIndex = 4;
            this.txtCed.TextChanged += new System.EventHandler(this.txtCed_TextChanged);
            // 
            // lblPes
            // 
            this.lblPes.AutoSize = true;
            this.lblPes.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPes.ForeColor = System.Drawing.Color.Maroon;
            this.lblPes.Location = new System.Drawing.Point(274, 61);
            this.lblPes.Name = "lblPes";
            this.lblPes.Size = new System.Drawing.Size(35, 15);
            this.lblPes.TabIndex = 7;
            this.lblPes.Text = "Peso:";
            // 
            // txtPes
            // 
            this.txtPes.Location = new System.Drawing.Point(334, 58);
            this.txtPes.Name = "txtPes";
            this.txtPes.Size = new System.Drawing.Size(123, 21);
            this.txtPes.TabIndex = 6;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Maroon;
            this.lblFecha.Location = new System.Drawing.Point(22, 88);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(109, 15);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha Nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 21);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(272, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(332, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 21);
            this.textBox1.TabIndex = 2;
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
            this.cmbGrupo.Location = new System.Drawing.Point(130, 20);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(121, 24);
            this.cmbGrupo.TabIndex = 4;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblGrupo.ForeColor = System.Drawing.Color.Maroon;
            this.lblGrupo.Location = new System.Drawing.Point(19, 24);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(105, 15);
            this.lblGrupo.TabIndex = 5;
            this.lblGrupo.Text = "Grupo Sanguineo:";
            // 
            // lblRh
            // 
            this.lblRh.AutoSize = true;
            this.lblRh.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblRh.ForeColor = System.Drawing.Color.Maroon;
            this.lblRh.Location = new System.Drawing.Point(100, 53);
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
            this.cmbRh.Location = new System.Drawing.Point(130, 50);
            this.cmbRh.Name = "cmbRh";
            this.cmbRh.Size = new System.Drawing.Size(121, 24);
            this.cmbRh.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(761, 405);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Sangre Por Más Vidas";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plInicio.ResumeLayout(false);
            this.plInicio.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbBotones.ResumeLayout(false);
            this.plRegistrarDonante.ResumeLayout(false);
            this.plRegistrarDonante.PerformLayout();
            this.tcInformacion.ResumeLayout(false);
            this.tpPersonal.ResumeLayout(false);
            this.tpPersonal.PerformLayout();
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
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
        private TextBox txtCed;
        private DateTimePicker dateTimePicker1;
        private Label lblFecha;
        private Label lblPes;
        private TextBox txtPes;
        private Label lblRh;
        private ComboBox cmbRh;
        private Label lblGrupo;
        private ComboBox cmbGrupo;
        private Label label1;
        private TextBox textBox1;
    }
}