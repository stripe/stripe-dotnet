// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Tax Association exposes the Tax Transactions that Stripe attempted to create on your
    /// behalf based on the PaymentIntent input.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Association : StripeEntity<Association>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The <a href="https://docs.stripe.com/api/tax/calculations/object">Tax Calculation</a>
        /// that was included in PaymentIntent.
        /// </summary>
        [JsonProperty("calculation")]
        [STJS.JsonPropertyName("calculation")]
        public string Calculation { get; set; }

        /// <summary>
        /// The <a href="https://docs.stripe.com/api/payment_intents/object">PaymentIntent</a> that
        /// this Tax Association is tracking.
        /// </summary>
        [JsonProperty("payment_intent")]
        [STJS.JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// Information about the tax transactions linked to this payment intent.
        /// </summary>
        [JsonProperty("tax_transaction_attempts")]
        [STJS.JsonPropertyName("tax_transaction_attempts")]
        public List<AssociationTaxTransactionAttempt> TaxTransactionAttempts { get; set; }
    }
}
