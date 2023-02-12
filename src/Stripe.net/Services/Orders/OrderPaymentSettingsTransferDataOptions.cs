// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderPaymentSettingsTransferDataOptions : INestedOptions
    {
        /// <summary>
        /// The amount that will be transferred automatically when the order is paid. If no amount
        /// is set, the full amount is transferred. There cannot be any line items with recurring
        /// prices when using this field.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// ID of the Connected account receiving the transfer.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
