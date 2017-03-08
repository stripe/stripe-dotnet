using Newtonsoft.Json;

namespace Stripe
{
    public class StripeRedirect : StripeEntity
    {
        /// <summary>
        /// The URL you provide to redirect the customer to after they authenticated their payment.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The status of the redirect, either pending, succeeded or failed.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The URL provided to you to redirect a customer to as part of a redirect authentication flow.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
