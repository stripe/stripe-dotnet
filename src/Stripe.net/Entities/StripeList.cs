namespace Stripe
{
    using System.Collections;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    [JsonObject]
    public class StripeList<T> : StripeEntity<StripeList<T>>, IHasObject, IEnumerable<T>
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("data", ItemConverterType = typeof(StripeObjectConverter))]
        public List<T> Data { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return this.Data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Data.GetEnumerator();
        }

        public void Reverse()
        {
            this.Data.Reverse();
        }
    }
}
