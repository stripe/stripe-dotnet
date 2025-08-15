// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2BillingLicenseFeeVersionCreatedEventData : StripeEntity<V2BillingLicenseFeeVersionCreatedEventData>
    {
        /// <summary>
        /// The ID of the LicenseFee that the LicenseFeeVersion belongs to.
        /// </summary>
        [JsonProperty("license_fee_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("license_fee_id")]
#endif
        public string LicenseFeeId { get; set; }
    }
}
