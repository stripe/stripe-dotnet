// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionPaymentSettingsPaymentMethodOptionsCardMandateOptions : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsCardMandateOptions>
    {
        /// <summary>
        /// Amount to be charged for future payments.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// One of <c>fixed</c> or <c>maximum</c>. If <c>fixed</c>, the <c>amount</c> param refers
        /// to the exact amount to be charged in future payments. If <c>maximum</c>, the amount
        /// charged can be up to the value passed for the <c>amount</c> param.
        /// One of: <c>fixed</c>, or <c>maximum</c>.
        /// </summary>
        [JsonProperty("amount_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_type")]
#endif
        public string AmountType { get; set; }

        /// <summary>
        /// A description of the mandate or subscription that is meant to be displayed to the
        /// customer.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }
    }
}
