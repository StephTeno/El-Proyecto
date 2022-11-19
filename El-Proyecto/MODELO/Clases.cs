namespace MODELO
{
    public static class don
    {
        public static bool PesoIdeal(this Donante a)
        {
            bool peso = false;
            if (a.Peso >= 100)
                return peso = true;
            else { return peso = false; }
        }
        public static bool EdadIdeal(this Donante a)
        {
            int edad = DateTime.Now.Year - a.F_Nac.Year;
            bool eda = false;
            if (edad >= 17 && edad <= 65)
                return eda = true;
            else { return eda = false; }
        }
    }
    public class Sangre
    {
        private String grupo;
        private string rh;

        public Sangre(string grupo, string rh)
        {
            this.grupo = grupo;
            this.rh = rh;
        }
        public Sangre() { }
        public String Grupo { get => grupo; set => grupo = value; }
        public String Rh { get => rh; set => rh = value; }

    }
    public class Persona
    {

        private Sangre sangre;
        private String nombre;
        private String apellido;
        private DateTime f_Nac;
        private String cedula;
        private double peso;
        private char sexo;

        public Persona(Sangre sangre, char sexo, string nombre, string apellido, DateTime f_Nac, string cedula, double peso)
        {
            this.sangre = sangre;
            this.sexo = sexo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.f_Nac = f_Nac;
            this.cedula = cedula;
            this.peso = peso;
        }
        public Persona() { }

        public Sangre Sangre { get => sangre; set => sangre = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public String Apellido { get => apellido; set => apellido = value; }
        public DateTime F_Nac { get => f_Nac; set => f_Nac = value; }
        public String Cedula { get => cedula; set => cedula = value; }
        public double Peso { get => peso; set => peso = value; }
        public char Sexo { get => sexo; set => sexo = value; }

    }
    public class Donante : Persona
    {
        private String cen_Donacion;
        private String id_Donante;

        public Donante(string cen_Donacion, string id_Donante, Sangre sangre, char sexo, string nombre, string apellido, DateTime f_Nac, string cedula, double peso) : base(sangre, sexo, nombre, apellido, f_Nac, cedula, peso)
        {
            this.cen_Donacion = cen_Donacion;
            this.id_Donante = id_Donante;
        }
        public Donante() : base()
        {
        }
        public String Cen_Donacion { get => cen_Donacion; set => cen_Donacion = value; }
        public String Id_Donante { get => id_Donante; set => id_Donante = value; }
    }
    public class baseDeDatos
    {
        static List<Donante> baseDeDatosDonante = new List<Donante>();
        static List<Sangre> baseDeDatosSangre = new List<Sangre>();

        public List<Donante> BaseDeDatosDonante { get => baseDeDatosDonante; set => baseDeDatosDonante = value; }
        public  List<Sangre> BaseDeDatosSangre { get => baseDeDatosSangre; set => baseDeDatosSangre = value; }

        public void AddContact(Donante dato)
        {
            baseDeDatosDonante.Add(dato);
        }
        public void añadirSangre(Sangre sangre)
        {
            baseDeDatosSangre.Add(sangre);
        }
        public void RemoverContacto(int i)
        {
            if (i != -1)
                baseDeDatosDonante.RemoveAt(i);
        }
        public Donante BuscarPosicion(string id) 
        {
            int o=-1;
            for (int i = 0; i < BaseDeDatosDonante.Count; i++)
            {
                if (BaseDeDatosDonante[i].Id_Donante == id)
                    o = i;
            }
            Donante k=BaseDeDatosDonante[o];
            return k;
        }
        public int Buscar(string id)
        {
            int o = -1;
            for (int i = 0; i < BaseDeDatosDonante.Count; i++)
            {
                if (BaseDeDatosDonante[i].Id_Donante == id)
                    o = i;
            }
            return o;
        }
        public void Modificar(string id, string nombre, string apellido, string cedula, DateTime f_Nac, char sexo, double peso, string grupo, string rh, string cen_Donacion) 
        {
            int pos = Buscar(id);
            BaseDeDatosDonante.RemoveAt(pos);
            Donante Nuevo=new Donante();
            Nuevo.Nombre = nombre;
            Nuevo.Apellido= apellido;
            Nuevo.Cedula= cedula;
            Nuevo.F_Nac= f_Nac;
            Nuevo.Sexo= sexo;
            Nuevo.Peso= peso;
            Nuevo.Sangre.Grupo= grupo;
            Nuevo.Sangre.Rh= rh;
            Nuevo.Cen_Donacion= cen_Donacion;
            BaseDeDatosDonante.Insert(pos,Nuevo);
        }

        public Donante buscarDatosDonante(string idDonante, List<Donante> a)
        {
            //Utilizamos linq para buscar algún donante
            var buscCliente = from e in a
                              where e.Id_Donante.Equals(idDonante)
                              select e;
            Donante pepe = buscCliente.First();
            return pepe;
        }
        
    }
}