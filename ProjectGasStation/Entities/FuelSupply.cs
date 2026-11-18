public class FuelSupply
{
    public int Id { get; private set; }
    public int SupplierId { get; private set; }
    public DateTime DateReceipt { get; private set; }
    public IEnumerable<FuelSupplyItem> FuelSupplyItems { get; private set; } = [];

    public static FuelSupply CreateOperation(int id, int supplierId, IEnumerable<FuelSupplyItem> items)
    {
        return new FuelSupply
        {
            Id = id,
            SupplierId = supplierId,
            DateReceipt = DateTime.Now,
            FuelSupplyItems = items
        };
    }
}