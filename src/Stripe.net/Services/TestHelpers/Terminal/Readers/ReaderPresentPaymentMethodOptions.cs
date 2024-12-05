// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Terminal
{
    using Newtonsoft.Json;

    public class ReaderPresentPaymentMethodOptions : BaseOptions
    {
        /// <summary>
        /// Simulated on-reader tip amount.
        /// </summary>
        [JsonProperty("amount_tip")]
        public long? AmountTip { get; set; }

        /// <summary>
        /// Simulated data for the card_present payment method.
        /// </summary>
        [JsonProperty("card_present")]
        public ReaderCardPresentOptions CardPresent { get; set; }

        /// <summary>
        /// Simulated data for the interac_present payment method.
        /// </summary>
        [JsonProperty("interac_present")]
        public ReaderInteracPresentOptions InteracPresent { get; set; }

        /// <summary>
        /// Simulated payment type.
        /// One of: <c>card_present</c>, or <c>interac_present</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
