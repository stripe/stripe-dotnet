// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RedactionJobObjectsOptions : INestedOptions
    {
        [JsonProperty("charges")]
        [STJS.JsonPropertyName("charges")]
        public List<string> Charges { get; set; }

        [JsonProperty("checkout_sessions")]
        [STJS.JsonPropertyName("checkout_sessions")]
        public List<string> CheckoutSessions { get; set; }

        [JsonProperty("customers")]
        [STJS.JsonPropertyName("customers")]
        public List<string> Customers { get; set; }

        [JsonProperty("identity_verification_sessions")]
        [STJS.JsonPropertyName("identity_verification_sessions")]
        public List<string> IdentityVerificationSessions { get; set; }

        [JsonProperty("invoices")]
        [STJS.JsonPropertyName("invoices")]
        public List<string> Invoices { get; set; }

        [JsonProperty("issuing_cardholders")]
        [STJS.JsonPropertyName("issuing_cardholders")]
        public List<string> IssuingCardholders { get; set; }

        [JsonProperty("issuing_cards")]
        [STJS.JsonPropertyName("issuing_cards")]
        public List<string> IssuingCards { get; set; }

        [JsonProperty("payment_intents")]
        [STJS.JsonPropertyName("payment_intents")]
        public List<string> PaymentIntents { get; set; }

        [JsonProperty("radar_value_list_items")]
        [STJS.JsonPropertyName("radar_value_list_items")]
        public List<string> RadarValueListItems { get; set; }

        [JsonProperty("setup_intents")]
        [STJS.JsonPropertyName("setup_intents")]
        public List<string> SetupIntents { get; set; }
    }
}
