namespace GTY.Models
{
    public class OxePessoasModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CidadeId { get; set; } // Chave estrangeira
        public string Observacao { get; set; }

        // Propriedade de navegação
        public OxeCidadesModel Cidade { get; set; }
    }
}
