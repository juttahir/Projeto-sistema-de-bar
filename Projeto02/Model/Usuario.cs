namespace Projeto02.Model
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cargo { get; set; }
        protected decimal Salario { get; set; }
    }
}