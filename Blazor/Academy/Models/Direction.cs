using Academy.Models.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Academy.Models 
{
    public class Direction 
    {
        [Key]//показывает, что поле ниже является ключ
        public byte direction_id { get; set; }
        [Required]
        [UniqueDirectionName(ErrorMessage="Такое направление уже существует")]
        public string direction_name { get; set; }
        
        
        
    }
}
