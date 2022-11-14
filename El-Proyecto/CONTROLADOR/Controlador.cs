using MODELO;
using System.Collections;
using System.Windows.Forms;
namespace CONTROLADOR
{
    public class Contrl
    {
        static int idContador = 0, k=0;
        Donante donante=new Donante();
        Sangre sangre=new Sangre();
        baseDeDatos datosBase = new baseDeDatos();
        public void verDatos(DataGridView dgvDatos)
        {
            dgvDatos.Rows.Add(donante.Id_Donante, donante.Nombre, donante.Apellido, donante.Cedula, donante.F_Nac, donante.Sexo,donante.Peso, sangre.Grupo, sangre.Rh, donante.Cen_Donacion);
        }
        public void agregarDatos(Label ids, TextBox nombre, TextBox apellido, MaskedTextBox cedula,DateTimePicker fecha ,RadioButton femenino, RadioButton masculino, MaskedTextBox peso, ComboBox RH, ComboBox grupoSanguineo, TextBox centroDonacion, DataGridView dgvDatos, DataGridView dgvSangre)
        {
            string id = ids.Text;
            string name = nombre.Text;
            string subname = apellido.Text;
            string cedul4 = cedula.Text;
            double pes0 = Convert.ToDouble(peso.Text);
            string fech4 = fecha.Text;
            char genero='o';
            string rh = RH.Text;
            string centro = centroDonacion.Text;
            string grupoSangre = grupoSanguineo.Text;
            if (femenino.Checked)
            {
                genero = 'F';
            }
            else if (masculino.Checked)
            {
                genero = 'M';
            }
            donante.Id_Donante = id;
            donante.Nombre = name;
            donante.Apellido = subname;
            donante.Cedula = cedul4;
            donante.Peso = pes0;
            donante.F_Nac =Convert.ToDateTime(fech4);
            donante.Sexo = genero;
            sangre.Rh = rh;
            donante.Cen_Donacion = centro;
            sangre.Grupo = grupoSangre;
            datosBase.AddContact(donante);
            verDatos(dgvDatos);
            VerGrupoSanguineo(dgvSangre);
            MessageBox.Show("Contacto Agregado");
        }
        public void VerGrupoSanguineo(DataGridView dgvDatos) 
        {
            dgvDatos.Rows.Add(donante.Nombre, donante.Apellido, sangre.Grupo, sangre.Rh);

        }
        public void VerEnTextBox(TextBox ids, TextBox nombre, TextBox apellido, MaskedTextBox cedula, DateTimePicker fecha, RadioButton femenino, RadioButton masculino, MaskedTextBox peso, ComboBox RH, ComboBox grupoSanguineo, TextBox centroDonacion)
        {
            int o;
            int u = datosBase.Buscar(ids.Text);
            Donante k = datosBase.BaseDeDatosDonante[u];
            Sangre s = k.Sangre;
            ids.Text = k.Id_Donante;
            nombre.Text = k.Nombre;
            apellido.Text = k.Apellido;
            cedula.Text = k.Cedula;
            peso.Text = k.Peso.ToString();
            fecha.Value = k.F_Nac;
            if (s.Rh.ToString() == "+")
            {
                RH.SelectedIndex = 0;
            }
            else if (s.Rh.ToString() == "-") 
            {
                RH.SelectedIndex = 1;
            }
            //-----------------------------------------
            if (s.Grupo.ToString() == "O")
            {
                grupoSanguineo.SelectedIndex = 0;
            }
            else if (s.Rh.ToString() == "AB")
            {
                grupoSanguineo.SelectedIndex = 1;
            }
            else if (s.Rh.ToString() == "A")
            {
                grupoSanguineo.SelectedIndex = 2;
            }
            else if (s.Rh.ToString() == "B")
            {
                grupoSanguineo.SelectedIndex = 3;
            }
            centroDonacion.Text = k.Cen_Donacion;
            if (k.Sexo == 'F')
            {
                femenino.Checked = true;
            }
            else if (k.Sexo == 'F')
            {
                masculino.Checked = true;
            }
        }
        public void Modificar(TextBox ids, TextBox nombre, TextBox apellido, MaskedTextBox cedula, DateTimePicker fecha, RadioButton femenino, RadioButton masculino, MaskedTextBox peso, ComboBox RH, ComboBox grupoSanguineo, TextBox centroDonacion, DataGridView dgvDatos, DataGridView dgvSangre) 
        {
            int u = datosBase.Buscar(ids.Text);
            dgvDatos.Rows.RemoveAt(u);
            string id = ids.Text;
            string name = nombre.Text;
            string subname = apellido.Text;
            string cedul4 = cedula.Text;
            double pes0 = Convert.ToDouble(peso.Text);
            DateTime fech4 = fecha.Value;
            char genero = 'o';
            string rh = RH.Text;
            string centro = centroDonacion.Text;
            string grupoSangre = grupoSanguineo.Text;
            if (femenino.Checked)
            {
                genero = 'F';
            }
            else if (masculino.Checked)
            {
                genero = 'M';
            }
            Donante de=new Donante();
            de.Id_Donante = id;
            de.Nombre = name;
            de.Apellido = subname;
            de.Cedula = cedul4;
            de.Peso = pes0;
            de.F_Nac = Convert.ToDateTime(fech4);
            de.Sexo = genero;
            de.Sangre.Rh = rh;
            de.Cen_Donacion = centro;
            de.Sangre.Grupo = grupoSangre;
            datosBase.Modificar(id,name, subname,cedul4,fech4,genero,pes0,grupoSangre,rh,centro);
            dgvDatos.Rows.Insert(u, de);
            dgvSangre.Rows.Insert(u, de);
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