// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutMethodCard : StripeEntity<PayoutMethodCard>
    {
        /// <summary>
        /// Whether the PayoutMethodCard object was archived. PayoutMethodCard objects can be
        /// archived through the /archive API, and they will not be automatically archived by
        /// Stripe. Archived PayoutMethodCard objects cannot be used as payout methods and will not
        /// appear in the payout method list.
        /// </summary>
        [JsonProperty("archived")]
        [STJS.JsonPropertyName("archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// The month the card expires.
        /// </summary>
        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public string ExpMonth { get; set; }

        /// <summary>
        /// The year the card expires.
        /// </summary>
        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public string ExpYear { get; set; }

        /// <summary>
        /// Uniquely identifies this particular card number. You can use this attribute to check
        /// whether two recipients who’ve signed up with you are using the same card number, for
        /// example.
        /// </summary>
        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// The last 4 digits of the card number.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// The list of currencies supported by this bank account.
        /// </summary>
        [JsonProperty("supported_currencies")]
        [STJS.JsonPropertyName("supported_currencies")]
        public List<string> SupportedCurrencies { get; set; }
    }
}
