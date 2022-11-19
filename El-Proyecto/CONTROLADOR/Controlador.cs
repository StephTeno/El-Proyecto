using MODELO;
using System.Collections;
using System.Windows.Forms;
namespace CONTROLADOR
{
    public class Contrl
    {
        int contador = 0;
        //Varias listas para poder hacer busqueda de datos individualmente
        List<string> listaNombres = new List<string>();
        List<string> listaApellidos = new List<string>();
        List<string> ids = new List<string>();
        List<string> gruposSanguineos = new List<string>();
        List<string> rhs = new List<string>();
        List<string> centrosDeDonación = new List<string>();
        List<double> pesos = new List<double>();
        static int idContador = 0, k = 0;
        Donante donante = new Donante();
        Sangre sangre = new Sangre();
        baseDeDatos datosBase = new baseDeDatos();
        //Funcion para poder ver los datos en la Data Grid View
        public void verDatos(DataGridView dgvDatos)
        {
            dgvDatos.Rows.Add(donante.Id_Donante, donante.Nombre, donante.Apellido, donante.Cedula, donante.F_Nac, donante.Sexo, donante.Peso, donante.Sangre.Grupo, donante.Sangre.Rh, donante.Cen_Donacion);
        }
        //Funcion para agregar datos a la Data Grid View
        public void agregarDatos(Label ids, TextBox nombre, TextBox apellido, MaskedTextBox cedula, DateTimePicker fecha, RadioButton femenino, RadioButton masculino, MaskedTextBox peso, ComboBox RH, ComboBox grupoSanguineo, TextBox centroDonacion, DataGridView dgvDatos, DataGridView dgvSangre, List<string> nombres, List<string> apelludos, List<string> idsuskas, List<string> grupoSangritas, List<string> rhs, List<string> centrosDeDonaciao, List<double> pesitas)
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
            grupoSangritas.Add(grupoSangre);
            rhs.Add(rh);
            centrosDeDonaciao.Add(centro);
            pesitas.Add(pes0);
            donante.Id_Donante = id;
            donante.Nombre = name;
            donante.Apellido = subname;
            donante.Cedula = cedul4;
            donante.Peso = pes0;
            donante.F_Nac = Convert.ToDateTime(fech4);
            donante.Sexo = genero;
            sangre.Rh = rh;
            donante.Cen_Donacion = centro;
            sangre.Grupo = grupoSangre;
            donante.Sangre = sangre;
            datosBase.AddContact(donante);
            verDatos(dgvDatos);
            VerGrupoSanguineo(dgvSangre);

            MessageBox.Show("Donante Agregado");
        }
       
        //Funcion para agregar datos a la data grid view de los grupos sanguineo
        public void VerGrupoSanguineo(DataGridView dgvDatos)
        {
            dgvDatos.Rows.Add(donante.Nombre, donante.Apellido, sangre.Grupo, sangre.Rh);

        }
        public void modificarDatos(Label ids, TextBox idBuscando, TextBox nombre, TextBox apellido, MaskedTextBox cedula, DateTimePicker fecha, RadioButton femenino, RadioButton masculino, MaskedTextBox peso, ComboBox RH, ComboBox grupoSanguineo, TextBox centroDonacion, DataGridView dgvDatos, DataGridView dgvSangre, DataGridView modificar)
        {
            int buscardor = datosBase.Buscar(idBuscando.Text);

        }
        //Funcion que le permite modificar los datos al usuario
        public void RemoverContacto(int i, DataGridView dgvDatosDatitos, DataGridView dgvDatosSangrita, List<string> nombres, List<string> apelludos, List<string> idsuskas, List<string> grupoSangritas, List<string> rhs, List<string> centrosDeDonaciao, List<double> pesitas, ImageList imageList)
        {
            imageList.Images.RemoveAt(i);
            nombres.RemoveAt(i); apelludos.RemoveAt(i); idsuskas.RemoveAt(i); grupoSangritas.RemoveAt(i); rhs.RemoveAt(i);centrosDeDonaciao.RemoveAt(i); pesitas.RemoveAt(i);
            dgvDatosDatitos.Rows.RemoveAt(i);
            datosBase.RemoverContacto(i);
            MessageBox.Show("Donante Eliminado");
        }
        public void VerEnTextBox( TextBox ids, TextBox nombre, TextBox apellido, MaskedTextBox cedula, DateTimePicker fecha, RadioButton femenino, RadioButton masculino, MaskedTextBox peso, ComboBox RH, ComboBox grupoSanguineo, TextBox centroDonacion)
        {
            //int u = datosBase.Buscar(ids.Text);
            //Donante k = datosBase.buscarDatosDonante(ids.Text);
            //ids.Text = k.Id_Donante;
            //idBuscar.Text = k.Nombre;
            //apellido.Text = k.Apellido;
            //cedula.Text = k.Cedula;
            //peso.Text = k.Peso.ToString();
            //fecha.Value = k.F_Nac;
            //RH.Text = k.Sangre.Rh.ToString();
            //grupoSanguineo.Text=k.Sangre.Grupo.ToString();
            //centroDonacion.Text = k.Cen_Donacion;
            //if (k.Sexo == 'F')
            //{
            //    femenino.Checked = true;
            //}
            //else if (k.Sexo == 'F')
            //{
            //    masculino.Checked = true;
            //}
        }
        //public void Modificar(TextBox ids, TextBox idBuscar, TextBox apellido, MaskedTextBox cedula, DateTimePicker fecha, RadioButton femenino, RadioButton masculino, MaskedTextBox peso, ComboBox RH, ComboBox grupoSanguineo, TextBox centroDonacion, DataGridView dgvDatos, DataGridView dgvSangre) 
        //{
        //    int u = datosBase.Buscar(ids.Text);
        //    dgvDatos.Rows.RemoveAt(u);
        //    string id = ids.Text;
        //    string name = idBuscar.Text;
        //    string subname = apellido.Text;
        //    string cedul4 = cedula.Text;
        //    double pes0 = Convert.ToDouble(peso.Text);
        //    DateTime fech4 = fecha.Value;
        //    char genero = 'o';
        //    string rh = RH.Text.ToString();
        //    string centro = centroDonacion.Text;
        //    string grupoSangre = grupoSanguineo.Text;
        //    if (femenino.Checked)
        //    {
        //        genero = 'F';
        //    }
        //    else if (masculino.Checked)
        //    {
        //        genero = 'M';
        //    }
        //    Donante de=new Donante();
        //    Sangre sa=new Sangre(); 
        //    de.Id_Donante = id;
        //    de.Nombre = name;
        //    de.Apellido = subname;
        //    de.Cedula = cedul4;
        //    de.Peso = pes0;
        //    de.F_Nac = Convert.ToDateTime(fech4);
        //    de.Sexo = genero;
        //    sa.Rh = rh;
        //    de.Cen_Donacion = centro;
        //    sa.Grupo = grupoSangre;
        //    de.Sangre=sa;
        //    datosBase.Modificar(id,name, subname,cedul4,fech4,genero,pes0,grupoSangre,rh,centro);
        //    dgvDatos.Rows.Insert(u, de);
        //    dgvSangre.Rows.Insert(u, de);
        //}
        //PARA REALIZAR BUSQUEDA...
        //public void buscarDonante(TextBox idBuscar,TextBox nombre, TextBox apellido, MaskedTextBox cedula, DateTimePicker fecha, RadioButton femenino, RadioButton masculino, MaskedTextBox peso, ComboBox RH, ComboBox grupoSanguineo, TextBox centroDonacion, DataGridView dgvDatos)
        //{
        //    //bool w = VerificarCamposLlenosBusqueda(Nom, error);
        //    //if (w)
        //    //{
        //    int recibirDatos = Convert.ToInt32(idBuscar.Text) - 1;


        //    dgvDatos.Rows.RemoveAt(recibirDatos);
        //    List<Donante> m = datosBase.BaseDeDatosDonante;
        //    List<Sangre> n = datosBase.BaseDeDatosSangre;
        //    char genero = 'o';
        //    //BorrarErrorBusqueda(Nom, error);
        //    string nom = idBuscar.Text;
        //    Donante donador = datosBase.buscarDatosDonante(nom, m);
        //    Donante sangriento = RetornarDatosDonante(donador.Id_Donante, m, n);
        //    nombre.Text = donador.Nombre;
        //    RH.Text = Convert.ToString(sangriento.Rh);
        //    apellido.Text = Convert.ToString(donador.Apellido);
        //    grupoSanguineo.Text = Convert.ToString(sangriento.Grupo);
        //    centroDonacion.Text = Convert.ToString(donador.Cen_Donacion);
        //    cedula.Text = Convert.ToString(donador.Cedula);
        //    fecha.Text = Convert.ToString(donador.F_Nac);
        //    if (masculino.Checked)
        //    {
        //        genero = 'M';
        //        masculino.Text = "M";
        //    }
        //    else if (femenino.Checked)
        //    {
        //        genero = 'F';
        //        femenino.Text = "F";
        //    }
        //    peso.Text = Convert.ToString(donador.Peso);
        //    donante.Nombre = nombre.Text;
        //    donante.Apellido = apellido.Text;
        //    donante.Cedula = cedula.Text;
        //    donante.Peso = Convert.ToDouble(peso.Text);
        //    donante.F_Nac = Convert.ToDateTime(fecha);
        //    donante.Sexo = genero;
        //    sangre.Rh = RH.Text;
        //    donante.Cen_Donacion = centroDonacion.Text;
        //    sangre.Grupo = grupoSanguineo.Text;
        //    datosBase.AddContact(donante);
        //    verDatos(dgvDatos);
        //    //genero.Text = Convert.ToString(clientico.Email);


        //}
        //else { MessageBox.Show("Ingrese una ID valida"); }
        //public Donante RetornarDatosDonante(string idCliente, List<Donante> a, List<Sangre> b)
        //{
        //    Donante idC1 = new Donante();
        //    idC1 = datosBase.buscarDatosDonante(idCliente, a);
        //    var datitos = from v in a where v.Id_Donante == idCliente select v;

        //    datitos.First();
        //    return datitos.First();
        //}
        }
    }
