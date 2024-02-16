// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentDecrementAuthorizationOptions : BaseOptions
    {
        /// <summary>
        /// The updated total amount that you intend to collect from the cardholder. This amount
        /// must be smaller than the currently authorized amount.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }
    }
}
