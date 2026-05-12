// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentSetupDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Benefit details for this SetupIntent.
        /// </summary>
        [JsonProperty("benefit")]
        [STJS.JsonPropertyName("benefit")]
        public SetupIntentSetupDetailsBenefitOptions Benefit { get; set; }

        /// <summary>
        /// The ID of the Payment Location for this SetupIntent.
        /// </summary>
        [JsonProperty("location")]
        [STJS.JsonPropertyName("location")]
        public string Location { get; set; }
    }
}
