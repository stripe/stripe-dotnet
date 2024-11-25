namespace Stripe.V2
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
    [JsonConverter(typeof(V2EventConverter))]
#if NET6_0_OR_GREATER
    [NoSystemTextJsonAttributesNeeded("Converter is only needed for deserialization")]
#endif
    public partial class Event : StripeEntity<Event>, IHasId, IHasObject
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
        protected virtual T FetchRelatedObject<T>(EventRelatedObject relatedObject)
            where T : IStripeEntity
        {
            Task<T> objectTask = this.FetchRelatedObjectAsync<T>(relatedObject);
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
        protected virtual Task<T> FetchRelatedObjectAsync<T>(EventRelatedObject relatedObject, CancellationToken cancellationToken = default)
            where T : IStripeEntity
        {
            if (relatedObject == null)
            {
                return null;
            }

            if (relatedObject.Url == null)
            {
                return null;
            }

            RequestOptions opts = null;
            if (this.Context != null)
            {
                opts = new RequestOptions { StripeAccount = this.Context };
            }

            return this.Requestor.RequestAsync<T>(
                    BaseAddress.Api,
                    HttpMethod.Get,
                    relatedObject.Url,
                    null,
                    opts,
                    cancellationToken: cancellationToken);
        }
    }
}
