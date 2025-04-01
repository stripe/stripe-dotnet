// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReceivedDebitService : Service
    {
        internal ReceivedDebitService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ReceivedDebitService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves a single ReceivedDebit by ID.
        /// </summary>
        public virtual ReceivedDebit Get(string id, ReceivedDebitGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ReceivedDebit>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/received_debits/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a single ReceivedDebit by ID.
        /// </summary>
        public virtual Task<ReceivedDebit> GetAsync(string id, ReceivedDebitGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReceivedDebit>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/received_debits/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of ReceivedDebits, given the selected filters.
        /// </summary>
        public virtual V2.StripeList<ReceivedDebit> List(ReceivedDebitListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<ReceivedDebit>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/received_debits", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of ReceivedDebits, given the selected filters.
        /// </summary>
        public virtual Task<V2.StripeList<ReceivedDebit>> ListAsync(ReceivedDebitListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<ReceivedDebit>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/received_debits", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of ReceivedDebits, given the selected filters.
        /// </summary>
        public virtual IEnumerable<ReceivedDebit> ListAutoPaging(ReceivedDebitListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ReceivedDebit>($"/v2/money_management/received_debits", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of ReceivedDebits, given the selected filters.
        /// </summary>
        public virtual IAsyncEnumerable<ReceivedDebit> ListAutoPagingAsync(ReceivedDebitListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ReceivedDebit>($"/v2/money_management/received_debits", options, requestOptions, cancellationToken);
        }
    }
}
