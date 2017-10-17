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

        /// <summary>
        /// Current balance, if any, being stored on the customer’s account. If negative, the customer has credit to apply to the next invoice. If positive, the customer has an amount owed that will be added to the next invoice. The balance does not refer to any unpaid invoices; it solely takes into account amounts that have yet to be successfully applied to any invoice. This balance is only taken into account for recurring billing purposes (i.e., subscriptions, invoices, invoice items)
        /// </summary>
        [JsonProperty("account_balance")]
        public int AccountBalance { get; set; }

        /// <summary>
        /// Warning: this is not in the documentation
        /// </summary>
        [JsonProperty("bank_accounts")]
        public StripeList<CustomerBankAccount> CustomerBankAccounts { get; set; }

        /// <summary>
        /// The customer’s VAT identification number
        /// </summary>
        [JsonProperty("business_vat_id")]
        public string BusinessVatId { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// The currency the customer can be charged in for recurring billing purposes
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Default CustomerBankAccount
        /// <summary>
        /// Warning: this is not in the documentation
        /// </summary>
        public string DefaultCustomerBankAccountId { get; set; }

        /// <summary>
        /// Warning: this is not in the documentation
        /// </summary>
        [JsonIgnore]
        public CustomerBankAccount DefaultCustomerBankAccount { get; set; }

        [JsonProperty("default_bank_account")]
        internal object InternalDefaultCustomerBankAccount
        {
            set
            {
                StringOrObject<CustomerBankAccount>.Map(value, s => DefaultCustomerBankAccountId = s, o => DefaultCustomerBankAccount = o);
            }
        }
        #endregion

        #region Expandable DefaultSource
        /// <summary>
        /// ID of the default source attached to this customer
        /// <para>You can expand the DefaultSource by setting the ExpandDefaultSource property on the service to true</para>
        /// </summary>
        public string DefaultSourceId { get; set; }

        [JsonIgnore]
        public Source DefaultSource { get; set; }

        [JsonProperty("default_source")]
        internal object InternalDefaultSource
        {
            set
            {
                StringOrObject<Source>.Map(value, s => DefaultSourceId = s, o => DefaultSource = o);
            }
        }

        #endregion

        /// <summary>
        /// Warning: this is not in the documentation
        /// </summary>
        [JsonProperty("default_source_type")]
        public string DefaultSourceType { get; set; }

        /// <summary>
        /// Warning: this is not in the documentation
        /// </summary>
        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Whether or not the latest charge for the customer’s latest invoice has failed
        /// </summary>
        [JsonProperty("delinquent")]
        public bool Delinquent { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Describes the current discount active on the customer, if there is one
        /// </summary>
        [JsonProperty("discount")]
        public StripeDiscount StripeDiscount { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a customer object. It can be useful for storing additional information about the customer in a structured format
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("shipping")]
        public StripeShipping Shipping { get; set; }

        /// <summary>
        /// The customer’s payment sources, if any
        /// </summary>
        [JsonProperty("sources")]
        public StripeList<Source> Sources { get; set; }

        /// <summary>
        /// The customer’s current subscriptions, if any
        /// </summary>
        [JsonProperty("subscriptions")]
        public StripeList<StripeSubscription> Subscriptions { get; set; }
    }
}