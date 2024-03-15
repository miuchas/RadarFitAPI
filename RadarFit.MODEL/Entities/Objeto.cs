using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RadarFit.MODEL.Entities
{
    public class Objeto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public required string Titulo { get; set; }
        public required string Descricao { get; set; }
    }
}
