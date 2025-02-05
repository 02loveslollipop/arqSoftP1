namespace Conc_func
{
    class Truck: Car
    {
        //data
        private bool doubleTractions;
        private byte fogLights = 0;

        //Accessors
        public bool DoubleTractions
        {
            get => doubleTractions;
        }

        public byte FogLights
        {
            get => fogLights;
            set => fogLights = (value >= Dealership.min_fog_lights && value <= Dealership.max_fog_lights) ? value : throw new ArgumentException("Invalid fog lights");
        }

        //Constructor
        public Truck(string plate, string brand, string model, ushort year, uint motor_cylinder, sbyte doors, ulong raw_value, byte seats, bool doubleTractions, byte fogLights): base(plate, brand, model, year, motor_cylinder, doors, raw_value, seats)
        {
            this.doubleTractions = doubleTractions;
            FogLights = fogLights;
        }

        //Methods
        public override string CheckMaintenancePlan()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Plate: {Plate}\nBrand: {Brand}\nModel: {Model}\nYear: {Year}\nMotor cylinder: {Motor_cylinder}\nDoors: {Doors}\nRaw value: {Raw_value}\nSeats: {Seats}\nDouble tractions: {DoubleTractions}\nFog lights: {FogLights}";
        }

    }
}