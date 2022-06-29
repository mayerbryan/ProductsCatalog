namespace ProductsCatalog.Entities
{
    public class Entity
    {
        public Entity()
        {
            GUID = Guid.NewGuid();
        }
        public Guid GUID { get; private set; }
    }
}
