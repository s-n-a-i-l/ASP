using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
    public class Direction
    {
        [Key]//показывает, что поле ниже является ключ
        public byte direction_id { get; set; }
        public string direction_name { get; set; }
    }
}
