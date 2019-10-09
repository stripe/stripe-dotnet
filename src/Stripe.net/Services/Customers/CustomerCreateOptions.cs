namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The customer’s address.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// Current balance, if any, being stored on the customer. If negative, the customer has
        /// credit to apply to their next invoice. If positive, the customer has an amount owed that
        /// will be added to their next invoice. The balance does not refer to any unpaid invoices;
        /// it solely takes into account amounts that have yet to be successfully applied to any
        /// invoice. This balance is only taken into account as invoices are finalized.
        /// </summary>
        [JsonProperty("balance")]
        public long? Balance { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [JsonProperty("invoice_settings")]
        public CustomerInvoiceSettingsOptions InvoiceSettings { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The customer’s full name or business name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The customer’s phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// The customer’s preferred locales (languages), ordered by preference.
        /// </summary>
        [JsonProperty("preferred_locales")]
        public List<string> PreferredLocales { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("shipping")]
        public ShippingOptions Shipping { get; set; }

        /// <summary>
        /// The source can either be a Token or a Source, as returned by
        /// <a href="https://stripe.com/docs/elements">Elements</a>, or a
        /// <see cref="CardCreateNestedOptions"/> containing a user’s credit card details. You must
        /// provide a source if the customer does not already have a valid source attached, and you
        /// are subscribing the customer to be charged automatically for a plan that is not free.
        /// Passing <c>source</c> will create a new source object, make it the customer default
        /// source, and delete the old customer default if one exists. If you want to add an
        /// additional source, instead use
        /// <see cref="CardService.Create(string, CardCreateOptions, RequestOptions)"/> to add the
        /// card and then <see cref="CustomerService.Update(string, CustomerUpdateOptions, RequestOptions)"/>
        /// to set it as the default. Whenever you attach a card to a customer, Stripe will
        /// automatically validate the card.
        /// </summary>
        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

        /// <summary>
        /// Describes the customer’s tax exemption status. One of <c>none</c>, <c>exempt</c>, or
        /// <c>reverse</c>.
        /// </summary>
        [JsonProperty("tax_exempt")]
        public string TaxExempt { get; set; }

        /// <summary>
        /// The customer’s tax IDs.
        /// </summary>
        [JsonProperty("tax_id_data")]
        public List<CustomerTaxIdDataOptions> TaxIdData { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("trial_end")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, SubscriptionTrialEnd> TrialEnd { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}
