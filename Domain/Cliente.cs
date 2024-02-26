namespace Domain
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Sexo { get; set; }

    }
}
