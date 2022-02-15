using System.ComponentModel.DataAnnotations;

namespace CustomerManagement.Model
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public DateTime CreatedDate { get; set; }
        

    }
}
