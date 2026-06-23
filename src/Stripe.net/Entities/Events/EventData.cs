namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJEventDataConverter))]
    public class EventData : StripeEntity<EventData>
    {
        private string rawObjectJson;
        private dynamic rawObject;
        private string previousAttributesJson;
        private dynamic previousAttributes;

        /// <summary>
        /// Object containing the API resource relevant to the event. For example, an
        /// <c>invoice.created</c> event will have a full invoice object (<see cref="Invoice"/>) as
        /// the value of the object key.
        /// </summary>
        [JsonProperty("object")]
        [JsonConverter(typeof(StripeObjectConverter))]
        [STJS.JsonPropertyName("object")]
        public IHasObject Object { get; set; }

        /// <summary>
        /// Object containing the names of the attributes that have changed, and their previous
        /// values (sent along only with *.updated events).
        /// </summary>
        [JsonProperty("previous_attributes")]
        [STJS.JsonIgnore]
        [NoSystemTextJsonAttributesNeeded("STJEventConverter handles PreviousAttributes separately via SetPreviousAttributesJson")]
        public dynamic PreviousAttributes
        {
            get
            {
                if (this.previousAttributes == null && this.previousAttributesJson != null)
                {
                    this.previousAttributes = Newtonsoft.Json.Linq.JToken.Parse(this.previousAttributesJson);
                }

                return this.previousAttributes;
            }

            set
            {
                this.previousAttributes = value;
                this.previousAttributesJson = null;
            }
        }

        /// <summary>
        /// This contains the same data as <see cref="EventData.Object"/>, but untyped. This is
        /// occasionally useful, e.g. when working with an API resource for which the Stripe.net
        /// library does not have a concrete type.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public dynamic RawObject
        {
            get
            {
                if (this.rawObject == null && this.rawObjectJson != null)
                {
                    this.rawObject = Newtonsoft.Json.Linq.JToken.Parse(this.rawObjectJson);
                }

                return this.rawObject;
            }

            set
            {
                this.rawObject = value;
                this.rawObjectJson = null;
            }
        }

        internal void SetRawObjectJson(string json)
        {
            this.rawObjectJson = json;
            this.rawObject = null;
        }

        internal void SetPreviousAttributesJson(string json)
        {
            this.previousAttributesJson = json;
            this.previousAttributes = null;
        }
    }
}
