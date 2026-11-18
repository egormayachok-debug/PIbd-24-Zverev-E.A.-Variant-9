
internal class SellerRepository : ISellerRepository
{
    public void CreateSeller(Seller seller) { }
    public void DeleteSeller(int id) { }

    public Seller ReadSellerById(int id)
    {
        return Seller.CreateEntity(0, string.Empty, string.Empty, SellerPost.None);
    }

    public IEnumerable<Seller> ReadSellers()
    {
        return [];
    }

    public void UpdateSeller(Seller seller) { }
}