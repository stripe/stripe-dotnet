namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceRedirect : StripeEntity<SourceRedirect>
    {
        /// <summary>
        /// The failure reason for the redirect, either <c>user_abort</c> (the customer aborted or
        /// dropped out of the redirect flow), <c>declined</c> (the authentication failed or the
        /// transaction was declined), or <c>processing_error</c> (the redirect failed due to a
        /// technical error). Present only if the redirect status is <c>failed</c>.
        /// </summary>
        [JsonProperty("failure_reason")]
        public string FailureReason { get; set; }

        /// <summary>
        /// The URL you provide to redirect the customer to after they authenticated their payment.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The status of the redirect, either <c>pending</c> (ready to be used by your customer to
        /// authenticate the transaction), <c>succeeded</c> (succesful authentication, cannot be
        /// reused) or <c>not_required</c> (redirect should not be used) or <c>failed</c> (failed
        /// authentication, cannot be reused).
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The URL provided to you to redirect a customer to as part of a <c>redirect</c>
        /// authentication flow.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
