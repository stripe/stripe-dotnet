// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class ConfigurationLoginPage : StripeEntity<ConfigurationLoginPage>
    {
        /// <summary>
        /// If <c>true</c>, a shareable <c>url</c> will be generated that will take your customers
        /// to a hosted login page for the customer portal.
        ///
        /// If <c>false</c>, the previously generated <c>url</c>, if any, will be deactivated.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// A shareable URL to the hosted portal login page. Your customers will be able to log in
        /// with their <a
        /// href="https://stripe.com/docs/api/customers/object#customer_object-email">email</a> and
        /// receive a link to their customer portal.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
