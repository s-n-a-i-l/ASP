namespace TODOlist.Classes
{
    public class TODOitem : IComparable<TODOitem>
    {
        public string Title { get; set; }
        public bool DONE { get; set; }

        //public static bool operator ==(TODOitem left, TODOitem right)
        //{
        //    return left.Title == right.Title;
        //}
        //public static bool operator !=(TODOitem left, toTODOitemdoitem right)
        //{
        //    return left.Title != right.Title;
        //}
        public int CompareTo(TODOitem other)
        {
            return Title.CompareTo(other.Title);
        }
        public bool Equals(TODOitem left, TODOitem right)
        {
            return left.Title == right.Title;
        }
        public int GetHashCode(TODOitem other)
        {
            return HashCode.Combine(Title);
        }
    }
}
