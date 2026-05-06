// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLocationCapabilitySettingsFrMealVouchersConecsPaymentsSupportedIssuers : StripeEntity<PaymentLocationCapabilitySettingsFrMealVouchersConecsPaymentsSupportedIssuers>
    {
        /// <summary>
        /// Supported meal voucher issuers for card payments.
        /// One of: <c>bimpli</c>, <c>edenred</c>, <c>pluxee</c>, or <c>up</c>.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public List<string> Card { get; set; }

        /// <summary>
        /// Supported meal voucher issuers for card present payments.
        /// One of: <c>bimpli</c>, <c>edenred</c>, <c>pluxee</c>, or <c>up</c>.
        /// </summary>
        [JsonProperty("card_present")]
        [STJS.JsonPropertyName("card_present")]
        public List<string> CardPresent { get; set; }
    }
}
