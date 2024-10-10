using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstBasic.Entities
{
    [Table("Games")]
    public class GameEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Platform  { get; set; }
        public decimal Rating { get; set; }
    }
}
