namespace Conc_func
{
    internal abstract class Person
    {
        //data
        private string name;
        private string id;

        //Accesors
        public string Name
        {
            get => name;
            set => name = (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < Dealership.min_length_name) ? throw new ArgumentException("Invalid name") : value;
        }

        public string Id{
            get => id;
            set => id = (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || id.Length != Dealership.length_id) ? throw new ArgumentException("Invalid id") : value;
        }

        //Constructor
        public Person(string name, string id)
        {
            Name = name;
            Id = id;
        }

    }
}