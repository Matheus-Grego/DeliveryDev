namespace Delivery.Core.Entities;

public class CostumerAddress : BaseEntity
{
    public CostumerAddress(Guid costumerId, string address1, string? address2, string city, string state, string zip, string country, string district) : base()
    {
        CostumerId = costumerId;
        Address1 = address1;
        Address2 = address2;
        City = city;
        State = state;
        Zip = zip;
        Country = country;
        District = district;
    }

    public Guid CostumerId { get; private set; }
    public string Address1 { get; private set; }
    public string? Address2 { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Zip { get; private set; }
    public string Country { get; private set; }
    public string District { get; private set; }
}