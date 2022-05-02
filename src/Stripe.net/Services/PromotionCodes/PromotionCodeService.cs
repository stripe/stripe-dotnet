// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
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

        public override string BasePath => "/v1/promotion_codes";

        public virtual PromotionCode Create(PromotionCodeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<PromotionCode> CreateAsync(PromotionCodeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual PromotionCode Get(string id, PromotionCodeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<PromotionCode> GetAsync(string id, PromotionCodeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<PromotionCode> List(PromotionCodeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<PromotionCode>> ListAsync(PromotionCodeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<PromotionCode> ListAutoPaging(PromotionCodeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<PromotionCode> ListAutoPagingAsync(PromotionCodeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual PromotionCode Update(string id, PromotionCodeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<PromotionCode> UpdateAsync(string id, PromotionCodeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
