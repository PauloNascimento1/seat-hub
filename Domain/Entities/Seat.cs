namespace Domain.Entities;

public class Seat
{

    public Guid Id {get; private set;}= Guid.NewGuid();
    public DateTime ReservedAt {get; private set;}
    public bool IsAvailable {get; private set;} = true;

      public Seat(bool isAvailable)
    {
        Id = Guid.NewGuid();
        ReservedAt = DateTime.Now;
        IsAvailable = isAvailable;
    }
}