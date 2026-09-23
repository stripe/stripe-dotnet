// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ResourceSubmitInformationOptions : BaseOptions
    {
        /// <summary>
        /// Additional information being submitted for the resource.
        /// </summary>
        [JsonProperty("submitted_information")]
        [STJS.JsonPropertyName("submitted_information")]
        public Dictionary<string, object> SubmittedInformation { get; set; }
    }
}
