
public interface IFuelSupplyRepository
{
    IEnumerable<FuelSupply> ReadFuelSupplies(DateTime? dateFrom = null, DateTime? dateTo = null, int? supplierId = null);
    void CreateFuelSupply(FuelSupply fuelSupply);
    void DeleteFuelSupply(int id);
}