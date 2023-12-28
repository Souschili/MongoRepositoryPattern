namespace MongoRepositoryPattern.Domain.Custom
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class CollectionNameAttribute:Attribute
    {
        public string Name { get; set; }=string.Empty;

        public CollectionNameAttribute(string name)
        {
            this.Name = name;
        }

    }
}
