// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;

/* Unmerged change from project 'Stripe.net(netcoreapp3.1)'
Before:
    using Stripe.Infrastructure;
    using Newtonsoft.Json.Converters;
After:
    using Newtonsoft.Json.Converters;
    using Stripe.Infrastructure;
*/
    using Newtonsoft.Json.Converters;
    using Stripe.Infrastructure;

    public class TransactionStatusTransitionsOptions : INestedOptions
    {
        /// <summary>
        /// Returns Transactions with <c>posted_at</c> within the specified range.
        /// </summary>
        [JsonProperty("posted_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> PostedAt { get; set; }
    }
}
