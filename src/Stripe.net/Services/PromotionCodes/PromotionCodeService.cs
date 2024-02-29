// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PromotionCodeService : Service<PromotionCode>,
        ICreatable<PromotionCode, PromotionCodeCreateOptions>,
        IListable<PromotionCode, PromotionCodeListOptions>,
        IRetrievable<PromotionCode, PromotionCodeGetOptions>,
        IUpdatable<PromotionCode, PromotionCodeUpdateOptions>
    {
        public PromotionCodeService()
            : base(null)
        {
        }

        public PromotionCodeService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/promotion_codes";

        public virtual PromotionCode Create(PromotionCodeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PromotionCode>(HttpMethod.Post, $"/v1/promotion_codes", options, requestOptions);
        }

        public virtual Task<PromotionCode> CreateAsync(PromotionCodeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PromotionCode>(HttpMethod.Post, $"/v1/promotion_codes", options, requestOptions, cancellationToken);
        }

        public virtual PromotionCode Get(string id, PromotionCodeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PromotionCode>(HttpMethod.Get, $"/v1/promotion_codes/{id}", options, requestOptions);
        }

        public virtual Task<PromotionCode> GetAsync(string id, PromotionCodeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PromotionCode>(HttpMethod.Get, $"/v1/promotion_codes/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<PromotionCode> List(PromotionCodeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PromotionCode>>(HttpMethod.Get, $"/v1/promotion_codes", options, requestOptions);
        }

        public virtual Task<StripeList<PromotionCode>> ListAsync(PromotionCodeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PromotionCode>>(HttpMethod.Get, $"/v1/promotion_codes", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<PromotionCode> ListAutoPaging(PromotionCodeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PromotionCode>($"/v1/promotion_codes", options, requestOptions);
        }

        public virtual IAsyncEnumerable<PromotionCode> ListAutoPagingAsync(PromotionCodeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PromotionCode>($"/v1/promotion_codes", options, requestOptions, cancellationToken);
        }

        public virtual PromotionCode Update(string id, PromotionCodeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PromotionCode>(HttpMethod.Post, $"/v1/promotion_codes/{id}", options, requestOptions);
        }

        public virtual Task<PromotionCode> UpdateAsync(string id, PromotionCodeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PromotionCode>(HttpMethod.Post, $"/v1/promotion_codes/{id}", options, requestOptions, cancellationToken);
        }
    }
}
