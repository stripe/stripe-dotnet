// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class TransferListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return transfers for the destination specified by this account ID.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// Only return transfers with the specified transfer group.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
