namespace ProductsCatalog.Entities
{
    public class User : Entity
    {
        public User(int id, bool active)
        {
            Id = id;
            Active = active;
        }

        public int Id { get; private set; }
        public bool Active { get; private set; }
    }
}
