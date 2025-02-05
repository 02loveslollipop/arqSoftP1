namespace Conc_func
{
    abstract class Car: IMaintenance
    {
        //data
        private string plate;
        private string brand;
        private string model;
        private ushort year;
        private uint motor_cylinder;
        private uint millage;
        private sbyte doors;
        private ulong raw_value;
        private byte seats;

        //Accesors
        public string Plate
        {
            get => plate;
            set => plate = (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length != Dealership.plate_length || value.Substring(0, 2).ToCharArray().Any(c => !char.IsLetter(c))) ? throw new ArgumentException("Invalid plate") : value;
        }

        public string Brand
        {
            get => brand;
            set => brand = (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < Dealership.min_brand_name_length) ? throw new ArgumentException("Invalid brand") : value;
        }

        public string Model
        {
            get => model;
            set => model = (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < Dealership.min_model_name_length) ? throw new ArgumentException("Invalid model") : value;
        }

        public ushort Year
        {
            get => year;
            set => year = (value < DateTime.Now.Year - Dealership.year_model_range || value > DateTime.Now.Year) ? throw new ArgumentException("Invalid year") : value;
        }

        public uint Motor_cylinder
        {
            get => motor_cylinder;
            set => motor_cylinder = (value < Dealership.min_motor_cylindrange_range || value > Dealership.max_motor_cylindrange_range) ? throw new ArgumentException("Invalid motor cylinder") : value;
        }

        public uint Millage
        {
            get => millage;
        }

        public sbyte Doors
        {
            get => doors;
            set => doors = Dealership.valid_doors.Contains(value) ? value : throw new ArgumentException("Invalid doors");
        }

        public ulong Raw_value
        {
            get => raw_value;
            set => raw_value = Dealership.min_price < value ? value : throw new ArgumentException("Invalid value");
        }

        public byte Seats
        {
            get => seats;
            set => seats = (value < Dealership.min_seats || value > Dealership.max_seats) ? throw new ArgumentException("Invalid seats") : value;
        }

        //Constructor
        public Car(string plate, string brand, string model, ushort year, uint motor_cylinder, sbyte doors, ulong raw_value, byte seats)
        {
            Plate = plate;
            Brand = brand;
            Model = model;
            Year = year;
            Motor_cylinder = motor_cylinder;
            this.millage = 0;
            Doors = doors;
            Raw_value = raw_value;
            Seats = seats;
        }

        //Methods
        public abstract string CheckMaintenancePlan();
    }
}