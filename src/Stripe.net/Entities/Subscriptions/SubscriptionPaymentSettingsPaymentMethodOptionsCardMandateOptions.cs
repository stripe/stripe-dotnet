// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionPaymentSettingsPaymentMethodOptionsCardMandateOptions : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsCardMandateOptions>
    {
        /// <summary>
        /// Amount to be charged for future payments.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// One of <c>fixed</c> or <c>maximum</c>. If <c>fixed</c>, the <c>amount</c> param refers
        /// to the exact amount to be charged in future payments. If <c>maximum</c>, the amount
        /// charged can be up to the value passed for the <c>amount</c> param.
        /// One of: <c>fixed</c>, or <c>maximum</c>.
        /// </summary>
        [JsonProperty("amount_type")]
        public string AmountType { get; set; }

        /// <summary>
        /// A description of the mandate or subscription that is meant to be displayed to the
        /// customer.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
