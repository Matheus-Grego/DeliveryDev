namespace Delivery.Core.Entities;

public class Category : BaseEntity
{
    public Category(string description)
    {
        Description = description;
    }
    public string Description { get; set; }
}