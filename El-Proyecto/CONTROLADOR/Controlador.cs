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
        public void agregarDatos(TextBox nombre, TextBox apellido, TextBox cedula,DateTimePicker fecha ,RadioButton femenino, RadioButton masculino, TextBox peso, ComboBox RH, ComboBox grupoSanguineo, TextBox centroDonacion, DataGridView dgvDatos)
        {

            string name = nombre.Text;
            string subname = apellido.Text;
            string cedul4 = cedula.Text;
            string pes0 = peso.Text;
            string fech4 = fecha.Text;
            char genero='o';
            string rh = RH.Text;
            string centro = centroDonacion.Text;
            string grupoSangre = grupoSanguineo.Text;
            donante.Nombre = name;
            donante.Apellido = subname;
            donante.Cedula = cedul4;
            donante.Peso = double.Parse(pes0);
            donante.F_Nac =Convert.ToDateTime(fech4);
            if (femenino.Checked)
            {
                genero = 'F';
            }
            else if (masculino.Checked)
            {
                genero = 'M';
            }
            MessageBox.Show("Contacto Agregado");
            donante.Sexo = genero;
            sangre.Rh = rh;
            donante.Cen_Donacion = centro;
            sangre.Grupo = grupoSangre;
            verDatos(dgvDatos);
        }
    }
}