// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BankAccountVerifyOptions : BaseOptions
    {
        /// <summary>
        /// Two positive integers, in <em>cents</em>, equal to the values of the microdeposits sent
        /// to the bank account.
        /// </summary>
        [JsonProperty("amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amounts")]
#endif
        public List<long> Amounts { get; set; }
    }
}
