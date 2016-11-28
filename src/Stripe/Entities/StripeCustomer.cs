using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeCustomer : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("account_balance")]
        public int AccountBalance { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("bank_accounts")]
        public StripeList<CustomerBankAccount> CustomerBankAccounts { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Default CustomerBankAccount
        public string DefaultCustomerBankAccountId { get; set; }

        [JsonIgnore]
        public CustomerBankAccount DefaultCustomerBankAccount { get; set; }

        [JsonProperty("default_bank_account")]
        internal object InternalDefaultCustomerBankAccount
        {
            set
            {
                ExpandableProperty<CustomerBankAccount>.Map(value, s => DefaultCustomerBankAccountId = s, o => DefaultCustomerBankAccount = o);
            }
        }
        #endregion

        #region Expandable Default Source
        public string DefaultSourceId { get; set; }

        [JsonIgnore]
        public StripeCard DefaultSource { get; set; }

        [JsonProperty("default_source")]
        internal object InternalDefaultSource
        {
            set
            {
                ExpandableProperty<StripeCard>.Map(value, s => DefaultSourceId = s, o => DefaultSource = o);
            }
        }
        #endregion

        [JsonProperty("default_source_type")]
        public string DefaultSourceType { get; set; }

        [JsonProperty("delinquent")]
        public bool Delinquent { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discount")]
        public StripeDiscount StripeDiscount { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("sources")]
        public StripeList<StripeCard> SourceList { get; set; }

        [JsonProperty("subscriptions")]
        public StripeList<StripeSubscription> StripeSubscriptionList { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }
    }
}