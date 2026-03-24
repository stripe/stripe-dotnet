// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Billing Intent represents a proposed change to a customer's billing configuration,
    /// such as subscribing to a new service, modifying an existing subscription, or canceling
    /// service. Intents follow a draft-reserve-commit workflow where they can be previewed
    /// before committing, allowing you to see the billing impact before changes take effect.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Intent : StripeEntity<Intent>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Breakdown of the amount for this Billing Intent.
        /// </summary>
        [JsonProperty("amount_details")]
        [STJS.JsonPropertyName("amount_details")]
        public IntentAmountDetails AmountDetails { get; set; }

        /// <summary>
        /// ID of an existing Cadence to use.
        /// </summary>
        [JsonProperty("cadence")]
        [STJS.JsonPropertyName("cadence")]
        public string Cadence { get; set; }

        /// <summary>
        /// Data for creating a new Cadence.
        /// </summary>
        [JsonProperty("cadence_data")]
        [STJS.JsonPropertyName("cadence_data")]
        public IntentCadenceData CadenceData { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Invoice resources associated with this Billing Intent. Populated when include parameters
        /// are specified.
        /// </summary>
        [JsonProperty("invoice_resources")]
        [STJS.JsonPropertyName("invoice_resources")]
        public IntentInvoiceResources InvoiceResources { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Current status of the Billing Intent.
        /// One of: <c>canceled</c>, <c>committed</c>, <c>draft</c>, or <c>reserved</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Timestamps for status transitions of the Billing Intent.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public IntentStatusTransitions StatusTransitions { get; set; }
    }
}
