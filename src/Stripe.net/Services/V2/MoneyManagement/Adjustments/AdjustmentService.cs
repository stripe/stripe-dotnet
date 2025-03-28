// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AdjustmentService : Service
    {
        internal AdjustmentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal AdjustmentService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves the details of an Adjustment by ID.
        /// </summary>
        public virtual Adjustment Get(string id, AdjustmentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Adjustment>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/adjustments/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an Adjustment by ID.
        /// </summary>
        public virtual Task<Adjustment> GetAsync(string id, AdjustmentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Adjustment>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/adjustments/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of Adjustments that match the provided filters.
        /// </summary>
        public virtual V2.StripeList<Adjustment> List(AdjustmentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<Adjustment>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/adjustments", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of Adjustments that match the provided filters.
        /// </summary>
        public virtual Task<V2.StripeList<Adjustment>> ListAsync(AdjustmentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<Adjustment>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/adjustments", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of Adjustments that match the provided filters.
        /// </summary>
        public virtual IEnumerable<Adjustment> ListAutoPaging(AdjustmentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Adjustment>($"/v2/money_management/adjustments", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of Adjustments that match the provided filters.
        /// </summary>
        public virtual IAsyncEnumerable<Adjustment> ListAutoPagingAsync(AdjustmentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Adjustment>($"/v2/money_management/adjustments", options, requestOptions, cancellationToken);
        }
    }
}
