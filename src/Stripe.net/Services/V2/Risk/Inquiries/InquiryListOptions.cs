// File generated from our OpenAPI spec
namespace Stripe.V2.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InquiryListOptions : V2.ListOptions
    {
        /// <summary>
        /// The account to list inquiries for.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }
    }
}
