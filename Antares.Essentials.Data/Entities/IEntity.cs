namespace Antares.Essentials.Data.Entities
{
    public interface IEntity : IEntity<int>
    {
    }

    public interface IEntity<T>
    {
        T Id { get; set; }

        bool Equals(object obj);

        int GetHashCode();

        string ToString();
    }
}
