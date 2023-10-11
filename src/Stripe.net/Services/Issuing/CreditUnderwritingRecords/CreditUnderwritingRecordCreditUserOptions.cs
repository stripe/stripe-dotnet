// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CreditUnderwritingRecordCreditUserOptions : INestedOptions
    {
        /// <summary>
        /// Email of the applicant or accountholder.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Full name of the company or person.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
