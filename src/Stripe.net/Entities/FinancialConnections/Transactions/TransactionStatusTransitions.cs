// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransactionStatusTransitions : StripeEntity<TransactionStatusTransitions>
    {
        /// <summary>
        /// Time at which this transaction posted. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("posted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? PostedAt { get; set; }

        /// <summary>
        /// Time at which this transaction was voided. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("void_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? VoidAt { get; set; }
    }
}
