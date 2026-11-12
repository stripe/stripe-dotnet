// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutMethodApplePay : StripeEntity<PayoutMethodApplePay>
    {
        /// <summary>
        /// The last four digits of the device account number (DPAN).
        /// </summary>
        [JsonProperty("dynamic_last4")]
        [STJS.JsonPropertyName("dynamic_last4")]
        public string DynamicLast4 { get; set; }

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
        /// Uniquely identifies this particular Apple-Pay-registered DPAN (Device PAN). Refer to
        /// https://support.stripe.com/questions/how-do-card-numbers-work-with-apple-pay-and-google-pay-and-what-is-dynamic-last4
        /// for more info on DPANs.
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
        /// The list of currencies supported by this card.
        /// </summary>
        [JsonProperty("supported_currencies")]
        [STJS.JsonPropertyName("supported_currencies")]
        public List<string> SupportedCurrencies { get; set; }
    }
}
