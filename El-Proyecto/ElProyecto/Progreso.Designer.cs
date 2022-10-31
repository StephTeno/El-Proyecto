namespace ElProyecto
{
    partial class Progreso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.tmPrueba = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbProgreso
            // 
            this.pbProgreso.ForeColor = System.Drawing.Color.RosyBrown;
            this.pbProgreso.Location = new System.Drawing.Point(12, 61);
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(247, 23);
            this.pbProgreso.Step = 0;
            this.pbProgreso.TabIndex = 0;
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProgreso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProgreso.Location = new System.Drawing.Point(108, 32);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(55, 15);
            this.lblProgreso.TabIndex = 1;
            this.lblProgreso.Text = "Progreso";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnContinuar.DialogResult = System.Windows.Forms.DialogResult.Continue;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContinuar.Location = new System.Drawing.Point(99, 101);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // tmPrueba
            // 
            this.tmPrueba.Enabled = true;
            this.tmPrueba.Interval = 50;
            this.tmPrueba.Tick += new System.EventHandler(this.tmPrueba_Tick);
            // 
            // Progreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(271, 136);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.pbProgreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Progreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progreso";
            this.Load += new System.EventHandler(this.Progreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar pbProgreso;
        private Label lblProgreso;
        private Button btnContinuar;
        private System.Windows.Forms.Timer tmPrueba;
    }
}