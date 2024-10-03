// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReaderCollectedDataService : Service<ReaderCollectedData>,
        IRetrievable<ReaderCollectedData, ReaderCollectedDataGetOptions>
    {
        public ReaderCollectedDataService()
        {
        }

        internal ReaderCollectedDataService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ReaderCollectedDataService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieve data collected using Reader hardware.</p>.
        /// </summary>
        public virtual ReaderCollectedData Get(string id, ReaderCollectedDataGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ReaderCollectedData>(BaseAddress.Api, HttpMethod.Get, $"/v1/terminal/reader_collected_data/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve data collected using Reader hardware.</p>.
        /// </summary>
        public virtual Task<ReaderCollectedData> GetAsync(string id, ReaderCollectedDataGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReaderCollectedData>(BaseAddress.Api, HttpMethod.Get, $"/v1/terminal/reader_collected_data/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
