// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReceivedDebitService : Service,
        IListable<ReceivedDebit, ReceivedDebitListOptions>,
        IRetrievable<ReceivedDebit, ReceivedDebitGetOptions>
    {
        public ReceivedDebitService()
        {
        }

        internal ReceivedDebitService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ReceivedDebitService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves the details of an existing ReceivedDebit by passing the unique
        /// ReceivedDebit ID from the ReceivedDebit list</p>.
        /// </summary>
        public virtual ReceivedDebit Get(string id, ReceivedDebitGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ReceivedDebit>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/received_debits/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing ReceivedDebit by passing the unique
        /// ReceivedDebit ID from the ReceivedDebit list</p>.
        /// </summary>
        public virtual Task<ReceivedDebit> GetAsync(string id, ReceivedDebitGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReceivedDebit>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/received_debits/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of ReceivedDebits.</p>.
        /// </summary>
        public virtual StripeList<ReceivedDebit> List(ReceivedDebitListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ReceivedDebit>>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/received_debits", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of ReceivedDebits.</p>.
        /// </summary>
        public virtual Task<StripeList<ReceivedDebit>> ListAsync(ReceivedDebitListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ReceivedDebit>>(BaseAddress.Api, HttpMethod.Get, $"/v1/treasury/received_debits", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of ReceivedDebits.</p>.
        /// </summary>
        public virtual IEnumerable<ReceivedDebit> ListAutoPaging(ReceivedDebitListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ReceivedDebit>($"/v1/treasury/received_debits", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of ReceivedDebits.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<ReceivedDebit> ListAutoPagingAsync(ReceivedDebitListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ReceivedDebit>($"/v1/treasury/received_debits", options, requestOptions, cancellationToken);
        }
    }
}
