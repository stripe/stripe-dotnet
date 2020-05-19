namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SetupIntent : StripeEntity<SetupIntent>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        #region Expandable Application

        [JsonIgnore]
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

        [JsonIgnore]
        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

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

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("last_setup_error")]
        public StripeError LastSetupError { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        #region Expandable Mandate

        [JsonIgnore]
        public string MandateId
        {
            get => this.InternalMandate?.Id;
            set => this.InternalMandate = SetExpandableFieldId(value, this.InternalMandate);
        }

        [JsonIgnore]
        public Mandate Mandate
        {
            get => this.InternalMandate?.ExpandedObject;
            set => this.InternalMandate = SetExpandableFieldObject(value, this.InternalMandate);
        }

        [JsonProperty("mandate")]
        [JsonConverter(typeof(ExpandableFieldConverter<Mandate>))]
        internal ExpandableField<Mandate> InternalMandate { get; set; }
        #endregion

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("next_action")]
        public SetupIntentNextAction NextAction { get; set; }

        #region Expandable OnBehalfOf

        [JsonIgnore]
        public string OnBehalfOfId
        {
            get => this.InternalOnBehalfOf?.Id;
            set => this.InternalOnBehalfOf = SetExpandableFieldId(value, this.InternalOnBehalfOf);
        }

        [JsonIgnore]
        public Account OnBehalfOf
        {
            get => this.InternalOnBehalfOf?.ExpandedObject;
            set => this.InternalOnBehalfOf = SetExpandableFieldObject(value, this.InternalOnBehalfOf);
        }

        [JsonProperty("on_behalf_of")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalOnBehalfOf { get; set; }
        #endregion

        #region Expandable PaymentMethod

        [JsonIgnore]
        public string PaymentMethodId
        {
            get => this.InternalPaymentMethod?.Id;
            set => this.InternalPaymentMethod = SetExpandableFieldId(value, this.InternalPaymentMethod);
        }

        [JsonIgnore]
        public PaymentMethod PaymentMethod
        {
            get => this.InternalPaymentMethod?.ExpandedObject;
            set => this.InternalPaymentMethod = SetExpandableFieldObject(value, this.InternalPaymentMethod);
        }

        [JsonProperty("payment_method")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
        internal ExpandableField<PaymentMethod> InternalPaymentMethod { get; set; }
        #endregion

        [JsonProperty("payment_method_options")]
        public SetupIntentPaymentMethodOptions PaymentMethodOptions { get; set; }

        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        #region Expandable SingleUseMandate

        [JsonIgnore]
        public string SingleUseMandateId
        {
            get => this.InternalSingleUseMandate?.Id;
            set => this.InternalSingleUseMandate = SetExpandableFieldId(value, this.InternalSingleUseMandate);
        }

        [JsonIgnore]
        public Mandate SingleUseMandate
        {
            get => this.InternalSingleUseMandate?.ExpandedObject;
            set => this.InternalSingleUseMandate = SetExpandableFieldObject(value, this.InternalSingleUseMandate);
        }

        [JsonProperty("single_use_mandate")]
        [JsonConverter(typeof(ExpandableFieldConverter<Mandate>))]
        internal ExpandableField<Mandate> InternalSingleUseMandate { get; set; }
        #endregion

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }
    }
}
