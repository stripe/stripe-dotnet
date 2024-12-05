// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerPaymentSourceListOptions : ListOptions, IHasObject
    {
        /// <summary>
        /// Filter sources according to a particular object type.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }
    }
}
