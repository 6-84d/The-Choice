namespace The_choice
{
    public class Currency: IAsset
    {
        public int number { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public bool isFavorite { get; set; }
        public Currency(string name, double price, int number, bool isFav)
        {
            this.name = name;
            this.price = price;
            this.number = number;
            this.isFavorite = isFav;
        }
    }
}
