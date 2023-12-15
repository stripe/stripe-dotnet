// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class TransactionShipFromDetails : StripeEntity<TransactionShipFromDetails>
    {
        [JsonProperty("address")]
        public TransactionShipFromDetailsAddress Address { get; set; }
    }
}
