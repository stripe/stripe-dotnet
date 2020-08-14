namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeListOptions : ListOptionsWithCreated
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
