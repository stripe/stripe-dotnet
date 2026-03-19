// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferFrom : StripeEntity<InboundTransferFrom>
    {
        /// <summary>
        /// The amount in specified currency that was debited from the Payment Method.
        /// </summary>
        [JsonProperty("debited")]
        [STJS.JsonPropertyName("debited")]
        public V2.Amount Debited { get; set; }

        /// <summary>
        /// The Payment Method object used to create the InboundTransfer.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public InboundTransferFromPaymentMethod PaymentMethod { get; set; }
    }
}
