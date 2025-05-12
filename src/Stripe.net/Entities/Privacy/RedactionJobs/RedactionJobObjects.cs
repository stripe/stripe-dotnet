// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RedactionJobObjects : StripeEntity<RedactionJobObjects>
    {
        /// <summary>
        /// Charge object identifiers usually starting with <c>ch_</c>.
        /// </summary>
        [JsonProperty("charges")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charges")]
#endif
        public List<string> Charges { get; set; }

        /// <summary>
        /// CheckoutSession object identifiers starting with <c>cs_</c>.
        /// </summary>
        [JsonProperty("checkout_sessions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("checkout_sessions")]
#endif
        public List<string> CheckoutSessions { get; set; }

        /// <summary>
        /// Customer object identifiers starting with <c>cus_</c>.
        /// </summary>
        [JsonProperty("customers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customers")]
#endif
        public List<string> Customers { get; set; }

        /// <summary>
        /// Identity VerificationSessions object identifiers starting with <c>vs_</c>.
        /// </summary>
        [JsonProperty("identity_verification_sessions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("identity_verification_sessions")]
#endif
        public List<string> IdentityVerificationSessions { get; set; }

        /// <summary>
        /// Invoice object identifiers starting with <c>in_</c>.
        /// </summary>
        [JsonProperty("invoices")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoices")]
#endif
        public List<string> Invoices { get; set; }

        /// <summary>
        /// Issuing Cardholder object identifiers starting with <c>ich_</c>.
        /// </summary>
        [JsonProperty("issuing_cardholders")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_cardholders")]
#endif
        public List<string> IssuingCardholders { get; set; }

        /// <summary>
        /// PaymentIntent object identifiers starting with <c>pi_</c>.
        /// </summary>
        [JsonProperty("payment_intents")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intents")]
#endif
        public List<string> PaymentIntents { get; set; }

        /// <summary>
        /// Fraud ValueListItem object identifiers starting with <c>rsli_</c>.
        /// </summary>
        [JsonProperty("radar_value_list_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("radar_value_list_items")]
#endif
        public List<string> RadarValueListItems { get; set; }

        /// <summary>
        /// SetupIntent object identifiers starting with <c>seti_</c>.
        /// </summary>
        [JsonProperty("setup_intents")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_intents")]
#endif
        public List<string> SetupIntents { get; set; }
    }
}
