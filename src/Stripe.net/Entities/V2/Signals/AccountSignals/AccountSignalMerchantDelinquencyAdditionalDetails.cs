// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignalMerchantDelinquencyAdditionalDetails : StripeEntity<AccountSignalMerchantDelinquencyAdditionalDetails>
    {
        /// <summary>
        /// Array of objects representing individual factors that contributed to the calculated
        /// probability of delinquency. Absent when risk level is unknown, or when the user is not
        /// on a product tier that includes indicators.
        /// </summary>
        [JsonProperty("indicators")]
        [STJS.JsonPropertyName("indicators")]
        public List<AccountSignalMerchantDelinquencyAdditionalDetailsIndicator> Indicators { get; set; }
    }
}
