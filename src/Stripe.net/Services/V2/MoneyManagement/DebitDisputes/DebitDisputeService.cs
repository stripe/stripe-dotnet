// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class DebitDisputeService : Service
    {
        internal DebitDisputeService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal DebitDisputeService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a new DebitDispute for a ReceivedDebit.
        /// </summary>
        public virtual DebitDispute Create(DebitDisputeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<DebitDispute>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/debit_disputes", options, requestOptions);
        }

        /// <summary>
        /// Creates a new DebitDispute for a ReceivedDebit.
        /// </summary>
        public virtual Task<DebitDispute> CreateAsync(DebitDisputeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<DebitDispute>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/debit_disputes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of an existing DebitDispute.
        /// </summary>
        public virtual DebitDispute Get(string id, DebitDisputeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<DebitDispute>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/debit_disputes/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an existing DebitDispute.
        /// </summary>
        public virtual Task<DebitDispute> GetAsync(string id, DebitDisputeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<DebitDispute>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/debit_disputes/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of DebitDisputes.
        /// </summary>
        public virtual V2.StripeList<DebitDispute> List(DebitDisputeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<DebitDispute>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/debit_disputes", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of DebitDisputes.
        /// </summary>
        public virtual Task<V2.StripeList<DebitDispute>> ListAsync(DebitDisputeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<DebitDispute>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/debit_disputes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of DebitDisputes.
        /// </summary>
        public virtual IEnumerable<DebitDispute> ListAutoPaging(DebitDisputeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<DebitDispute>($"/v2/money_management/debit_disputes", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of DebitDisputes.
        /// </summary>
        public virtual IAsyncEnumerable<DebitDispute> ListAutoPagingAsync(DebitDisputeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<DebitDispute>($"/v2/money_management/debit_disputes", options, requestOptions, cancellationToken);
        }
    }
}
