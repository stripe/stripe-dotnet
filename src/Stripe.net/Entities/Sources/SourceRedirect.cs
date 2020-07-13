namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceRedirect : StripeEntity<SourceRedirect>
    {
        /// <summary>
        /// The failure reason for the redirect. One of <c>declined</c>, <c>processing_error</c>, or <c>user_abort</c>.
        /// </summary>
        [JsonProperty("failure_reason")]
        public string FailureReason { get; set; }

        /// <summary>
        /// The URL you provide to redirect the customer to after they authenticated their payment.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The status of the redirect, either not_required, pending, succeeded or failed.
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
