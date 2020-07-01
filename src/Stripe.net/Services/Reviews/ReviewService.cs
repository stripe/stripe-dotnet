namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReviewService : Service<Review>,
        IListable<Review, ReviewListOptions>,
        IRetrievable<Review, ReviewGetOptions>
    {
        public ReviewService()
            : base(null)
        {
        }

        public ReviewService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/reviews";

        public virtual Review Approve(string id, ReviewApproveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/approve", options, requestOptions);
        }

        public virtual Task<Review> ApproveAsync(string id, ReviewApproveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/approve", options, requestOptions, cancellationToken);
        }

        public virtual Review Get(string id, ReviewGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Review> GetAsync(string id, ReviewGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Review> List(ReviewListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Review>> ListAsync(ReviewListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Review> ListAutoPaging(ReviewListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Review> ListAutoPagingAsync(ReviewListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif
    }
}
