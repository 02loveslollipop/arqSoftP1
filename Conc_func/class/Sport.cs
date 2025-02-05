namespace Conc_func
{
    class Sport: Car
    {
        //data
        private bool isCoupe;
        private bool isConvertible;
        
        //Accessors
        public bool IsCoupe
        {
            get => isCoupe;
        }

        public bool IsConvertible
        {
            get => isConvertible;
        }

        //Constructor
        public Sport(string plate, string brand, string model, ushort year, uint motor_cylinder, sbyte doors, ulong raw_value, byte seats, bool isCoupe, bool isConvertible): base(plate, brand, model, year, motor_cylinder, doors, raw_value, seats)
        {
            this.isCoupe = isCoupe;
            this.isConvertible = isConvertible;
        }

        //Methods
        public override string CheckMaintenancePlan()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Plate: {Plate}\nBrand: {Brand}\nModel: {Model}\nYear: {Year}\nMotor cylinder: {Motor_cylinder}\nDoors: {Doors}\nRaw value: {Raw_value}\nSeats: {Seats}\nIs coupe: {IsCoupe}\nIs convertible: {IsConvertible}";
        }

    }
        
}