namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Session : StripeEntity<Session>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("billing_address_collection")]
        public string BillingAddressCollection { get; set; }

        [JsonProperty("cancel_url")]
        public string CancelUrl { get; set; }

        [JsonProperty("client_reference_id")]
        public string ClientReferenceId { get; set; }

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

        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("display_items")]
        public List<SessionDisplayItem> DisplayItems { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        #region Expandable Payment Intent
        [JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        [JsonIgnore]
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        #region Expandable Setup Intent
        [JsonIgnore]
        public string SetupIntentId
        {
            get => this.InternalSetupIntent?.Id;
            set => this.InternalSetupIntent = SetExpandableFieldId(value, this.InternalSetupIntent);
        }

        [JsonIgnore]
        public SetupIntent SetupIntent
        {
            get => this.InternalSetupIntent?.ExpandedObject;
            set => this.InternalSetupIntent = SetExpandableFieldObject(value, this.InternalSetupIntent);
        }

        [JsonProperty("setup_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<SetupIntent>))]
        internal ExpandableField<SetupIntent> InternalSetupIntent { get; set; }
        #endregion

        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }

        [JsonProperty("shipping_address_collection")]
        public SessionShippingAddressCollection ShippingAddressCollection { get; set; }

        [JsonProperty("submit_type")]
        public string SubmitType { get; set; }

        #region Expandable Subscription
        [JsonIgnore]
        public string SubscriptionId
        {
            get => this.InternalSubscription?.Id;
            set => this.InternalSubscription = SetExpandableFieldId(value, this.InternalSubscription);
        }

        [JsonIgnore]
        public Subscription Subscription
        {
            get => this.InternalSubscription?.ExpandedObject;
            set => this.InternalSubscription = SetExpandableFieldObject(value, this.InternalSubscription);
        }

        [JsonProperty("subscription")]
        [JsonConverter(typeof(ExpandableFieldConverter<Subscription>))]
        internal ExpandableField<Subscription> InternalSubscription { get; set; }
        #endregion

        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }
    }
}
