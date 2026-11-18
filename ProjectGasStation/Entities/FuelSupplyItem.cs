public class FuelSupplyItem
{
    public int Id { get; private set; }
    public int FuelId { get; private set; }
    public int Count { get; private set; }
    public decimal PurchasePrice { get; private set; }

    public static FuelSupplyItem CreateElement(int id, int fuelId, int count, decimal purchasePrice)
    {
        return new FuelSupplyItem
        {
            Id = id,
            FuelId = fuelId,
            Count = count,
            PurchasePrice = purchasePrice
        };
    }
}