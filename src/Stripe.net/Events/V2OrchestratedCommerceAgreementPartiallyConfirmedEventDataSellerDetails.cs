// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2OrchestratedCommerceAgreementPartiallyConfirmedEventDataSellerDetails : StripeEntity<V2OrchestratedCommerceAgreementPartiallyConfirmedEventDataSellerDetails>
    {
        /// <summary>
        /// The Network ID of the seller.
        /// </summary>
        [JsonProperty("network_business_profile")]
        [STJS.JsonPropertyName("network_business_profile")]
        public string NetworkBusinessProfile { get; set; }
    }
}
