using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripePayout : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object => "payout";


        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("arrival_date")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime ArrivalDate { get; set; }

        // probably expandable
        [JsonProperty("balance_transaction")]
        public string BalanceTransactionId { get; set; }

        // probably expandable
        [JsonProperty("cancellation_balance_transaction")]
        public string CancellationBalanceTransactionId { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        // expandable, but different types
        [JsonProperty("destination")]
        public string DestinationId { get; set; }

        [JsonProperty("failure_code")]
        public string FailureCode { get; set; }

        [JsonProperty("failure_message")]
        public string FailureMessage { get; set; }

        // todo: can this move to StripeEntity?
        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        // example: bank_account
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}