// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundFundingFromPaymentMethod : StripeEntity<InboundFundingFromPaymentMethod>
    {
        /// <summary>
        /// The type of this object.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The ID of the paper check.
        /// </summary>
        [JsonProperty("us_paper_check")]
        [STJS.JsonPropertyName("us_paper_check")]
        public string UsPaperCheck { get; set; }
    }
}
