namespace API.Data
{
    public class Product
    {
        //Each of these below will be tables in  the data base
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //Stripe (payment) uses this and Sqlite uses this and doesnt understand decimal
        public long Price { get; set; }

        public string PictureUrl { get; set; }

        public string Type { get; set; }

        public string Brand { get; set; }

        public int QuantityInStock { get; set; }
    }
}