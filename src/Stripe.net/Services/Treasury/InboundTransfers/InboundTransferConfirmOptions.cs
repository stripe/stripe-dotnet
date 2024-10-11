// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class InboundTransferConfirmOptions : BaseOptions
    {
        /// <summary>
        /// Represents the number of seconds after an Inbound Transfer has been committed to our
        /// banking partners that the user delays funds availability into the financial account. The
        /// maximum allowed delay is 5 days.
        /// </summary>
        [JsonProperty("funds_availability_delay")]
        public long? FundsAvailabilityDelay { get; set; }
    }
}
