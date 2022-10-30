namespace ElProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static bool ProgressBar()
        {
            bool si = false;
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
                    bool s=ProgressBar();
                    if(s)
                    { label1.Text = "Hola"; }

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
    }
}