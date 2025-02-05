namespace Conc_func
{
    class Seller: Person
    {
        //data
        private float commission;
        
        //Accesors
        public float Commission
        {
            get => commission;
            set => commission = (value < Dealership.min_commission || value > Dealership.max_commission) ? throw new ArgumentException("Invalid commission") : value;
        }
        //Constructor
        public Seller(string name, string id, float commission): base(name, id)
        {
            Commission = commission;
        }
    }
}