// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderPaymentOptions : INestedOptions
    {
        /// <summary>
        /// Settings describing how the order should configure generated PaymentIntents.
        /// </summary>
        [JsonProperty("settings")]
        public OrderPaymentSettingsOptions Settings { get; set; }
    }
}
