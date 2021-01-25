namespace Infrastructure.Records
{
    public class CollectionNameAttribute : System.Attribute
    {
        public string Name { get; }

        public CollectionNameAttribute(string name)
        {
            Name = name;
        }
    }
}