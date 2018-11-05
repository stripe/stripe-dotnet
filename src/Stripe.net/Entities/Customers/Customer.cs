namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Customer : StripeEntity, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Current balance, if any, being stored on the customer’s account. If negative, the customer has credit to apply to the next invoice. If positive, the customer has an amount owed that will be added to the next invoice. The balance does not refer to any unpaid invoices; it solely takes into account amounts that have yet to be successfully applied to any invoice. This balance is only taken into account for recurring billing purposes (i.e., subscriptions, invoices, invoice items)
        /// </summary>
        [JsonProperty("account_balance")]
        public long AccountBalance { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// The currency the customer can be charged in for recurring billing purposes
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable DefaultSource

        /// <summary>
        /// ID of the default source attached to this customer
        /// <para>You can expand the DefaultSource by setting the ExpandDefaultSource property on the service to true</para>
        /// </summary>
        public string DefaultSourceId { get; set; }

        [JsonIgnore]
        public IPaymentSource DefaultSource { get; set; }

        [JsonProperty("default_source")]
        internal object InternalDefaultSource
        {
            set
            {
                StringOrObject<IPaymentSource>.Map(value, s => this.DefaultSourceId = s, o => this.DefaultSource = o);
            }
        }

        #endregion

        /// <summary>
        /// Warning: this is not in the documentation
        /// </summary>
        [JsonProperty("default_source_type")]
        public string DefaultSourceType { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
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
        public Discount Discount { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a customer object. It can be useful for storing additional information about the customer in a structured format
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }

        /// <summary>
        /// The customer’s payment sources, if any
        /// </summary>
        [JsonProperty("sources")]
        public StripeList<IPaymentSource> Sources { get; set; }

        /// <summary>
        /// The customer’s current subscriptions, if any
        /// </summary>
        [JsonProperty("subscriptions")]
        public StripeList<Subscription> Subscriptions { get; set; }

        [JsonProperty("tax_info")]
        public CustomerTaxInfo TaxInfo { get; set; }

        [JsonProperty("tax_info_verification")]
        public CustomerTaxInfoVerification TaxInfoVerification { get; set; }
    }
}
