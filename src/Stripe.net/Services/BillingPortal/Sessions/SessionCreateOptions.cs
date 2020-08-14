namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of an existing customer.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The URL to which Stripe should send customers when they click on the link to return to
        /// your website. This field is required if a default return URL has not been configured for
        /// the portal.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}
