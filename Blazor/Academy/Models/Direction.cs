using System.ComponentModel.DataAnnotations;

namespace Academy.Models 
{
    public class Direction :  IEquatable<Direction>, IComparable<Direction>
    {
        [Key]//показывает, что поле ниже является ключ
        public byte direction_id { get; set; }
        [Required]
        public string direction_name { get; set; }
        //    public override bool Equals(object? other)
        //    {
        //        return this.direction_name.Equals((other as Direction).direction_name);
        //    }
        //    public override int GetHashCode()
        //    {
        //        return HashCode.Combine(direction_name);
        //    }
        
        public int CompareTo(Direction? other) // other не может быть null, поэтому "?" означает что параметр other может быть null
        {
            return other is null ? 1 : string.Compare(direction_name, other.direction_name);
        }
        public bool Equals(Direction? other)//как и тут  
        {
            if (other is null) return false;
            return string.Equals(direction_name, other.direction_name, StringComparison.OrdinalIgnoreCase);
        }
        public override bool Equals(object? obj) => Equals(obj as Direction);
        public override int GetHashCode()
        {
            return direction_name?.GetHashCode(StringComparison.OrdinalIgnoreCase) ?? 0;
        }
    }
}
