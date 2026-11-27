// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class DisputeAdjustmentService : Service
    {
        internal DisputeAdjustmentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal DisputeAdjustmentService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves a DisputeAdjustment by ID.
        /// </summary>
        public virtual DisputeAdjustment Get(string id, DisputeAdjustmentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<DisputeAdjustment>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/dispute_adjustments/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a DisputeAdjustment by ID.
        /// </summary>
        public virtual Task<DisputeAdjustment> GetAsync(string id, DisputeAdjustmentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<DisputeAdjustment>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/dispute_adjustments/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of DisputeAdjustments.
        /// </summary>
        public virtual V2.StripeList<DisputeAdjustment> List(DisputeAdjustmentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<DisputeAdjustment>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/dispute_adjustments", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of DisputeAdjustments.
        /// </summary>
        public virtual Task<V2.StripeList<DisputeAdjustment>> ListAsync(DisputeAdjustmentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<DisputeAdjustment>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/dispute_adjustments", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of DisputeAdjustments.
        /// </summary>
        public virtual IEnumerable<DisputeAdjustment> ListAutoPaging(DisputeAdjustmentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<DisputeAdjustment>($"/v2/money_management/dispute_adjustments", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of DisputeAdjustments.
        /// </summary>
        public virtual IAsyncEnumerable<DisputeAdjustment> ListAutoPagingAsync(DisputeAdjustmentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<DisputeAdjustment>($"/v2/money_management/dispute_adjustments", options, requestOptions, cancellationToken);
        }
    }
}
