namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class ChargeListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return charges for the customer specified by this customer ID.
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Only return charges that were created by the PaymentIntent specified by this
        /// PaymentIntent ID.
        /// </summary>
        [JsonProperty("payment_intent")]
        public string PaymentIntentId { get; set; }

        [Obsolete("This parameter is deprecated. Filter the returned list of charges instead.")]
        [JsonProperty("source")]
        public ChargeSourceListOptions Source { get; set; }

        /// <summary>
        /// Only return charges for this transfer group.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
