namespace TODOlist.Classes
{
    public class TODOitem : IEquatable<TODOitem>, IComparable<TODOitem>
    {
        public string Title { get; set; } = "";
        public bool DONE { get; set; }

        //public static bool operator ==(TODOitem left, TODOitem right)
        //{
        //    return left.Title == right.Title;
        //}
        //public static bool operator !=(TODOitem left, toTODOitemdoitem right)
        //{
        //    return left.Title != right.Title;
        //}
        public int CompareTo(TODOitem? other) // other не может быть null, поэтому "?" означает что параметр other может быть null
        {
            return other is null ? 1 : Title.CompareTo(other.Title);
        }
        public bool Equals(TODOitem? other)//как и тут  
        {
            return other != null && Title == other.Title;
        }
        public int GetHashCode(TODOitem other)
        {
            return HashCode.Combine(Title);
        }
    }
}
