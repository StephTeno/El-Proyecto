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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Inicio");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Quienes Somos");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Página Principal", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Registrar Donante");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Modificar Datos");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Consultar Donante");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Todos los Donantes");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Grupo Sanguineo");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Ver los Donantes", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lista = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.BackColor = System.Drawing.Color.White;
            this.Lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lista.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lista.LineColor = System.Drawing.Color.White;
            this.Lista.Location = new System.Drawing.Point(-5, 122);
            this.Lista.Name = "Lista";
            treeNode1.Name = "Inicio";
            treeNode1.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode1.Text = "Inicio";
            treeNode1.ToolTipText = "Inicio";
            treeNode2.Name = "Informacion";
            treeNode2.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode2.Text = "Quienes Somos";
            treeNode2.ToolTipText = "Información";
            treeNode3.Name = "Principal";
            treeNode3.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode3.Text = "Página Principal";
            treeNode3.ToolTipText = "Página Principal (Ver inicio)";
            treeNode4.Name = "AgregarDonante";
            treeNode4.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode4.Text = "Registrar Donante";
            treeNode4.ToolTipText = "Agregar un nuevo donante";
            treeNode5.Name = "ModificarDatos";
            treeNode5.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode5.Text = "Modificar Datos";
            treeNode5.ToolTipText = "Modificar datos de un Donante";
            treeNode6.Name = "ConsultarDonante";
            treeNode6.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode6.Text = "Consultar Donante";
            treeNode6.ToolTipText = "Encontrar un Donante";
            treeNode7.Name = "TodosDonantes";
            treeNode7.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode7.Text = "Todos los Donantes";
            treeNode7.ToolTipText = "Ver todos los donantes";
            treeNode8.Name = "VerPorGrupo";
            treeNode8.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode8.Text = "Grupo Sanguineo";
            treeNode8.ToolTipText = "Ver los donantes por grupo sanguineo";
            treeNode9.Name = "VerDonantes";
            treeNode9.NodeFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode9.Text = "Ver los Donantes";
            treeNode9.ToolTipText = "Lista de todos los donantes";
            this.Lista.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode9});
            this.Lista.Size = new System.Drawing.Size(155, 263);
            this.Lista.TabIndex = 0;
            this.Lista.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 386);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(761, 380);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Banco de Sangre Por Más Vidas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView Lista;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}