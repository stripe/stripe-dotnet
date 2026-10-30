// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundFundingFrom : StripeEntity<InboundFundingFrom>
    {
        /// <summary>
        /// The amount debited from the source.
        /// </summary>
        [JsonProperty("debited")]
        [STJS.JsonPropertyName("debited")]
        public V2.Amount Debited { get; set; }

        /// <summary>
        /// The payment method that funds the InboundFunding.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public InboundFundingFromPaymentMethod PaymentMethod { get; set; }
    }
}
