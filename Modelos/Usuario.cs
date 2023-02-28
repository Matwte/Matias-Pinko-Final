namespace WebApplication4.Modelos
{
    public class Usuario
    {
        private long id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string password;
        private string mail;

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
