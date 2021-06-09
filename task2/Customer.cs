namespace task2
{
    public class Customer
    {
        public string Name { get; }
        public string Category { get; }

        public Customer(string name, string category)
        {
            Name = name;
            Category = category;
        }

        public override string ToString()
        {
            return "Name: " + Name + " ,Category: " + Category;
        }
    }
}