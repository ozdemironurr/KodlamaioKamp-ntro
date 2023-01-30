using System.CodeDom;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        private string _firstName;
        public string LastName { get { return "Mrs. "+_firstName; } set { _firstName= value; } }
        public string City { get; set; }

    }
}
