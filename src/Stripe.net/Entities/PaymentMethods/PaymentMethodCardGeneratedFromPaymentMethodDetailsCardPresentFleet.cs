// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresentFleet : StripeEntity<PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresentFleet>
    {
        /// <summary>
        /// Fleet prompts and values collected for this transaction.
        /// </summary>
        [JsonProperty("transaction_data")]
        [STJS.JsonPropertyName("transaction_data")]
        public List<PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresentFleetTransactionDatum> TransactionData { get; set; }
    }
}
