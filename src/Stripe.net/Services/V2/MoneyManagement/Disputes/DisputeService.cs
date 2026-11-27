// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class DisputeService : Service
    {
        internal DisputeService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal DisputeService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a Dispute for the specified money movement.
        /// </summary>
        public virtual Dispute Create(DisputeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/disputes", options, requestOptions);
        }

        /// <summary>
        /// Creates a Dispute for the specified money movement.
        /// </summary>
        public virtual Task<Dispute> CreateAsync(DisputeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/disputes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a Dispute.
        /// </summary>
        public virtual Dispute Get(string id, DisputeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/disputes/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a Dispute.
        /// </summary>
        public virtual Task<Dispute> GetAsync(string id, DisputeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/disputes/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of Disputes.
        /// </summary>
        public virtual V2.StripeList<Dispute> List(DisputeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Dispute>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/disputes", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of Disputes.
        /// </summary>
        public virtual Task<V2.StripeList<Dispute>> ListAsync(DisputeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Dispute>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/disputes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of Disputes.
        /// </summary>
        public virtual IEnumerable<Dispute> ListAutoPaging(DisputeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Dispute>($"/v2/money_management/disputes", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of Disputes.
        /// </summary>
        public virtual IAsyncEnumerable<Dispute> ListAutoPagingAsync(DisputeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Dispute>($"/v2/money_management/disputes", options, requestOptions, cancellationToken);
        }
    }
}
