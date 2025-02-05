namespace Conc_func
{
    class Client: Person
    {
        //data
        private float discount;

        //Accesors
        public float Discount
        {
            get => discount;
            set => discount = (value < Dealership.min_dscnt || value > Dealership.max_dscnt) ? throw new ArgumentException("Invalid discount") : value;
        }

        //Constructor
        public Client(string name, string id, float discount): base(name, id)
        {
            Discount = discount;
        }
    }
}