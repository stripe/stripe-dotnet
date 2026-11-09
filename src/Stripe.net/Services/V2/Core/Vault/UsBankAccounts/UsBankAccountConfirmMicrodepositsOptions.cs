// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class UsBankAccountConfirmMicrodepositsOptions : BaseOptions
    {
        /// <summary>
        /// Two amounts received through Send Microdeposits must match the input to Confirm
        /// Microdeposits to verify US Bank Account.
        /// </summary>
        [JsonProperty("amounts")]
        [STJS.JsonPropertyName("amounts")]
        public List<long?> Amounts { get; set; }

        /// <summary>
        /// Descriptor code received through Send Microdeposits must match the input to Confirm
        /// Microdeposits to verify US Bank Account.
        /// </summary>
        [JsonProperty("descriptor_code")]
        [STJS.JsonPropertyName("descriptor_code")]
        public string DescriptorCode { get; set; }
    }
}
