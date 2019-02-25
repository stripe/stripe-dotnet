namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethod : StripeEntity, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("billing_details")]
        public BillingDetails BillingDetails { get; set; }

        [JsonProperty("card")]
        public PaymentMethodCard Card { get; set; }

        [JsonProperty("card_present")]
        public PaymentMethodCardPresent CardPresent { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Created { get; set; }

        #region Expandable Customer

        /// <summary>
        /// ID of the customer this charge is for if one exists.
        /// </summary>
        [JsonIgnore]
        public string CustomerId { get; set; }

        [JsonIgnore]
        public Customer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            get
            {
                return this.Customer ?? (object)this.CustomerId;
            }

            set
            {
                StringOrObject<Customer>.Map(value, s => this.CustomerId = s, o => this.Customer = o);
            }
        }
        #endregion

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
