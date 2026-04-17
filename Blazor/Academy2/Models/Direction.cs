using Academy.Models.ValidationAttributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy2.Models
{
    public class Direction
    {
        [Key]
        [Column(TypeName ="tinyint")]
        public int direction_id { get; set; }
        [UniqueDirectionName(ErrorMessage = "Такое направление уже существует")]
        public string direction_name { get; set; }
    }
}
