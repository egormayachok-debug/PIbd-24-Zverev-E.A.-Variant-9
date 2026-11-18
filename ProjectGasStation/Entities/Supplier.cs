public class Supplier
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Address { get; private set; } = string.Empty;

    public static Supplier CreateEntity(int id, string name, string address)
    {
        return new Supplier
        {
            Id = id,
            Name = name ?? string.Empty,
            Address = address ?? string.Empty
        };
    }
}