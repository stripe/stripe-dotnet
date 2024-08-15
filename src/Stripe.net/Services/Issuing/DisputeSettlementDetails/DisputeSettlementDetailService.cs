// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class DisputeSettlementDetailService : Service<DisputeSettlementDetail>,
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
            return this.Request<DisputeSettlementDetail>(HttpMethod.Get, $"/v1/issuing/dispute_settlement_details/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an Issuing <c>DisputeSettlementDetail</c> object.</p>.
        /// </summary>
        public virtual Task<DisputeSettlementDetail> GetAsync(string id, DisputeSettlementDetailGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<DisputeSettlementDetail>(HttpMethod.Get, $"/v1/issuing/dispute_settlement_details/{id}", options, requestOptions, cancellationToken);
        }
    }
}
