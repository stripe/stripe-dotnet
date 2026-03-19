// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RedactionJobObjects : StripeEntity<RedactionJobObjects>
    {
        /// <summary>
        /// Charge object identifiers usually starting with <c>ch_</c>.
        /// </summary>
        [JsonProperty("charges")]
        [STJS.JsonPropertyName("charges")]
        public List<string> Charges { get; set; }

        /// <summary>
        /// CheckoutSession object identifiers starting with <c>cs_</c>.
        /// </summary>
        [JsonProperty("checkout_sessions")]
        [STJS.JsonPropertyName("checkout_sessions")]
        public List<string> CheckoutSessions { get; set; }

        /// <summary>
        /// Customer object identifiers starting with <c>cus_</c>.
        /// </summary>
        [JsonProperty("customers")]
        [STJS.JsonPropertyName("customers")]
        public List<string> Customers { get; set; }

        /// <summary>
        /// Identity VerificationSessions object identifiers starting with <c>vs_</c>.
        /// </summary>
        [JsonProperty("identity_verification_sessions")]
        [STJS.JsonPropertyName("identity_verification_sessions")]
        public List<string> IdentityVerificationSessions { get; set; }

        /// <summary>
        /// Invoice object identifiers starting with <c>in_</c>.
        /// </summary>
        [JsonProperty("invoices")]
        [STJS.JsonPropertyName("invoices")]
        public List<string> Invoices { get; set; }

        /// <summary>
        /// Issuing Cardholder object identifiers starting with <c>ich_</c>.
        /// </summary>
        [JsonProperty("issuing_cardholders")]
        [STJS.JsonPropertyName("issuing_cardholders")]
        public List<string> IssuingCardholders { get; set; }

        /// <summary>
        /// PaymentIntent object identifiers starting with <c>pi_</c>.
        /// </summary>
        [JsonProperty("payment_intents")]
        [STJS.JsonPropertyName("payment_intents")]
        public List<string> PaymentIntents { get; set; }

        /// <summary>
        /// Fraud ValueListItem object identifiers starting with <c>rsli_</c>.
        /// </summary>
        [JsonProperty("radar_value_list_items")]
        [STJS.JsonPropertyName("radar_value_list_items")]
        public List<string> RadarValueListItems { get; set; }

        /// <summary>
        /// SetupIntent object identifiers starting with <c>seti_</c>.
        /// </summary>
        [JsonProperty("setup_intents")]
        [STJS.JsonPropertyName("setup_intents")]
        public List<string> SetupIntents { get; set; }
    }
}
