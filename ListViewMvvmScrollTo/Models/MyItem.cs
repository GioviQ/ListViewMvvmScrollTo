namespace ListViewMvvmScrollTo.Models
{
    public class MyItem
    {
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as MyItem);
        }

        public bool Equals(MyItem other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override string ToString()
        {
            return $"Item {Id}";
        }
    }
}
