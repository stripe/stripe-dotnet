// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReviewService : Service<Review>,
        IListable<Review, ReviewListOptions>,
        IRetrievable<Review, ReviewGetOptions>
    {
        public ReviewService()
        {
        }

        internal ReviewService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ReviewService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Approves a <c>Review</c> object, closing it and removing it from the list of
        /// reviews.</p>.
        /// </summary>
        public virtual Review Approve(string id, ReviewApproveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Review>(BaseAddress.Api, HttpMethod.Post, $"/v1/reviews/{WebUtility.UrlEncode(id)}/approve", options, requestOptions);
        }

        /// <summary>
        /// <p>Approves a <c>Review</c> object, closing it and removing it from the list of
        /// reviews.</p>.
        /// </summary>
        public virtual Task<Review> ApproveAsync(string id, ReviewApproveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Review>(BaseAddress.Api, HttpMethod.Post, $"/v1/reviews/{WebUtility.UrlEncode(id)}/approve", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a <c>Review</c> object.</p>.
        /// </summary>
        public virtual Review Get(string id, ReviewGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Review>(BaseAddress.Api, HttpMethod.Get, $"/v1/reviews/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a <c>Review</c> object.</p>.
        /// </summary>
        public virtual Task<Review> GetAsync(string id, ReviewGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Review>(BaseAddress.Api, HttpMethod.Get, $"/v1/reviews/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of <c>Review</c> objects that have <c>open</c> set to <c>true</c>. The
        /// objects are sorted in descending order by creation date, with the most recently created
        /// object appearing first.</p>.
        /// </summary>
        public virtual StripeList<Review> List(ReviewListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Review>>(BaseAddress.Api, HttpMethod.Get, $"/v1/reviews", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of <c>Review</c> objects that have <c>open</c> set to <c>true</c>. The
        /// objects are sorted in descending order by creation date, with the most recently created
        /// object appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<Review>> ListAsync(ReviewListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Review>>(BaseAddress.Api, HttpMethod.Get, $"/v1/reviews", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of <c>Review</c> objects that have <c>open</c> set to <c>true</c>. The
        /// objects are sorted in descending order by creation date, with the most recently created
        /// object appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<Review> ListAutoPaging(ReviewListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Review>($"/v1/reviews", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of <c>Review</c> objects that have <c>open</c> set to <c>true</c>. The
        /// objects are sorted in descending order by creation date, with the most recently created
        /// object appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Review> ListAutoPagingAsync(ReviewListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Review>($"/v1/reviews", options, requestOptions, cancellationToken);
        }
    }
}
