// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransactionEntryListOptions : ListOptionsWithCreated
    {
        [JsonProperty("effective_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> EffectiveAt { get; set; }

        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        [JsonProperty("order_by")]
        public string OrderBy { get; set; }

        [JsonProperty("transaction")]
        public string Transaction { get; set; }
    }
}
