// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationSessionVerifiedOutputs : StripeEntity<VerificationSessionVerifiedOutputs>
    {
        /// <summary>
        /// The user's verified address.
        /// </summary>
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The user’s verified date of birth.
        /// </summary>
        [JsonProperty("dob")]
        public VerificationSessionVerifiedOutputsDob Dob { get; set; }

        /// <summary>
        /// The user's verified first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The user's verified id number.
        /// </summary>
        [JsonProperty("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// The user's verified id number type.
        /// One of: <c>br_cpf</c>, <c>sg_nric</c>, or <c>us_ssn</c>.
        /// </summary>
        [JsonProperty("id_number_type")]
        public string IdNumberType { get; set; }

        /// <summary>
        /// The user's verified last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }
}
