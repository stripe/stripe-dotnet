// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PayoutMethodCard : StripeEntity<PayoutMethodCard>
    {
        /// <summary>
        /// Whether the PayoutMethodCard object was archived. PayoutMethodCard objects can be
        /// archived through the /archive API, and they will not be automatically archived by
        /// Stripe. Archived PayoutMethodCard objects cannot be used as payout methods and will not
        /// appear in the payout method list.
        /// </summary>
        [JsonProperty("archived")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("archived")]
#endif
        public bool Archived { get; set; }

        /// <summary>
        /// The month the card expires.
        /// </summary>
        [JsonProperty("exp_month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_month")]
#endif
        public string ExpMonth { get; set; }

        /// <summary>
        /// The year the card expires.
        /// </summary>
        [JsonProperty("exp_year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_year")]
#endif
        public string ExpYear { get; set; }

        /// <summary>
        /// Uniquely identifies this particular card number. You can use this attribute to check
        /// whether two recipients who’ve signed up with you are using the same card number, for
        /// example.
        /// </summary>
        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif
        public string Fingerprint { get; set; }

        /// <summary>
        /// The last 4 digits of the card number.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }
    }
}
