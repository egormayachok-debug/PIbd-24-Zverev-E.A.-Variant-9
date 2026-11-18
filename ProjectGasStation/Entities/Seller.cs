public class Seller
{
    public int Id { get; private set; }
    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public SellerPost SellerPost { get; private set; }

    public static Seller CreateEntity(int id, string firstName, string lastName, SellerPost sellerPost)
    {
        return new Seller
        {
            Id = id,
            FirstName = firstName ?? string.Empty,
            LastName = lastName ?? string.Empty,
            SellerPost = sellerPost
        };
    }
}