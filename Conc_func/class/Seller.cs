namespace Conc_func
{
    class Seller: Person
    {
        //data
        private float comission;
        
        //Accesors
        public float Comission
        {
            get => comission;
            set => comission = (value < Dealership.min_comission || value > Dealership.max_comission) ? throw new ArgumentException("Invalid comission") : value;
        }
        //Constructor
        public Seller(string name, string id, float comission): base(name, id)
        {
            Comission = comission;
        }
    }
}