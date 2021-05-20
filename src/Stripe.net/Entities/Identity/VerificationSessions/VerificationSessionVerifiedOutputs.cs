// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationSessionVerifiedOutputs : StripeEntity<VerificationSessionVerifiedOutputs>
    {
        /// <summary>
        /// Verified address of the user.
        /// </summary>
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Verified date of birth of the user.
        /// </summary>
        [JsonProperty("dob")]
        public VerificationSessionVerifiedOutputsDob Dob { get; set; }

        /// <summary>
        /// Verified first name of the user.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Verified national id number of the user.
        /// </summary>
        [JsonProperty("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// Country / type of verified national id number.
        /// One of: <c>br_cpf</c>, <c>sg_nric</c>, or <c>us_ssn</c>.
        /// </summary>
        [JsonProperty("id_number_type")]
        public string IdNumberType { get; set; }

        /// <summary>
        /// Verified last name of the user.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }
}
