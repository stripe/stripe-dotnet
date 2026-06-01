// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountSignalService : Service
    {
        internal AccountSignalService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal AccountSignalService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves an AccountSignal by its ID.
        /// </summary>
        public virtual AccountSignal Get(string id, AccountSignalGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<AccountSignal>(BaseAddress.Api, HttpMethod.Get, $"/v2/signals/account_signals/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves an AccountSignal by its ID.
        /// </summary>
        public virtual Task<AccountSignal> GetAsync(string id, AccountSignalGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountSignal>(BaseAddress.Api, HttpMethod.Get, $"/v2/signals/account_signals/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists AccountSignals for a given account or customer, filtered by signal type.
        /// </summary>
        public virtual V2.StripeList<AccountSignal> List(AccountSignalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<AccountSignal>>(BaseAddress.Api, HttpMethod.Get, $"/v2/signals/account_signals", options, requestOptions);
        }

        /// <summary>
        /// Lists AccountSignals for a given account or customer, filtered by signal type.
        /// </summary>
        public virtual Task<V2.StripeList<AccountSignal>> ListAsync(AccountSignalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<AccountSignal>>(BaseAddress.Api, HttpMethod.Get, $"/v2/signals/account_signals", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists AccountSignals for a given account or customer, filtered by signal type.
        /// </summary>
        public virtual IEnumerable<AccountSignal> ListAutoPaging(AccountSignalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<AccountSignal>($"/v2/signals/account_signals", options, requestOptions);
        }

        /// <summary>
        /// Lists AccountSignals for a given account or customer, filtered by signal type.
        /// </summary>
        public virtual IAsyncEnumerable<AccountSignal> ListAutoPagingAsync(AccountSignalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<AccountSignal>($"/v2/signals/account_signals", options, requestOptions, cancellationToken);
        }
    }
}
