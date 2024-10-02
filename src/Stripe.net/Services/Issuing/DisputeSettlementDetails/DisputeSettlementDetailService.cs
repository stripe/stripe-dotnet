// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class DisputeSettlementDetailService : Service<DisputeSettlementDetail>,
        IListable<DisputeSettlementDetail, DisputeSettlementDetailListOptions>,
        IRetrievable<DisputeSettlementDetail, DisputeSettlementDetailGetOptions>
    {
        public DisputeSettlementDetailService()
        {
        }

        public DisputeSettlementDetailService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/issuing/dispute_settlement_details";

        /// <summary>
        /// <p>Retrieves an Issuing <c>DisputeSettlementDetail</c> object.</p>.
        /// </summary>
        public virtual DisputeSettlementDetail Get(string id, DisputeSettlementDetailGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<DisputeSettlementDetail>(HttpMethod.Get, $"/v1/issuing/dispute_settlement_details/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an Issuing <c>DisputeSettlementDetail</c> object.</p>.
        /// </summary>
        public virtual Task<DisputeSettlementDetail> GetAsync(string id, DisputeSettlementDetailGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<DisputeSettlementDetail>(HttpMethod.Get, $"/v1/issuing/dispute_settlement_details/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>DisputeSettlementDetail</c> objects. The objects are
        /// sorted in descending order by creation date, with the most recently created object
        /// appearing first.</p>.
        /// </summary>
        public virtual StripeList<DisputeSettlementDetail> List(DisputeSettlementDetailListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<DisputeSettlementDetail>>(HttpMethod.Get, $"/v1/issuing/dispute_settlement_details", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>DisputeSettlementDetail</c> objects. The objects are
        /// sorted in descending order by creation date, with the most recently created object
        /// appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<DisputeSettlementDetail>> ListAsync(DisputeSettlementDetailListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<DisputeSettlementDetail>>(HttpMethod.Get, $"/v1/issuing/dispute_settlement_details", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>DisputeSettlementDetail</c> objects. The objects are
        /// sorted in descending order by creation date, with the most recently created object
        /// appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<DisputeSettlementDetail> ListAutoPaging(DisputeSettlementDetailListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<DisputeSettlementDetail>($"/v1/issuing/dispute_settlement_details", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>DisputeSettlementDetail</c> objects. The objects are
        /// sorted in descending order by creation date, with the most recently created object
        /// appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<DisputeSettlementDetail> ListAutoPagingAsync(DisputeSettlementDetailListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<DisputeSettlementDetail>($"/v1/issuing/dispute_settlement_details", options, requestOptions, cancellationToken);
        }
    }
}
