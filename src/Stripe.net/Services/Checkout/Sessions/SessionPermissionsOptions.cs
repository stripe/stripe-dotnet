// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPermissionsOptions : INestedOptions
    {
        /// <summary>
        /// Permissions for updating the Checkout Session.
        /// </summary>
        [JsonProperty("update")]
        public SessionPermissionsUpdateOptions Update { get; set; }
    }
}
