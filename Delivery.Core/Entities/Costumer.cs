namespace Delivery.Core.Entities;

public class Costumer : BaseEntity
{
    public Costumer(string name, string email, string phone, DateTime dateOfBirth) : base()
    {
        Name = name;
        Email = email;
        Phone = phone;
        DateOfBirth = dateOfBirth;
    }

    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; } 
    public DateTime DateOfBirth { get; private set; }
    public List<CostumerAddress> Addresses { get; private set; }
}