public class Fuel
{
    public int Id { get; private set; }
    public FuelType FuelType { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public decimal Price { get; private set; }
    public string Description { get; private set; } = string.Empty;

    public static Fuel CreateEntity(int id, FuelType fuelType, string name, decimal price, string description)
    {
        return new Fuel
        {
            Id = id,
            FuelType = fuelType,
            Name = name ?? string.Empty,
            Price = price,
            Description = description ?? string.Empty
        };
    }
}