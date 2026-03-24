// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthorizationNetworkDataOptions : INestedOptions
    {
        /// <summary>
        /// Identifier assigned to the acquirer by the card network.
        /// </summary>
        [JsonProperty("acquiring_institution_id")]
        [STJS.JsonPropertyName("acquiring_institution_id")]
        public string AcquiringInstitutionId { get; set; }
    }
}
