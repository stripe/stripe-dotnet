namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Manually-maintained convenience methods added to ThinEvent.
    /// </summary>
    [JsonConverter(typeof(ThinEventConverter))]
    public partial class ThinEvent : StripeEntity<ThinEvent>, IHasId, IHasObject
    {
        /// <summary>
        /// Used for .FetchObject and .FetchData helpers.
        /// </summary>
        [JsonIgnore]
        internal ApiRequestor Requestor { get; set; }

        /// <summary>
        /// Makes an API request to fetch the object associated with this event.
        /// </summary>
        /// <typeparam name="T">The type of the object to fetch.</typeparam>
        protected virtual T FetchObject<T>()
            where T : IStripeEntity
        {
            Task<T> objectTask = this.FetchObjectAsync<T>();
            if (objectTask == null)
            {
                return default(T);
            }

            return objectTask.ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Makes an API request to fetch the object associated with this event.
        /// </summary>
        /// <typeparam name="T">The type of the object to fetch.</typeparam>
        protected virtual Task<T> FetchObjectAsync<T>(CancellationToken cancellationToken = default)
            where T : IStripeEntity
        {
            if (this.RelatedObject == null)
            {
                return null;
            }

            if (this.RelatedObject.Url == null)
            {
                return null;
            }

            return this.Requestor.RequestAsync<T>(
                    BaseAddress.Api,
                    HttpMethod.Get,
                    this.RelatedObject.Url,
                    null,
                    null,
                    cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Makes an API request to fetch the data associated with this event.
        /// </summary>
        /// <typeparam name="T">The type of the data to fetch.</typeparam>
        protected virtual T FetchData<T>()
            where T : IStripeEntity
        {
            return this.FetchDataAsync<T>().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Makes an API request to fetch the data associated with this event.
        /// </summary>
        /// <typeparam name="T">The type of the data to fetch.</typeparam>
        protected virtual async Task<T> FetchDataAsync<T>(CancellationToken cancellationToken = default)
            where T : IStripeEntity
        {
            var fullEvent = await this.Requestor.RequestAsync<ThinEvent>(
                BaseAddress.Api,
                HttpMethod.Get,
                $"/v2/events/{this.Id}",
                null,
                null,
                cancellationToken: cancellationToken);

            var data = fullEvent.RawJObject["data"];
            if (data == null)
            {
                throw new InvalidOperationException("Unexpected: FetchDataAsync returned an event without a 'data' field");
            }

            return StripeEntity.FromJson<T>(fullEvent.RawJObject["data"]);
        }
    }
}
