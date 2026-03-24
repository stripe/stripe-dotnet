// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Cadence represents a billing schedule applied to a customer, defining when and how
    /// often to generate invoices, such as on monthly or annual billing cycle.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Cadence : StripeEntity<Cadence>, IHasId, IHasMetadata, IHasObject
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
        /// The billing cycle is the object that defines future billing cycle dates.
        /// </summary>
        [JsonProperty("billing_cycle")]
        [STJS.JsonPropertyName("billing_cycle")]
        public CadenceBillingCycle BillingCycle { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The discount rules applied to all invoices for the cadence.
        /// </summary>
        [JsonProperty("invoice_discount_rules")]
        [STJS.JsonPropertyName("invoice_discount_rules")]
        public List<CadenceInvoiceDiscountRule> InvoiceDiscountRules { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A lookup key used to retrieve cadences dynamically from a static string. Maximum length
        /// of 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The date that the billing cadence will next bill. Null if the cadence is not active.
        /// </summary>
        [JsonProperty("next_billing_date")]
        [STJS.JsonPropertyName("next_billing_date")]
        public DateTime? NextBillingDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The payer determines the entity financially responsible for the bill.
        /// </summary>
        [JsonProperty("payer")]
        [STJS.JsonPropertyName("payer")]
        public CadencePayer Payer { get; set; }

        /// <summary>
        /// The settings associated with the cadence.
        /// </summary>
        [JsonProperty("settings")]
        [STJS.JsonPropertyName("settings")]
        public CadenceSettings Settings { get; set; }

        /// <summary>
        /// Settings data that contains expanded billing settings configuration with actual values.
        /// </summary>
        [JsonProperty("settings_data")]
        [STJS.JsonPropertyName("settings_data")]
        public CadenceSettingsData SettingsData { get; set; }

        /// <summary>
        /// The current status of the cadence.
        /// One of: <c>active</c>, or <c>canceled</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The ID of the Test Clock.
        /// </summary>
        [JsonProperty("test_clock")]
        [STJS.JsonPropertyName("test_clock")]
        public string TestClock { get; set; }
    }
}
