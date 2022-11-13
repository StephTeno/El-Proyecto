using MODELO;
using System.Windows.Forms;
namespace CONTROLADOR
{
    public class Contrl
    {
        static int idContador = 0;
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
        //PARA REALIZAR BUSQUEDA...
//        public void buscarDonante(TextBox Nom, Label nombrecito, Label prod, Label ubi, Label cUni, Label cantP, Label total, Label fecha, Label email, Label idVenta, ErrorProvider error)
//        {
//            //bool w = VerificarCamposLlenosBusqueda(Nom, error);
//            //if (w)
//            //{

//            List<Donante> m = datosBase.BaseDeDatosDonante;
//            List<Sangre> n = datosBase.BaseDeDatosSangre;

//            //BorrarErrorBusqueda(Nom, error);
//            string nom = Nom.Text;
//            Donante donador = datosBase.buscarDatosDonante(nom, m);
//            Sangre sangriento = RetornarDatosDonante(clientico.IdCliente, m, n);
//            nombrecito.Text = clientico.Nombre;
//            prod.Text = Convert.ToString(ventas.NombreProducto);
//            ubi.Text = Convert.ToString(clientico.Direccion);
//            cUni.Text = Convert.ToString(ventas.CostU1);
//            cantP.Text = Convert.ToString(ventas.Cantidad);
//            total.Text = Convert.ToString(ventas.Total);
//            fecha.Text = Convert.ToString(ventas.Fecha);
//            email.Text = Convert.ToString(clientico.Email);
//            idVenta.Text = Convert.ToString(ventas.IdVentas1);
//        }
//            else { MessageBox.Show("Ingrese una ID valida"); }
//}
//        public Sangre RetornarDatosDonante(string idCliente, List<Donante> a, List<Sangre> b)
//        {
//            Donante idC1 = new Donante();
//            idC1 = datosBase.buscarDatosDonante(idCliente, a);
//            var ventas = from v in b where v.Grupo == idCliente select v;

//            ventas.First();
//            return ventas.First();
//        }
    }
}