// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PayoutMethodsBankAccountSpecGetOptions : BaseOptions
    {
        /// <summary>
        /// The countries to fetch the bank account spec for.
        /// </summary>
        [JsonProperty("countries")]
        [STJS.JsonPropertyName("countries")]
        public List<string> Countries { get; set; }
    }
}
