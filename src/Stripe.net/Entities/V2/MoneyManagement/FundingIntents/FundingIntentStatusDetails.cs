// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingIntentStatusDetails : StripeEntity<FundingIntentStatusDetails>
    {
        /// <summary>
        /// Details present when the FundingIntent is canceled.
        /// </summary>
        [JsonProperty("canceled")]
        [STJS.JsonPropertyName("canceled")]
        public FundingIntentStatusDetailsCanceled Canceled { get; set; }
    }
}
