// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2BillingBillSettingUpdatedEventData : StripeEntity<V2BillingBillSettingUpdatedEventData>
    {
        /// <summary>
        /// Timestamp of when the object was updated.
        /// </summary>
        [JsonProperty("updated")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("updated")]
#endif
        public DateTime Updated { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
