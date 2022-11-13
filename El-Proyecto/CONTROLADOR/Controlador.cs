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
            dgvDatos.Rows.Add(donante.Nombre, donante.Apellido, donante.Cedula, donante.F_Nac, donante.Sexo,donante.Peso, sangre.Rh, sangre.Grupo,donante.Cen_Donacion);
        }
        public void agregarDatos(TextBox nombre, TextBox apellido, MaskedTextBox cedula,DateTimePicker fecha ,RadioButton femenino, RadioButton masculino, MaskedTextBox peso, ComboBox RH, ComboBox grupoSanguineo, TextBox centroDonacion, DataGridView dgvDatos)
        {

            string name = nombre.Text;
            string subname = apellido.Text;
            string cedul4 = cedula.Text;
            double pes0 = Convert.ToDouble(peso.Text);
            string fech4 = fecha.Text;
            char genero='o';
            string rh = RH.Text;
            string centro = centroDonacion.Text;
            string grupoSangre = grupoSanguineo.Text;
            donante.Nombre = name;
            donante.Apellido = subname;
            donante.Cedula = cedul4;
            donante.Peso = pes0;
            donante.F_Nac =Convert.ToDateTime(fech4);
            if (femenino.Checked)
            {
                genero = 'F';
            }
            else if (masculino.Checked)
            {
                genero = 'M';
            }
            donante.Sexo = genero;
            sangre.Rh = rh;
            donante.Cen_Donacion = centro;
            sangre.Grupo = grupoSangre;
            verDatos(dgvDatos);
            MessageBox.Show("Contacto Agregado");
        }
    }
}