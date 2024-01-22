namespace ClassLibrary
{
    public abstract class Product
    {
        protected double price;
        protected int count;
        public string Name { get; set; }
        public double Price 
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Ціна не може бути від'ємною.");
                price = value;
            }
        }
        public int Count
        {
            get { return count; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Кількість не може бути від'ємною.");
                count = value;
            }
        }

        public Product(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
        public abstract string Display();
    }
}