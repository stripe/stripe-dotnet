namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class ChargeListOptions : ListOptionsWithCreated
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }

        [Obsolete("This parameter is deprecated. Filter the returned list of charges instead.")]
        [JsonProperty("source")]
        public ChargeSourceListOptions Source { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
