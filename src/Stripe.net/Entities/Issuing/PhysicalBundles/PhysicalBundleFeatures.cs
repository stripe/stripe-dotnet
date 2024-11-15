// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PhysicalBundleFeatures : StripeEntity<PhysicalBundleFeatures>
    {
        /// <summary>
        /// The policy for how to use card logo images in a card design with this physical bundle.
        /// One of: <c>optional</c>, <c>required</c>, or <c>unsupported</c>.
        /// </summary>
        [JsonProperty("card_logo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_logo")]
#endif

        public string CardLogo { get; set; }

        /// <summary>
        /// The policy for how to use carrier letter text in a card design with this physical
        /// bundle.
        /// One of: <c>optional</c>, <c>required</c>, or <c>unsupported</c>.
        /// </summary>
        [JsonProperty("carrier_text")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("carrier_text")]
#endif

        public string CarrierText { get; set; }

        /// <summary>
        /// The policy for how to use a second line on a card with this physical bundle.
        /// One of: <c>optional</c>, <c>required</c>, or <c>unsupported</c>.
        /// </summary>
        [JsonProperty("second_line")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("second_line")]
#endif

        public string SecondLine { get; set; }
    }
}
