namespace The_choice
{
    public class Currency: IAsset
    {
        public int number { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public Currency(string name, double price, int number)
        {
            this.name = name;
            this.price = price;
            this.number = number;
        }
    }
}
