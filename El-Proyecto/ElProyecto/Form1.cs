using CONTROLADOR;
namespace ElProyecto
{
    public partial class Form1 : Form
    {
        static int i, o;
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
            TreeNode node = tvLista.SelectedNode;
            switch (tvLista.SelectedNode.Text)
            {
                case "Inicio":
                    Inicio();
                    break;
                case "Información":
                    break;
                case "Registrar Donante":
                    if(ProgressBar())
                    {
                        RegistrarDonante();
                    }
                    break;
                case "Modificar Datos":
                    if (ProgressBar())
                    {
                        ModificarDonantes();
                    }
                    break;
                case "Consultar Donante":
                    if (ProgressBar())
                    {
                        ConsultarDonantes();
                    }
                    break;
                case "Donantes":
                    if (ProgressBar())
                    {
                        VerTodosLosDonantes();
                    }
                    break;
                case "Grupo Sanguineo":
                    if (ProgressBar())
                    {
                        VerLosDonantesGrupo();
                    }
                    break;
            }
        }
        private void tmrFotos_Tick(object sender, EventArgs e){i++;if (i > 5) { i = 0; }lblFotos.ImageIndex = i;}
        public void Inicio()
        {
            plInicio.Visible = true;
            plRegistrarDonante.Visible = false;
            plModificarDatos.Visible = false;
            plConsultarDonante.Visible = false;
            plVerDonantes.Visible = false;
            plVerGrupoSanguineo.Visible = false;
        }
        public void QuienesSomos()
        {
            plInicio.Visible = false;
            plRegistrarDonante.Visible = false;
            plModificarDatos.Visible = false;
            plConsultarDonante.Visible = false;
            plVerDonantes.Visible = false;
            plVerGrupoSanguineo.Visible = false;
        }
        public void RegistrarDonante()
        {
            plInicio.Visible = false;
            plRegistrarDonante.Visible = true;
            plModificarDatos.Visible = false;
            plConsultarDonante.Visible = false;
            plVerDonantes.Visible = false;
            plVerGrupoSanguineo.Visible = false;
            plRegistrarDonante.Size = new Size(592,370);
            plRegistrarDonante.Location= new Point(170, 38);

        }
        public void ModificarDonantes()
        {
            plInicio.Visible = false;
            plRegistrarDonante.Visible = false;
            plModificarDatos.Visible = true;
            plConsultarDonante.Visible = false;
            plVerDonantes.Visible = false;
            plVerGrupoSanguineo.Visible = false;
            plModificarDatos.Size = new Size(592, 370);
            plModificarDatos.Location = new Point(170, 38);
        }
        public void ConsultarDonantes()
        {
            plInicio.Visible = false;
            plRegistrarDonante.Visible = false;
            plModificarDatos.Visible = false;
            plConsultarDonante.Visible = true;
            plVerDonantes.Visible = false;
            plVerGrupoSanguineo.Visible = false;
            plConsultarDonante.Size = new Size(592, 370);
            plConsultarDonante.Location = new Point(170, 38);
        }
        public void VerTodosLosDonantes()
        {
            plInicio.Visible = false;
            plRegistrarDonante.Visible = false;
            plModificarDatos.Visible = false;
            plConsultarDonante.Visible = false;
            plVerDonantes.Visible = true;
            plVerGrupoSanguineo.Visible = false;
            plVerDonantes.Size = new Size(592, 370);
            plVerDonantes.Location = new Point(170, 38);
        }
        public void VerLosDonantesGrupo()
        {
            plInicio.Visible = false;
            plRegistrarDonante.Visible = false;
            plModificarDatos.Visible = false;
            plConsultarDonante.Visible = false;
            plVerDonantes.Visible = false;
            plVerGrupoSanguineo.Visible=true;
            plVerGrupoSanguineo.Size = new Size(592, 370);
            plVerGrupoSanguineo.Location = new Point(170, 38);
        }
        public void Salir()
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de salir?", "Por Más Vida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r==DialogResult.Yes)this.Close();
        }
        private void btnSalirOficial_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void lblCed_Click(object sender, EventArgs e) { }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) { }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }
        private void lblFotos_Click(object sender, EventArgs e) { }
        private void txtCed_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e){lbl_Id.Text = GeneraNumero();}
        private void tpPrincipal_Click(object sender, EventArgs e) { }

        private void plModificarDatos_Paint(object sender, PaintEventArgs e) { }
        Func<string> GeneraNumero = () => { o++; return o.ToString("000-000"); };
    }
}