// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignalCustomerRiskAdditionalDetails : StripeEntity<AccountSignalCustomerRiskAdditionalDetails>
    {
        /// <summary>
        /// Indicators providing risk context. Not all indicators directly contribute to the overall
        /// risk level.
        /// </summary>
        [JsonProperty("indicators")]
        [STJS.JsonPropertyName("indicators")]
        public List<AccountSignalCustomerRiskAdditionalDetailsIndicator> Indicators { get; set; }
    }
}
