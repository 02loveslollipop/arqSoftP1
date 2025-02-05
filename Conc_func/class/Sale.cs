using System.Runtime.CompilerServices;

namespace Conc_func
{
    class Sale
    {
        //data
        private ulong sale_id;
        private DateTime date;
        private List<Person> personList = new List<Person>();
        private Car car;
        private ulong price;

        //Accessors
        public List<Person> PersonList
        {
            get => PersonList;
            set => personList = value.OfType<Seller>().Count() == 1 && value.OfType<Client>().Count() == 1 ? value : throw new ArgumentException("Invalid persons");
        }

        public Car Car
        {
            get => car;
        }

        public ulong Price
        {
            get => price;
            set => price = price > Dealership.min_price ? price : throw new ArgumentException("Invalid price");
        }

        public ulong Sale_id
        {
            get => sale_id;
        }

        public DateTime Date
        {
            get => date;
            set => date = date.CompareTo(DateTime.Now) > 0 ? date : throw new ArgumentException("Invalid date");
        }

        //Constructor
        public Sale(List<Person> persons, Car car, ulong price)
        {
            PersonList = persons;
            date = DateTime.Now;
            this.car = car;
            Price = price;
            sale_id = ++Dealership.next_invoice_number;
        }

    }
}