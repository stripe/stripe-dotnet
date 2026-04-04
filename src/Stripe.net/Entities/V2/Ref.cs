namespace Stripe.V2
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A typed reference to a Stripe V2 object. Holds the object's <c>id</c>, <c>type</c>, and
    /// <c>url</c> and can fetch the full object on demand.
    /// </summary>
    /// <typeparam name="T">The type of the referenced Stripe entity.</typeparam>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Ref<T> : StripeEntity<Ref<T>>, IHasId
        where T : IStripeEntity
    {
        /// <summary>
        /// Unique identifier for the referenced object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of the referenced object.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The URL where the full object can be retrieved.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }

        internal StripeClient Client { get; set; }

        /// <summary>
        /// Fetches the full object this reference points to.
        /// </summary>
        /// <returns>The fully populated object.</returns>
        /// <exception cref="Exception">Thrown when no client has been set on this instance.</exception>
        public T Fetch()
        {
            return this.FetchAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Fetches the full object this reference points to as an asynchronous operation.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the work.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is the fully populated object.</returns>
        /// <exception cref="Exception">Thrown when no client has been set on this instance.</exception>
        public async Task<T> FetchAsync(CancellationToken cancellationToken = default)
        {
            if (this.Client == null)
            {
                throw new Exception("Ref<T> is trying to make a request with no client.");
            }

            var res = await this.Client.RawRequestAsync(
                HttpMethod.Get,
                this.Url,
                requestOptions: new RawRequestOptions
                {
                    Usage = new List<string> { "ref_fetch" },
                },
                cancellationToken: cancellationToken)
            .ConfigureAwait(false);

            return this.Client.Deserialize<T>(res.Content);
        }
    }
}
