// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class DisputeTreasuryOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the ReceivedDebit to initiate an Issuings dispute for.
        /// </summary>
        [JsonProperty("received_debit")]
        public string ReceivedDebit { get; set; }
    }
}
