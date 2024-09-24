namespace CodeSmells;
internal class DataClumps
{
    public void WithOutDataClumps()
    {
        Order order = new()
        {
            Id = 1000,
            OrderDate = DateTime.Now,
            Customer = new() { FirstName = "John", SecondName = "Doe" }
        };
    }

    public void WithDataClumps()
    {
        Order order = new()
        {
            Id = 1000,
            OrderDate = DateTime.Now,
            //CustomerFirstName = "John",
            //CustomerSecondName = "Doe"
        };
    }


    private class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }

    }

    private class Customer
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
}
