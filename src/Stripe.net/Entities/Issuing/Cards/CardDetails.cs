namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardDetails : StripeEntity<CardDetails>, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        #region Expandable Card
        [JsonIgnore]
        public string CardId => this.InternalCard.Id;

        [JsonIgnore]
        public Card Card => this.InternalCard.ExpandedObject;

        [JsonProperty("card")]
        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
        internal ExpandableField<Card> InternalCard { get; set; }
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
