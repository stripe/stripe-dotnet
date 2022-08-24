// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using Newtonsoft.Json;

    public class CardValidateOptions : BaseOptions
    {
        /// <summary>
        /// The gift card code to be validated.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// The pin associated with the gift card. Not all gift cards have pins.
        /// </summary>
        [JsonProperty("pin")]
        public string Pin { get; set; }
    }
}
