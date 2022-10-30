namespace ElProyecto
{
    public partial class Form1 : Form
    {
        private int i;
        public Form1()
        {
            InitializeComponent();
            tmrFotos.Enabled = true;
            i = 0;
            plInicio.Visible = true;
        }


        public static bool ProgressBar()
        {bool si = false;
            Progreso prog = new Progreso();
            if (prog.ShowDialog() == DialogResult.Continue)
                return si = true;
            return si;
        }
        private void tvLista_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch ((tvLista.SelectedNode.Text))
            {
                case "Inicio":
                    Inicio();

                    break;
                case "Informacion":
                    break;
                case "AgregarDonante":
                    bool s=ProgressBar();
                    if(s)
                    {
                        RegistrarDonante();
                    }
                    break;
                case "ModificarDatos":
                    break;
                case "ConsultarDonante":
                    break;
                case "TodosDonantes":
                    break;
                case "VerPorGrupo":
                    break;
            }
        }

        private void tmrFotos_Tick(object sender, EventArgs e){i++;if (i > 5) { i = 0; }lblFotos.ImageIndex = i;}
        public void Inicio()
        {
            plInicio.Visible = true;
            plRegistrarDonante.Visible = false;
            plInicio.Location = new Point(-1, 0);
        }
        public void QuienesSomos()
        {
            plInicio.Visible = true;
        }
        public void RegistrarDonante()
        {
            plInicio.Visible = false;
            plRegistrarDonante.Visible = true;
            plRegistrarDonante.Location = new Point(-1, 0);
        }
        public void ModificarDonantes()
        {
            plInicio.Visible = true;
        }
        public void ConsultarDonantes()
        {
            plInicio.Visible = true;
        }
        public void VerTodosLosDonantes()
        {
            plInicio.Visible = true;
        }
        public void VerLosDonantesGrupo()
        {
            plInicio.Visible = true;
        }
        public void Salir()
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de salir?", "Por Más Vida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r==DialogResult.Yes)this.Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) { }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }
        private void lblFotos_Click(object sender, EventArgs e) { }

        private void btnSalirOficial_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void lblCed_Click(object sender, EventArgs e) { }

        private void txtCed_TextChanged(object sender, EventArgs e) { }
    }
}