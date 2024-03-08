using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TARS_Delivery.Models.Enums;

namespace TARS_Delivery.Models.Entities
{
    public class Customer
    {
        private Customer(
            int userId,
            string name,
            string phoneNumber,
            string address,
            string city,
            string district,
            string ward,
            string postalCode,
            ETypeInfo typeInfo) {
                UserId = userId;
                Name = name;
                PhoneNumber = phoneNumber;
                Address = address;
                City = city;
                District = district;
                Ward = ward;
                PostalCode = postalCode;
                CreatedAt = DateTime.Now;
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

        public string City { get; private set; }

        public string District { get; private set; }

        public string Ward { get; private set; }

        public string PostalCode { get; private set; }

        public ETypeInfo TypeInfo { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public DateTime? UpdatedAt { get; private set; }

        public EStatusData Status { get; private set; }

        [ForeignKey("UserId")]
        public User User { get; private set; } = null!;

        public static Customer CreateCustomer(
            int userId,
            string name,
            string phoneNumber,
            string address,
            string city,
            string district,
            string ward,
            string postalCode,
            ETypeInfo typeInfo) =>
                new(
                    userId,
                    name,
                    phoneNumber,
                    address,
                    city,
                    district,
                    ward,
                    postalCode,
                    typeInfo
                );

        internal static Customer Seed(
            int id,
            int userId,
            string name,
            string phoneNumber,
            string address,
            string city,
            string district,
            string ward,
            string postalCode,
            ETypeInfo typeInfo)
        {
            Customer customer = CreateCustomer(userId, name, phoneNumber, address, city, district, ward, postalCode, typeInfo );
            customer.Id = id;

            return customer;
        }

    }
}
