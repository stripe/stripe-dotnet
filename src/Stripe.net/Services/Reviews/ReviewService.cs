// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
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

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/reviews";

        public virtual Review Approve(string id, ReviewApproveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Review>(HttpMethod.Post, $"/v1/reviews/{id}/approve", options, requestOptions);
        }

        public virtual Task<Review> ApproveAsync(string id, ReviewApproveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Review>(HttpMethod.Post, $"/v1/reviews/{id}/approve", options, requestOptions, cancellationToken);
        }

        public virtual Review Get(string id, ReviewGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Review>(HttpMethod.Get, $"/v1/reviews/{id}", options, requestOptions);
        }

        public virtual Task<Review> GetAsync(string id, ReviewGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Review>(HttpMethod.Get, $"/v1/reviews/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Review> List(ReviewListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Review>>(HttpMethod.Get, $"/v1/reviews", options, requestOptions);
        }

        public virtual Task<StripeList<Review>> ListAsync(ReviewListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Review>>(HttpMethod.Get, $"/v1/reviews", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Review> ListAutoPaging(ReviewListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Review>($"/v1/reviews", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Review> ListAutoPagingAsync(ReviewListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Review>($"/v1/reviews", options, requestOptions, cancellationToken);
        }
    }
}
