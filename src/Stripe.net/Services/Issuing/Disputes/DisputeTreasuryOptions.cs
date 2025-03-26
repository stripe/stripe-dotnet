// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeTreasuryOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the ReceivedDebit to initiate an Issuings dispute for.
        /// </summary>
        [JsonProperty("received_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_debit")]
#endif
        public string ReceivedDebit { get; set; }
    }
}
