using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using TARS_Delivery.Models.Enum;

namespace TARS_Delivery.Models.Entities
{
    public class Customer
    {
        private Customer(
            int userId,
            string name,
            string phoneNumber,
            string address,
            string province,
            string city,
            string district,
            string country,
            int postalCode,
            ETypeInfo typeInfo) {
                UserId = userId;
                Name = name;
                PhoneNumber = phoneNumber;
                Address = address;
                Province = province;
                City = city;
                District = district;
                Country = country;
                PostalCode = postalCode;
                CreatedAt = DateTime.Now;
                UpdatedAt = DateTime.Now;
                Status = EStatusData.Active;
                TypeInfo = typeInfo;
            }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        public int UserId { get; private set; }

        public string Name { get; private set; }

        public string PhoneNumber { get; private set; }

        public string Address { get; private set; }

        public string Province { get; private set; }

        public string City { get; private set; }

        public string District { get; private set; }

        public string Country { get; private set; }

        public int PostalCode { get; private set; }

        public ETypeInfo TypeInfo { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }

        public EStatusData Status { get; private set; }

        [ForeignKey("UserId")]
        public User User { get; private set; } = null!;

        public static Customer CreateCustomer(
            int userId,
            string name,
            string phoneNumber,
            string address,
            string province,
            string city,
            string district,
            string country,
            int postalCode,
            ETypeInfo typeInfo) =>
                new(
                    userId,
                    name,
                    phoneNumber,
                    address,
                    province,
                    city,
                    district,
                    country,
                    postalCode,
                    typeInfo
                );
    }
}
