// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsUpiMandateOptions : StripeEntity<QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsUpiMandateOptions>
    {
        /// <summary>
        /// Amount to be charged for future payments.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// One of <c>fixed</c> or <c>maximum</c>. If <c>fixed</c>, the <c>amount</c> param refers
        /// to the exact amount to be charged in future payments. If <c>maximum</c>, the amount
        /// charged can be up to the value passed for the <c>amount</c> param.
        /// One of: <c>fixed</c>, or <c>maximum</c>.
        /// </summary>
        [JsonProperty("amount_type")]
        [STJS.JsonPropertyName("amount_type")]
        public string AmountType { get; set; }

        /// <summary>
        /// A description of the mandate or subscription that is meant to be displayed to the
        /// customer.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// End date of the mandate or subscription.
        /// </summary>
        [JsonProperty("end_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("end_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? EndDate { get; set; }
    }
}
