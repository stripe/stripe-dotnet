// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderPresentPaymentMethodOptions : BaseOptions
    {
        /// <summary>
        /// Simulated on-reader tip amount.
        /// </summary>
        [JsonProperty("amount_tip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_tip")]
#endif
        public long? AmountTip { get; set; }

        /// <summary>
        /// Simulated data for the card_present payment method.
        /// </summary>
        [JsonProperty("card_present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_present")]
#endif
        public ReaderCardPresentOptions CardPresent { get; set; }

        /// <summary>
        /// Simulated data for the interac_present payment method.
        /// </summary>
        [JsonProperty("interac_present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interac_present")]
#endif
        public ReaderInteracPresentOptions InteracPresent { get; set; }

        /// <summary>
        /// Simulated payment type.
        /// One of: <c>card_present</c>, or <c>interac_present</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
