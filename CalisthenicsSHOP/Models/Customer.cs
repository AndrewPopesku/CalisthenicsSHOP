namespace CalisthenicsSHOP.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Discout { get; set; }

        public bool IsValid()
        {
            return !(string.IsNullOrEmpty(FirstName)
                    && string.IsNullOrEmpty(LastName)
                    && string.IsNullOrEmpty(Address));
        }

    }
}
