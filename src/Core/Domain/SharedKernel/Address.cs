using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.SharedKernel
{
    [ComplexType]
    public record Address : object
    {
        /// <summary>
        /// کشور
        /// </summary>
        public string Country { get; init; }

        /// <summary>
        /// ایالت
        /// </summary>
        public string State { get; init; }

        /// <summary>
        /// شهر
        /// </summary>
        public string City { get; init; }

        /// <summary>
        /// کد پستی
        /// </summary>
        public PostalCode PostalCode { get; init; }

        public Address(string country, string state, string city, PostalCode postalCode)
        {
            Country = country;
            State = state;
            City = city;
            PostalCode = postalCode;
        }
        public override string ToString()
        {
            return $"{nameof(Country)}: {Country}, {nameof(State)}: {State}, {nameof(City)}: {City}, {nameof(PostalCode)}: {PostalCode.Value}";
        }
    }
}
