// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransferReversalService : ServiceNested<TransferReversal>,
        INestedCreatable<TransferReversal, TransferReversalCreateOptions>,
        INestedListable<TransferReversal, TransferReversalListOptions>,
        INestedRetrievable<TransferReversal, TransferReversalGetOptions>,
        INestedUpdatable<TransferReversal, TransferReversalUpdateOptions>
    {
        public TransferReversalService()
        {
        }

        public TransferReversalService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/transfers/{PARENT_ID}/reversals";

        /// <summary>
        /// <p>When you create a new reversal, you must specify a transfer to create it on.</p>.
        ///
        /// <p>When reversing transfers, you can optionally reverse part of the transfer. You can do
        /// so as many times as you wish until the entire transfer has been reversed.</p>.
        ///
        /// <p>Once entirely reversed, a transfer can’t be reversed again. This method will return
        /// an error when called on an already-reversed transfer, or when trying to reverse more
        /// money than is left on a transfer.</p>.
        /// </summary>
        public virtual TransferReversal Create(string parentId, TransferReversalCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TransferReversal>(HttpMethod.Post, $"/v1/transfers/{parentId}/reversals", options, requestOptions);
        }

        /// <summary>
        /// <p>When you create a new reversal, you must specify a transfer to create it on.</p>.
        ///
        /// <p>When reversing transfers, you can optionally reverse part of the transfer. You can do
        /// so as many times as you wish until the entire transfer has been reversed.</p>.
        ///
        /// <p>Once entirely reversed, a transfer can’t be reversed again. This method will return
        /// an error when called on an already-reversed transfer, or when trying to reverse more
        /// money than is left on a transfer.</p>.
        /// </summary>
        public virtual Task<TransferReversal> CreateAsync(string parentId, TransferReversalCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TransferReversal>(HttpMethod.Post, $"/v1/transfers/{parentId}/reversals", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>By default, you can see the 10 most recent reversals stored directly on the transfer
        /// object, but you can also retrieve details about a specific reversal stored on the
        /// transfer.</p>.
        /// </summary>
        public virtual TransferReversal Get(string parentId, string id, TransferReversalGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TransferReversal>(HttpMethod.Get, $"/v1/transfers/{parentId}/reversals/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>By default, you can see the 10 most recent reversals stored directly on the transfer
        /// object, but you can also retrieve details about a specific reversal stored on the
        /// transfer.</p>.
        /// </summary>
        public virtual Task<TransferReversal> GetAsync(string parentId, string id, TransferReversalGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TransferReversal>(HttpMethod.Get, $"/v1/transfers/{parentId}/reversals/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>You can see a list of the reversals belonging to a specific transfer. Note that the
        /// 10 most recent reversals are always available by default on the transfer object. If you
        /// need more than those 10, you can use this API method and the <c>limit</c> and
        /// <c>starting_after</c> parameters to page through additional reversals.</p>.
        /// </summary>
        public virtual StripeList<TransferReversal> List(string parentId, TransferReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TransferReversal>>(HttpMethod.Get, $"/v1/transfers/{parentId}/reversals", options, requestOptions);
        }

        /// <summary>
        /// <p>You can see a list of the reversals belonging to a specific transfer. Note that the
        /// 10 most recent reversals are always available by default on the transfer object. If you
        /// need more than those 10, you can use this API method and the <c>limit</c> and
        /// <c>starting_after</c> parameters to page through additional reversals.</p>.
        /// </summary>
        public virtual Task<StripeList<TransferReversal>> ListAsync(string parentId, TransferReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TransferReversal>>(HttpMethod.Get, $"/v1/transfers/{parentId}/reversals", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>You can see a list of the reversals belonging to a specific transfer. Note that the
        /// 10 most recent reversals are always available by default on the transfer object. If you
        /// need more than those 10, you can use this API method and the <c>limit</c> and
        /// <c>starting_after</c> parameters to page through additional reversals.</p>.
        /// </summary>
        public virtual IEnumerable<TransferReversal> ListAutoPaging(string parentId, TransferReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TransferReversal>($"/v1/transfers/{parentId}/reversals", options, requestOptions);
        }

        /// <summary>
        /// <p>You can see a list of the reversals belonging to a specific transfer. Note that the
        /// 10 most recent reversals are always available by default on the transfer object. If you
        /// need more than those 10, you can use this API method and the <c>limit</c> and
        /// <c>starting_after</c> parameters to page through additional reversals.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<TransferReversal> ListAutoPagingAsync(string parentId, TransferReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TransferReversal>($"/v1/transfers/{parentId}/reversals", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the specified reversal by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged.</p>.
        ///
        /// <p>This request only accepts metadata and description as arguments.</p>.
        /// </summary>
        public virtual TransferReversal Update(string parentId, string id, TransferReversalUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<TransferReversal>(HttpMethod.Post, $"/v1/transfers/{parentId}/reversals/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specified reversal by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged.</p>.
        ///
        /// <p>This request only accepts metadata and description as arguments.</p>.
        /// </summary>
        public virtual Task<TransferReversal> UpdateAsync(string parentId, string id, TransferReversalUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TransferReversal>(HttpMethod.Post, $"/v1/transfers/{parentId}/reversals/{id}", options, requestOptions, cancellationToken);
        }
    }
}
