using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace Academy2.Models
{
    public class Group
    {
        [Key]
        public int group_id { get; set; }
        [Required]
        public string group_name { get; set; }
        [Required]
        [Column(TypeName ="tinyint")]
        //[MinLength(1)]
        [ForeignKey(nameof(Direction))]
        [JsonIgnore]
        public int direction { get; set; }


        [Column(TypeName = "tinyint")]
        public int learning_days { get; set; }
        public TimeOnly start_time { get; set; }


        //[Required]
        public Direction? Direction {  get; set; }
    }
}
