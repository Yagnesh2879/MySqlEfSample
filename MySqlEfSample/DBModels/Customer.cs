using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace MySqlEfSample.DBModels
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string PhonePrimary { get; set; }
        public string? PhoneSecondary { get; set; }

        public DateTime? DateOfBirth{ get; set; }
        public DateTime? DateOfAnniversary{ get; set; }

        // Navigation properties
        public ICollection<CustomerAddress> Addresses { get; set; } = new List<CustomerAddress>();
        public ICollection<CustomerPaymentInfo> PaymentInfos { get; set; } = new List<CustomerPaymentInfo>();
        public CustomerBussines? BusinessInfo { get; set; }
    }

    //public class CustomerAddress
    //{
    //    [Key]
    //    [DataMember]
    //    public int AddressId { get; set; }
    //    public string AddressType { get; set; } // Example: "Billing", "Shipping", "Permanent","Comunication".
    //    public string Street { get; set; }
    //    public string City { get; set; }
    //    public string State { get; set; }
    //    public string ZipCode { get; set; }
    //    public string Country { get; set; }

    //    // Foreign key
    //    public int CustomerId { get; set; }
    //    public Customer Customer { get; set; }
    //}

    //public class CustomerPaymentInfo
    //{
    //    [Key]
    //    [DataMember]
    //    public int PaymentInfoId { get; set; }
    //    public string PaymentType { get; set; } // Example: "Card", "Bank"
    //    public string CardNumber { get; set; } // Null if PaymentType is "Bank"
    //    public string BankName { get; set; } // Null if PaymentType is "Card"
    //    public string AccountNumber { get; set; } // Null if PaymentType is "Card"
    //    public bool IsPrimary { get; set; } // Marks the primary payment method

    //    // Foreign key
    //    public int CustomerId { get; set; }
    //    public Customer Customer { get; set; }
    //}

    //public class CustomerBussines
    //{
    //    [Key]
    //    [DataMember]
    //    public int BussinesId { get; set; }
    //    public string Name { get; set; }
    //    public string? RegistrationNumber { get; set; }
    //    public string? TaxId { get; set; }
    //    public string? ContactPerson { get; set; }
    //    public string? ContactEmail { get; set; }
    //    public string? ContactPhone { get; set; }

    //    // Foreign key
    //    public int CustomerId { get; set; }
    //    public Customer Customer { get; set; }
    //}
}
