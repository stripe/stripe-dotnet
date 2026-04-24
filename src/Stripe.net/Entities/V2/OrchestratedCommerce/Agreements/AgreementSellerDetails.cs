// File generated from our OpenAPI spec
namespace Stripe.V2.OrchestratedCommerce
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AgreementSellerDetails : StripeEntity<AgreementSellerDetails>
    {
        /// <summary>
        /// The Network ID of the seller.
        /// </summary>
        [JsonProperty("network_business_profile")]
        [STJS.JsonPropertyName("network_business_profile")]
        public string NetworkBusinessProfile { get; set; }
    }
}
