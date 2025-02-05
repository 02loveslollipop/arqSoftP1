namespace Conc_func
{
    class Taxi: Car
    {
        //data
        private string operatorCardId;
        private string company;

        //Accessors
        public string OperatorCardId
        {
            get => operatorCardId;
            set => operatorCardId = (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < Dealership.min_lenght_taxi_driver_card_id) ? throw new ArgumentException("Invalid operator card id") : value;    
        }

        public string Company
        {
            get => company;
            set => company = (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < Dealership.taxi_company_length) ? throw new ArgumentException("Invalid company") : value;
        }

        //Constructor
        public Taxi(string plate, string brand, string model, ushort year, uint motor_cylinder, sbyte doors, ulong raw_value, byte seats, string operatorCardId, string company): base(plate, brand, model, year, motor_cylinder, doors, raw_value, seats)
        {
            OperatorCardId = operatorCardId;
            Company = company;
        }

        //Methods	
        public override string CheckMaintenancePlan()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Plate: {Plate}\nBrand: {Brand}\nModel: {Model}\nYear: {Year}\nMotor cylinder: {Motor_cylinder}\nDoors: {Doors}\nRaw value: {Raw_value}\nSeats: {Seats}\nOperator card id: {OperatorCardId}\nCompany: {Company}";
        }
    }
}