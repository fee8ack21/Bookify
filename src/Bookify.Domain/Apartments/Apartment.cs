using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Apartments;

// 若沒有要被繼承，建議使用 sealed 關鍵字
public sealed class Apartment : Entity
{
    public Apartment(
        Guid id,
        Name name,
        Description description,
        Address address,
        Money price,
        Money cleaningFee,
        List<Amenity> amenities)
        : base(id)
    {
        Name = name;
        Description = description;
        Address = address;
        Price = price;
        CleaningFee = cleaningFee;
        Amenities = amenities;
    }

    public Address Address { get; private set; }
    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public Money Price { get; private set; }
    public Money CleaningFee { get; private set; }
    public DateTime? LastBookedOnUtc { get; private set; }
    public List<Amenity> Amenities { get; private set; } = new();
}