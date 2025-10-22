// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class UsBankAccountConfirmMicrodepositsOptions : BaseOptions
    {
        /// <summary>
        /// Two amounts received through Send Microdeposits must match the input to Confirm
        /// Microdeposits to verify US Bank Account.
        /// </summary>
        [JsonProperty("amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amounts")]
#endif
        public List<long?> Amounts { get; set; }

        /// <summary>
        /// Descriptor code received through Send Microdeposits must match the input to Confirm
        /// Microdeposits to verify US Bank Account.
        /// </summary>
        [JsonProperty("descriptor_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("descriptor_code")]
#endif
        public string DescriptorCode { get; set; }
    }
}
