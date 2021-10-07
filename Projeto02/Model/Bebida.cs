using System;

namespace Projeto02.Model
{
    public class Bebida
    { 
        public int BebidaId { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public string Nome { get; set; }
        public string Observacao { get; set; }
        public DateTime Data { get; set; }
        public int UsuarioCadastroId { get; set; }
        public Usuario UsuarioCadastro { get; set; }
        public int? UsuarioAlteracaoId { get; set; }
        public Usuario UsuarioAlteracao { get; set; }
        public bool Status { get; set; }
    }
}

