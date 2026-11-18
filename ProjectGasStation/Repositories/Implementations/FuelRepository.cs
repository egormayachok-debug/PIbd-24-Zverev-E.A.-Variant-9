
internal class FuelRepository : IFuelRepository
{
    public void CreateFuel(Fuel fuel) { }
    public void DeleteFuel(int id) { }

    public Fuel ReadFuelById(int id)
    {
        return Fuel.CreateEntity(0, FuelType.None, string.Empty, 0, string.Empty);
    }

    public IEnumerable<Fuel> ReadFuels()
    {
        return [];
    }

    public void UpdateFuel(Fuel fuel) { }
}