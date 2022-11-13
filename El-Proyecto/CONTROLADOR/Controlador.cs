using MODELO;
using System.Windows.Forms;
namespace CONTROLADOR
{
    public class Contrl
    {
        Donante donante=new Donante();
        Sangre sangre=new Sangre();
        baseDeDatos datosBase = new baseDeDatos();
        public void verDatos(DataGridView dgvDatos)
        {
            dgvDatos.Rows.Add(donante.Apellido, donante.Nombre, donante.Sexo, donante.F_Nac, donante.Peso,sangre.Grupo, sangre.Rh);
        }
        public void SaveContact(TextBox nombre, TextBox apellido, TextBox cedula,DateTimePicker fecha ,RadioButton femenino, RadioButton masculino, TextBox peso, ComboBox RH, ComboBox grupoSanguineo, TextBox centroDonacion, DataGridView dgvDatos)
        {

            string name = nombre.Text;
            string subname = apellido.Text;
            string cedul4 = cedula.Text;
            string pes0 = peso.Text;
            string fech4 = fecha.Text;
            string genero = null;
            string rh = RH.Text;
            string centro = centroDonacion.Text;
            string grupoSangre = grupoSanguineo.Text;
            if (femenino.Checked)
            {
                genero = "femenino";
            }
            else if (masculino.Checked)
            {
                genero = "masculino";
            }
            verDatos(dgvDatos);
            MessageBox.Show("Contacto Agregado");
        }
    }
}