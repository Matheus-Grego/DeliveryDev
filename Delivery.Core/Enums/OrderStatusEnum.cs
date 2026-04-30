namespace Delivery.Core.Enums;

public enum OrderStatusEnum
{
    Requested = 1,
    Accepted = 2,
    InPreparation = 3,
    ReadyForPickup = 4,
    InDelivery = 5,
    Delivered = 6,
    Cancelled = 7,
    Rejected = 8,
    Expired = 9,
}