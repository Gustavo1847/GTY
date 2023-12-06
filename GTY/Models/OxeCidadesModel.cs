namespace GTY.Models
{
    public class OxeCidadesModel
    {
        public int CidadeId { get; set; }
        public string NomeCidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        // Propriedade de navegação inversa
        public ICollection<OxePessoasModel> Pessoas { get; set; } = new List<OxePessoasModel>();
    }
}
