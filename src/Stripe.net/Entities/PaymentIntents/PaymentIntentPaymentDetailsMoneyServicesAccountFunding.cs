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
        /// The merchant of record for this account funding transaction.
        /// One of: <c>stripe</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("merchant_of_record")]
        [STJS.JsonPropertyName("merchant_of_record")]
        public string MerchantOfRecord { get; set; }

        [JsonProperty("sender_account")]
        [STJS.JsonPropertyName("sender_account")]
        public string SenderAccount { get; set; }

        [JsonProperty("sender_details")]
        [STJS.JsonPropertyName("sender_details")]
        public PaymentIntentPaymentDetailsMoneyServicesAccountFundingSenderDetails SenderDetails { get; set; }
    }
}
