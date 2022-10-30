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
        private Char rh;
        public String Grupo { get => grupo; set => grupo = value; }
        public Char Rh { get => rh; set => rh = value; }

    }
    public class Persona
    {

        private Sangre sangre;
        private String nombre;
        private String apellido;
        private DateTime f_Nac;
        private String cedula;
        private double peso;

        public Persona(Sangre sangre, string nombre, string apellido, DateTime f_Nac, string cedula, double peso)
        {
            this.sangre = sangre;
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

    }
    public class Donante : Persona
    {
        private String cen_Donacion;
        private String id_Donante;

        public Donante(string cen_Donacion, string id_Donante, Sangre sangre, string nombre, string apellido, DateTime f_Nac, string cedula, double peso) : base(sangre, nombre, apellido, f_Nac, cedula, peso)
        {
            this.cen_Donacion = cen_Donacion;
            this.id_Donante=id_Donante;
        }

        public String Cen_Donacion { get => cen_Donacion; set => cen_Donacion = value; }
        public String Id_Donante { get => id_Donante; set => id_Donante = value; }
    }
}