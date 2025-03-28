// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PayoutMethodsBankAccountSpecGetOptions : BaseOptions
    {
        /// <summary>
        /// The countries to fetch the bank account spec for.
        /// </summary>
        [JsonProperty("countries")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("countries")]
#endif
        public List<string> Countries { get; set; }
    }
}
