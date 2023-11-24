namespace Classes
{
    // Customer class definition
    class Customer
    {
        // Public property for the customer ID
        public int Id { get; set; }

        // Private field for the first name with a public property that modifies its behavior
        private string _FirstName;
        public string FirstName
        {
            get { return "Mrs." + _FirstName; }
            set { _FirstName = value; }
        }

        // Public property for the last name
        public string LastName { get; set; }

        // Public property for the city
        public string City { get; set; }
    }
}
