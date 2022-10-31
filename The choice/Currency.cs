namespace The_choice
{
    public class Currency: IAsset
    {
        public string name { get; set; }
        public double price { get; set; }
        public Currency(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
