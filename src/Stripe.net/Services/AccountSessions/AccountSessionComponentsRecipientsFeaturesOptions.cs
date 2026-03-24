// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSessionComponentsRecipientsFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Whether to allow sending money.
        /// </summary>
        [JsonProperty("send_money")]
        [STJS.JsonPropertyName("send_money")]
        public bool? SendMoney { get; set; }
    }
}
