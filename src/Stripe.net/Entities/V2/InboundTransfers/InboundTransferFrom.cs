// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InboundTransferFrom : StripeEntity<InboundTransferFrom>
    {
        /// <summary>
        /// The amount in specified currency that was debited from the Payment Method.
        /// </summary>
        [JsonProperty("debited")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("debited")]
#endif
        public Amount Debited { get; set; }

        /// <summary>
        /// The Payment Method object used to create the InboundTransfer.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public InboundTransferFromPaymentMethod PaymentMethod { get; set; }
    }
}
