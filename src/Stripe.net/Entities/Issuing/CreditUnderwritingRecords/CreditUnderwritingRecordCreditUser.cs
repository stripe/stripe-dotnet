// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditUnderwritingRecordCreditUser : StripeEntity<CreditUnderwritingRecordCreditUser>
    {
        /// <summary>
        /// Email of the applicant or accountholder.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Full name of the company or person.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
