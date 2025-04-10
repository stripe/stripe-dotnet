// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// The objects to redact, grouped by type. All redactable objects associated with these
    /// objects will be redacted as well.
    /// </summary>
    public class RedactionJobRootObjects : StripeEntity<RedactionJobRootObjects>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        [JsonProperty("charges")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charges")]
#endif
        public List<string> Charges { get; set; }

        [JsonProperty("checkout_sessions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("checkout_sessions")]
#endif
        public List<string> CheckoutSessions { get; set; }

        [JsonProperty("customers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customers")]
#endif
        public List<string> Customers { get; set; }

        [JsonProperty("identity_verification_sessions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("identity_verification_sessions")]
#endif
        public List<string> IdentityVerificationSessions { get; set; }

        [JsonProperty("invoices")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoices")]
#endif
        public List<string> Invoices { get; set; }

        [JsonProperty("issuing_cardholders")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_cardholders")]
#endif
        public List<string> IssuingCardholders { get; set; }

        [JsonProperty("payment_intents")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intents")]
#endif
        public List<string> PaymentIntents { get; set; }

        [JsonProperty("radar_value_list_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("radar_value_list_items")]
#endif
        public List<string> RadarValueListItems { get; set; }

        [JsonProperty("setup_intents")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_intents")]
#endif
        public List<string> SetupIntents { get; set; }
    }
}
