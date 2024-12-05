// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentAttemptRecordListOptions : ListOptions
    {
        /// <summary>
        /// The ID of the Payment Record.
        /// </summary>
        [JsonProperty("payment_record")]
        public string PaymentRecord { get; set; }
    }
}
