namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethod : StripeEntity<PaymentMethod>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("alipay")]
        public PaymentMethodAlipay Alipay { get; set; }

        [JsonProperty("au_becs_debit")]
        public PaymentMethodAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        public PaymentMethodBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        public PaymentMethodBancontact Bancontact { get; set; }

        [JsonProperty("billing_details")]
        public PaymentMethodBillingDetails BillingDetails { get; set; }

        [JsonProperty("card")]
        public PaymentMethodCard Card { get; set; }

        [JsonProperty("card_present")]
        public PaymentMethodCardPresent CardPresent { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable Customer

        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("eps")]
        public PaymentMethodEps Eps { get; set; }

        [JsonProperty("fpx")]
        public PaymentMethodFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        public PaymentMethodGiropay Giropay { get; set; }

        [JsonProperty("ideal")]
        public PaymentMethodIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
        public PaymentMethodInteracPresent InteracPresent { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("p24")]
        public PaymentMethodP24 P24 { get; set; }

        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebit SepaDebit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
