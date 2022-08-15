
using AutoMapper;
using C.Sharp.Model;

Console.WriteLine(" success.");

Trip trip = new Trip();
trip.TripList();
public enum PaymentMethodType
{
    Cash = 0,
    Visa = 1
}


public class Trip
{
    public int Id { get; set; }
    public int Cost { get; set; }
    public PaymentMethodType? PaymentMethod { get; set; }

    public Trip() { }
    public Trip(int id, int cost, PaymentMethodType? paymentMethod)
    {
        Id = id;
        Cost = cost;
        PaymentMethod = paymentMethod;
    }

    public void TripList()
    {
        List<Trip> tripList = new()
        {
            new Trip(1, 10, PaymentMethodType.Cash),
            new Trip(2, 10, PaymentMethodType.Visa),
            new Trip(2, 10, PaymentMethodType.Cash),
              new Trip(2, 10, null),
        };


        foreach (var item in tripList)
        {
            Console.WriteLine($"id:{item.Id}v");

            switch (item.PaymentMethod)
            {
                case PaymentMethodType.Cash :
                    Console.WriteLine("Cash");
                    break;

                case PaymentMethodType.Visa :
                    Console.WriteLine("Visa");
                    break;

                default:
                    Console.WriteLine("None");
                    break;
            }

            Console.WriteLine("--------------------------");

        }
    }

}

