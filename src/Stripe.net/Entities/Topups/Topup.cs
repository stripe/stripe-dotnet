namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Topup : StripeEntity<Topup>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable Balance Transaction
        [JsonIgnore]
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

        [JsonIgnore]
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expected_availability_date")]
        public long? ExpectedAvailabilityDate { get; set; }

        [JsonProperty("failure_code")]
        public string FailureCode { get; set; }

        [JsonProperty("failure_message")]
        public string FailureMessage { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
