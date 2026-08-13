// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OperationsResolveAddressResultPrecisionDetails : StripeEntity<OperationsResolveAddressResultPrecisionDetails>
    {
        /// <summary>
        /// Issues preventing higher precision.
        /// </summary>
        [JsonProperty("issues")]
        [STJS.JsonPropertyName("issues")]
        public List<OperationsResolveAddressResultPrecisionDetailsIssue> Issues { get; set; }
    }
}
