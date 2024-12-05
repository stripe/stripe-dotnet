// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentVerifyMicrodepositsOptions : BaseOptions
    {
        /// <summary>
        /// Two positive integers, in <em>cents</em>, equal to the values of the microdeposits sent
        /// to the bank account.
        /// </summary>
        [JsonProperty("amounts")]
        public List<long?> Amounts { get; set; }

        /// <summary>
        /// A six-character code starting with SM present in the microdeposit sent to the bank
        /// account.
        /// </summary>
        [JsonProperty("descriptor_code")]
        public string DescriptorCode { get; set; }
    }
}
