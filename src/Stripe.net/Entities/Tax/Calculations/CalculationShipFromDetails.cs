// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class CalculationShipFromDetails : StripeEntity<CalculationShipFromDetails>
    {
        [JsonProperty("address")]
        public CalculationShipFromDetailsAddress Address { get; set; }
    }
}
