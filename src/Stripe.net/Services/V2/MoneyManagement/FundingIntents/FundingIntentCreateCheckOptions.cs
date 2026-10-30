// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FundingIntentCreateCheckOptions : INestedOptions
    {
        /// <summary>
        /// The ID of a File containing the back image of the check.
        /// </summary>
        [JsonProperty("back_image")]
        [STJS.JsonPropertyName("back_image")]
        public string BackImage { get; set; }

        /// <summary>
        /// The ID of a File containing the front image of the check.
        /// </summary>
        [JsonProperty("front_image")]
        [STJS.JsonPropertyName("front_image")]
        public string FrontImage { get; set; }
    }
}
