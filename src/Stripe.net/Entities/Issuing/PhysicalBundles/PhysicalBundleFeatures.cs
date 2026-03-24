// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PhysicalBundleFeatures : StripeEntity<PhysicalBundleFeatures>
    {
        /// <summary>
        /// The policy for how to use card logo images in a card design with this physical bundle.
        /// One of: <c>optional</c>, <c>required</c>, or <c>unsupported</c>.
        /// </summary>
        [JsonProperty("card_logo")]
        [STJS.JsonPropertyName("card_logo")]
        public string CardLogo { get; set; }

        /// <summary>
        /// The policy for how to use carrier letter text in a card design with this physical
        /// bundle.
        /// One of: <c>optional</c>, <c>required</c>, or <c>unsupported</c>.
        /// </summary>
        [JsonProperty("carrier_text")]
        [STJS.JsonPropertyName("carrier_text")]
        public string CarrierText { get; set; }

        /// <summary>
        /// The policy for how to use a second line on a card with this physical bundle.
        /// One of: <c>optional</c>, <c>required</c>, or <c>unsupported</c>.
        /// </summary>
        [JsonProperty("second_line")]
        [STJS.JsonPropertyName("second_line")]
        public string SecondLine { get; set; }
    }
}
