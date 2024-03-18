// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class DisputeService : Service<Dispute>,
        IListable<Dispute, DisputeListOptions>,
        IRetrievable<Dispute, DisputeGetOptions>,
        IUpdatable<Dispute, DisputeUpdateOptions>
    {
        public DisputeService()
        {
        }

        public DisputeService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/disputes";

        /// <summary>
        /// <p>Closing the dispute for a charge indicates that you do not have any evidence to
        /// submit and are essentially dismissing the dispute, acknowledging it as lost.</p>.
        ///
        /// <p>The status of the dispute will change from <c>needs_response</c> to <c>lost</c>.
        /// <em>Closing a dispute is irreversible</em>.</p>.
        /// </summary>
        public virtual Dispute Close(string id, DisputeCloseOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(HttpMethod.Post, $"/v1/disputes/{id}/close", options, requestOptions);
        }

        /// <summary>
        /// <p>Closing the dispute for a charge indicates that you do not have any evidence to
        /// submit and are essentially dismissing the dispute, acknowledging it as lost.</p>.
        ///
        /// <p>The status of the dispute will change from <c>needs_response</c> to <c>lost</c>.
        /// <em>Closing a dispute is irreversible</em>.</p>.
        /// </summary>
        public virtual Task<Dispute> CloseAsync(string id, DisputeCloseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(HttpMethod.Post, $"/v1/disputes/{id}/close", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the dispute with the given ID.</p>.
        /// </summary>
        public virtual Dispute Get(string id, DisputeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(HttpMethod.Get, $"/v1/disputes/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the dispute with the given ID.</p>.
        /// </summary>
        public virtual Task<Dispute> GetAsync(string id, DisputeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(HttpMethod.Get, $"/v1/disputes/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your disputes.</p>.
        /// </summary>
        public virtual StripeList<Dispute> List(DisputeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Dispute>>(HttpMethod.Get, $"/v1/disputes", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your disputes.</p>.
        /// </summary>
        public virtual Task<StripeList<Dispute>> ListAsync(DisputeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Dispute>>(HttpMethod.Get, $"/v1/disputes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your disputes.</p>.
        /// </summary>
        public virtual IEnumerable<Dispute> ListAutoPaging(DisputeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Dispute>($"/v1/disputes", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your disputes.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Dispute> ListAutoPagingAsync(DisputeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Dispute>($"/v1/disputes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When you get a dispute, contacting your customer is always the best first step. If
        /// that doesn’t work, you can submit evidence to help us resolve the dispute in your favor.
        /// You can do this in your <a href="https://dashboard.stripe.com/disputes">dashboard</a>,
        /// but if you prefer, you can use the API to submit evidence programmatically.</p>.
        ///
        /// <p>Depending on your dispute type, different evidence fields will give you a better
        /// chance of winning your dispute. To figure out which evidence fields to provide, see our
        /// <a href="https://stripe.com/docs/disputes/categories">guide to dispute types</a>.</p>.
        /// </summary>
        public virtual Dispute Update(string id, DisputeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(HttpMethod.Post, $"/v1/disputes/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>When you get a dispute, contacting your customer is always the best first step. If
        /// that doesn’t work, you can submit evidence to help us resolve the dispute in your favor.
        /// You can do this in your <a href="https://dashboard.stripe.com/disputes">dashboard</a>,
        /// but if you prefer, you can use the API to submit evidence programmatically.</p>.
        ///
        /// <p>Depending on your dispute type, different evidence fields will give you a better
        /// chance of winning your dispute. To figure out which evidence fields to provide, see our
        /// <a href="https://stripe.com/docs/disputes/categories">guide to dispute types</a>.</p>.
        /// </summary>
        public virtual Task<Dispute> UpdateAsync(string id, DisputeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(HttpMethod.Post, $"/v1/disputes/{id}", options, requestOptions, cancellationToken);
        }
    }
}
