// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentVerifyMicrodepositsOptions : BaseOptions
    {
        /// <summary>
        /// Two positive integers, in <em>cents</em>, equal to the values of the microdeposits sent
        /// to the bank account.
        /// </summary>
        [JsonProperty("amounts")]
        [STJS.JsonPropertyName("amounts")]
        public List<long?> Amounts { get; set; }

        /// <summary>
        /// A six-character code starting with SM present in the microdeposit sent to the bank
        /// account.
        /// </summary>
        [JsonProperty("descriptor_code")]
        [STJS.JsonPropertyName("descriptor_code")]
        public string DescriptorCode { get; set; }
    }
}
