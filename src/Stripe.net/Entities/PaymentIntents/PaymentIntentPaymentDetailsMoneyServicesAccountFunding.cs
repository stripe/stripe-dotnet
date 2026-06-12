// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsMoneyServicesAccountFunding : StripeEntity<PaymentIntentPaymentDetailsMoneyServicesAccountFunding>
    {
        /// <summary>
        /// ID of the Account representing the sender in this account funding transaction.
        /// </summary>
        [JsonProperty("sender_account")]
        [STJS.JsonPropertyName("sender_account")]
        public string SenderAccount { get; set; }

        [JsonProperty("sender_details")]
        [STJS.JsonPropertyName("sender_details")]
        public PaymentIntentPaymentDetailsMoneyServicesAccountFundingSenderDetails SenderDetails { get; set; }
    }
}
