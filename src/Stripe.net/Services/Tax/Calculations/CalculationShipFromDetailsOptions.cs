// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class CalculationShipFromDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The address from which the goods are being shipped from.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }
    }
}
