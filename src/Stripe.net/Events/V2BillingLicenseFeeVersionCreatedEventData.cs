// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    public class V2BillingLicenseFeeVersionCreatedEventData : StripeEntity<V2BillingLicenseFeeVersionCreatedEventData>
    {
        /// <summary>
        /// The ID of the LicenseFee that the LicenseFeeVersion belongs to.
        /// </summary>
        [JsonProperty("license_fee_id")]
        [STJS.JsonPropertyName("license_fee_id")]
        public string LicenseFeeId { get; set; }
    }
}
