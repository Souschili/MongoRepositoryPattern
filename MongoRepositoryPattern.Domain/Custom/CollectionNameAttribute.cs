namespace MongoRepositoryPattern.Domain.Custom
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class CollectionNameAttribute : Attribute
    {
        public string Name { get; private set; } = string.Empty;

        public CollectionNameAttribute(string name)
        {
            this.Name = name;
        }

    }
}
