namespace MongoRepositoryPattern.Domain.Custom
{
    internal class CollectionNameAttribute:Attribute
    {
        public string Name { get; set; }=string.Empty;

        public CollectionNameAttribute(string name)
        {
            this.Name = name;
        }

    }
}
