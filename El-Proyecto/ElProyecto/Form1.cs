namespace ElProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch ((tvLista.SelectedNode.Text))
            {
                case "Inicio":
                    ProgressBar();
                    break;
                case "Informacion":
                    break;
                case "AgregarDonante":
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
        public static void ProgressBar()
        {
            Progreso prog = new Progreso();
            prog.ShowDialog();
        }
    }
}