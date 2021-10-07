using System;

namespace Projeto02.Model
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public int UsuarioCadastroId { get; set; }
        public Usuario UsuarioCadastro { get; set; }
        public int? UsuarioAlteracaoId { get; set; }
        public Usuario UsuarioAlteracao { get; set; }
        public bool Status { get; set; }
    }
}
