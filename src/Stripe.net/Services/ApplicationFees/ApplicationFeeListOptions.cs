// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ApplicationFeeListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return application fees for the charge specified by this charge ID.
        /// </summary>
        [JsonProperty("charge")]
        public string Charge { get; set; }
    }
}
