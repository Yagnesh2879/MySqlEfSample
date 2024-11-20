using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace MySqlEfSample.DBModels
{
    public class CustomerAddress
    {
        [Key]
        [DataMember]
        public int AddressId { get; set; }
        public string AddressType { get; set; } // Example: "Billing", "Shipping", "Permanent","Comunication".
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        // Foreign key
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
