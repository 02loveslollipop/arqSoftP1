namespace Conc_func
{
    class Dealership
    {

        //data
        private string name;
        private string address;
        //business logic
        internal readonly static float min_dscnt = 0.01f;
        internal readonly static float max_dscnt = 0.025f;
        internal readonly static float min_commission = 0.015f;
        internal readonly static float max_commission = 0.025f;
        internal readonly static byte plate_length = 6;
        internal readonly static byte taxi_company_length = 6;
        internal readonly static byte min_brand_name_length = 2;
        internal readonly static byte min_model_name_length = 2;
        internal readonly static byte year_model_range = 2;
        internal readonly static int min_motor_cylindrange_range = 1000;
        internal readonly static int max_motor_cylindrange_range = 6000;
        internal readonly static sbyte min_seats = 2;
        internal readonly static sbyte max_seats = 5;
        internal readonly static sbyte[] valid_doors = {2,3,5};
        internal readonly static byte min_length_name = 2;
        internal readonly static byte min_length_dir = 2;
        internal readonly static byte length_id = 10;
        internal readonly static ulong min_price = 60000000;
        internal readonly static sbyte min_fog_lights = 2;
        internal readonly static sbyte max_fog_lights = 6;
        internal readonly static byte min_length_taxi_driver_card_id = 5;
        internal static ulong next_invoice_number = 10000;



        //states
        //internal List<Sale> sales = new List<Sale>();

        //Lambdas
        
        private Func<String,bool> checkName = (String name) => (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name) || name.Length < min_length_name) ? false  : true;

        private Func<String,bool> checkAddress = (String address) => (String.IsNullOrEmpty(address) || String.IsNullOrWhiteSpace(address) || address.Length < min_length_dir) ? false  : true;

        //Accessors
        public string Name
        {
            get => name;
            set => name = checkName(value) ? value : throw new ArgumentException("Invalid name");
        }

        public string Address
        {
            get => address;
            set => address = checkAddress(value) ? value : throw new ArgumentException("Invalid address");
        }

        //Constructor
        public Dealership(string name, string address)
        {
            Name = name;
            Address = address;
        }



    }
}