using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElProyecto
{
    public partial class Progreso : Form
    {
        public Progreso()
        {
            InitializeComponent();
            tmPrueba.Enabled = true;
            pbProgreso.Value = 0;
        }

        private void Progreso_Load(object sender, EventArgs e) { }
        private void btnContinuar_Click(object sender, EventArgs e) { this.Close(); }
        private void tmPrueba_Tick(object sender, EventArgs e)
        {
            btnContinuar.Visible = false;
            lblProgreso.Text = pbProgreso.Value.ToString() + "%";
            if (pbProgreso.Value < 100)
                pbProgreso.Value++;
            else if (pbProgreso.Value == 100)
            {
                tmPrueba.Enabled = false;
                btnContinuar.Visible = true;
            }
        }
    }
}
