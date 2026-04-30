using Delivery.Core.Enums;

namespace Delivery.Core.Entities;

public class DeliveryPerson : BaseEntity
{
    public DeliveryPerson(string name, string email, string phone, DateTime dateOfBirth, string address, DeliveryPersonStatus status) : base()
    {
        Name = name;
        Email = email;
        Phone = phone;
        DateOfBirth = dateOfBirth;
        FullAddress = address;
        Status = DeliveryPersonStatus.Available;
    }

    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; } 
    public DateTime DateOfBirth { get; private set; }
    public string FullAddress { get; private set; } 
    public DeliveryPersonStatus Status { get; private set; }
}