namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReviewService : Service<Review>,
        IListable<Review, ReviewListOptions>,
        IRetrievable<Review>
    {
        public ReviewService()
            : base(null)
        {
        }

        public ReviewService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/reviews";

        public virtual Review Approve(string reviewId, ReviewApproveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.PostRequest<Review>($"{this.InstanceUrl(reviewId)}/approve", options, requestOptions);
        }

        public virtual Task<Review> ApproveAsync(string reviewId, ReviewApproveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostRequestAsync<Review>($"{this.InstanceUrl(reviewId)}/approve", options, requestOptions, cancellationToken);
        }

        public virtual Review Get(string reviewId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(reviewId, null, requestOptions);
        }

        public virtual Task<Review> GetAsync(string reviewId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(reviewId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Review> List(ReviewListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Review>> ListAsync(ReviewListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Review> ListAutoPaging(ReviewListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
