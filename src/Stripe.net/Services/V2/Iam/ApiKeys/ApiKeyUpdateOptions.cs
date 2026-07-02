// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ApiKeyUpdateOptions : BaseOptions
    {
        /// <summary>
        /// List of connect permissions for this API key.
        /// </summary>
        [JsonProperty("connect_permissions")]
        [STJS.JsonPropertyName("connect_permissions")]
        public List<string> ConnectPermissions { get; set; }

        /// <summary>
        /// Name to set for the API key. If blank, the field is left unchanged.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Note or description to set for the API key. If blank, the field is left unchanged.
        /// </summary>
        [JsonProperty("note")]
        [STJS.JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// List of permissions for this API key.
        /// </summary>
        [JsonProperty("permissions")]
        [STJS.JsonPropertyName("permissions")]
        public List<string> Permissions { get; set; }
    }
}
