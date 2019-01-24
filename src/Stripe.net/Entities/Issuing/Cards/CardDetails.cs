namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardDetails : StripeEntity<CardDetails>, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        #region Expandable Card
        [JsonIgnore]
        public string CardId { get; set; }

        [JsonIgnore]
        public Card Card { get; set; }

        [JsonProperty("card")]
        internal object InternalCard
        {
            get
            {
                return this.Card ?? (object)this.CardId;
            }

            set
            {
                StringOrObject<Card>.Map(value, s => this.CardId = s, o => this.Card = o);
            }
        }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("cvc")]
        public string Cvc { get; set; }

        [JsonProperty("exp_month")]
        public long ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long ExpYear { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }
    }
}
