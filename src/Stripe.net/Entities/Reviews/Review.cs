namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Review : StripeEntity<Review>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        #region Expandable Charge
        [JsonIgnore]
        public string ChargeId { get; set; }

        [JsonIgnore]
        public Charge Charge { get; set; }

        [JsonProperty("charge")]
        internal object InternalCharge
        {
            get
            {
                return this.Charge ?? (object)this.ChargeId;
            }

            set
            {
                StringOrObject<Charge>.Map(value, s => this.ChargeId = s, o => this.Charge = o);
            }
        }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("open")]
        public bool Open { get; set; }

        #region Expandable PaymentIntent
        [JsonIgnore]
        public string PaymentIntentId { get; set; }

        [JsonIgnore]
        public PaymentIntent PaymentIntent { get; set; }

        [JsonProperty("payment_intent")]
        internal object InternalPaymentIntent
        {
            get
            {
                return this.PaymentIntent ?? (object)this.PaymentIntentId;
            }

            set
            {
                StringOrObject<PaymentIntent>.Map(value, s => this.PaymentIntentId = s, o => this.PaymentIntent = o);
            }
        }
        #endregion

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
