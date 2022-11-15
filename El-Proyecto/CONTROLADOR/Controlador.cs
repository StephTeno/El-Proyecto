using MODELO;
using System.Collections;
using System.Windows.Forms;
namespace CONTROLADOR
{
    public class Contrl
    {
         int contador = 0;
        List<string> listaNombres = new List<string>();
        List<string> listaApellidos = new List<string>();
        List<string> ids = new List<string>();
        List<string> gruposSanguineos = new List<string>();
        List<string> rhs = new List<string>();
        List<string> centrosDeDonación = new List<string>();
       List<double> pesos = new List<double>();
        static int idContador = 0, k=0;
        Donante donante=new Donante();
        Sangre sangre=new Sangre();
        baseDeDatos datosBase = new baseDeDatos();
        public void verDatos(DataGridView dgvDatos)
        {
            dgvDatos.Rows.Add(donante.Id_Donante, donante.Nombre, donante.Apellido, donante.Cedula, donante.F_Nac, donante.Sexo,donante.Peso, donante.Sangre.Grupo, donante.Sangre.Rh, donante.Cen_Donacion);
        }
        public void agregarDatos(Label ids, TextBox nombre, TextBox apellido, MaskedTextBox cedula,DateTimePicker fecha ,RadioButton femenino, RadioButton masculino, MaskedTextBox peso, ComboBox RH, ComboBox grupoSanguineo, TextBox centroDonacion, DataGridView dgvDatos, DataGridView dgvSangre, List<string> nombres, List<string> apelludos, List<string> idsuskas, List<string> grupoSangritas, List<string> rhs, List<string> centrosDeDonaciao, List<double> pesitas)
        {
            contador++;
            string id = ids.Text;
            string name = nombre.Text;
            string subname = apellido.Text;
            string cedul4 = cedula.Text;
            double pes0 = Convert.ToDouble(peso.Text);
            string fech4 = fecha.Text;
            string rh = RH.Text.ToString();
            string centro = centroDonacion.Text;
            string grupoSangre = grupoSanguineo.Text;
            char genero = 'o';
            if (femenino.Checked)
            {
                genero = 'F';
            }
            else if (masculino.Checked)
            {
                genero = 'M';
            }
            nombres.Add(name);
            apelludos.Add(subname);
            idsuskas.Add(id);
            grupoSangritas.Add( grupoSangre); 
            rhs.Add(rh);
            centrosDeDonaciao.Add(centro);
            pesitas.Add(pes0);
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
            donante.Sangre=sangre;
            datosBase.AddContact(donante);
            verDatos(dgvDatos);
            VerGrupoSanguineo(dgvSangre);

            MessageBox.Show("Donante Agregado");
        }
        public void VerGrupoSanguineo(DataGridView dgvDatos) 
        {
            dgvDatos.Rows.Add(donante.Nombre, donante.Apellido, sangre.Grupo, sangre.Rh);

        }
        public void VerEnTextBox( TextBox ids, TextBox nombre, TextBox apellido, MaskedTextBox cedula, DateTimePicker fecha, RadioButton femenino, RadioButton masculino, MaskedTextBox peso, ComboBox RH, ComboBox grupoSanguineo, TextBox centroDonacion)
        {
            int u = datosBase.Buscar(ids.Text);
            Donante k = datosBase.buscarDatosDonante(ids.Text);
            ids.Text = k.Id_Donante;
            nombre.Text = k.Nombre;
            apellido.Text = k.Apellido;
            cedula.Text = k.Cedula;
            peso.Text = k.Peso.ToString();
            fecha.Value = k.F_Nac;
            RH.Text = k.Sangre.Rh.ToString();
            grupoSanguineo.Text=k.Sangre.Grupo.ToString();
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
            string rh = RH.Text.ToString();
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
            Sangre sa=new Sangre(); 
            de.Id_Donante = id;
            de.Nombre = name;
            de.Apellido = subname;
            de.Cedula = cedul4;
            de.Peso = pes0;
            de.F_Nac = Convert.ToDateTime(fech4);
            de.Sexo = genero;
            sa.Rh = rh;
            de.Cen_Donacion = centro;
            sa.Grupo = grupoSangre;
            de.Sangre=sa;
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