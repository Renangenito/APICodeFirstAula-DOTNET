using System.ComponentModel.DataAnnotations;

namespace APICodeFirstAula.Context
{
    public class Filme
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 15, ErrorMessage = "Deve ter no mínimo 15 e no máximo 100.")]
        public string Nome { get; set; }

        [StringLength(100)]
        public string Genero { get; set; }
        public decimal Tempo { get; set; }
        public DateTime DataLancamento { get; set; }

        [StringLength(1000)]
        public string Sinopse { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
