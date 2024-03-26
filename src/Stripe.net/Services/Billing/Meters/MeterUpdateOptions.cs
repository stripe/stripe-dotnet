// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class MeterUpdateOptions : BaseOptions
    {
        /// <summary>
        /// The meter's name.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}
