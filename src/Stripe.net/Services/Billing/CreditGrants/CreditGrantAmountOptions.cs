// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditGrantAmountOptions : INestedOptions
    {
        /// <summary>
        /// The monetary amount.
        /// </summary>
        [JsonProperty("monetary")]
        public CreditGrantAmountMonetaryOptions Monetary { get; set; }

        /// <summary>
        /// Specify the type of this amount. We currently only support <c>monetary</c> credits.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
