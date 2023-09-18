// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return charges for the customer specified by this customer ID.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Only return charges that were created by the PaymentIntent specified by this
        /// PaymentIntent ID.
        /// </summary>
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// Only return charges for this transfer group.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
