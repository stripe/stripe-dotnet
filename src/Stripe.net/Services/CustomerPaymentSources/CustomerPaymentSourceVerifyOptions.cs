// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerPaymentSourceVerifyOptions : BaseOptions
    {
        /// <summary>
        /// Two positive integers, in <em>cents</em>, equal to the values of the microdeposits sent
        /// to the bank account.
        /// </summary>
        [JsonProperty("amounts")]
        [STJS.JsonPropertyName("amounts")]
        public List<long?> Amounts { get; set; }
    }
}
