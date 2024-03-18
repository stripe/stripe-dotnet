// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RefundService : Service<Refund>,
        ICreatable<Refund, RefundCreateOptions>,
        IListable<Refund, RefundListOptions>,
        IRetrievable<Refund, RefundGetOptions>,
        IUpdatable<Refund, RefundUpdateOptions>
    {
        public RefundService()
        {
        }

        public RefundService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/refunds";

        /// <summary>
        /// <p>Cancels a refund with a status of <c>requires_action</c>.</p>.
        ///
        /// <p>You can’t cancel refunds in other states. Only refunds for payment methods that
        /// require customer action can enter the <c>requires_action</c> state.</p>.
        /// </summary>
        public virtual Refund Cancel(string id, RefundCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Refund>(HttpMethod.Post, $"/v1/refunds/{id}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>Cancels a refund with a status of <c>requires_action</c>.</p>.
        ///
        /// <p>You can’t cancel refunds in other states. Only refunds for payment methods that
        /// require customer action can enter the <c>requires_action</c> state.</p>.
        /// </summary>
        public virtual Task<Refund> CancelAsync(string id, RefundCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Refund>(HttpMethod.Post, $"/v1/refunds/{id}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When you create a new refund, you must specify a Charge or a PaymentIntent object on
        /// which to create it.</p>.
        ///
        /// <p>Creating a new refund will refund a charge that has previously been created but not
        /// yet refunded. Funds will be refunded to the credit or debit card that was originally
        /// charged.</p>.
        ///
        /// <p>You can optionally refund only part of a charge. You can do so multiple times, until
        /// the entire charge has been refunded.</p>.
        ///
        /// <p>Once entirely refunded, a charge can’t be refunded again. This method will raise an
        /// error when called on an already-refunded charge, or when trying to refund more money
        /// than is left on a charge.</p>.
        /// </summary>
        public virtual Refund Create(RefundCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Refund>(HttpMethod.Post, $"/v1/refunds", options, requestOptions);
        }

        /// <summary>
        /// <p>When you create a new refund, you must specify a Charge or a PaymentIntent object on
        /// which to create it.</p>.
        ///
        /// <p>Creating a new refund will refund a charge that has previously been created but not
        /// yet refunded. Funds will be refunded to the credit or debit card that was originally
        /// charged.</p>.
        ///
        /// <p>You can optionally refund only part of a charge. You can do so multiple times, until
        /// the entire charge has been refunded.</p>.
        ///
        /// <p>Once entirely refunded, a charge can’t be refunded again. This method will raise an
        /// error when called on an already-refunded charge, or when trying to refund more money
        /// than is left on a charge.</p>.
        /// </summary>
        public virtual Task<Refund> CreateAsync(RefundCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Refund>(HttpMethod.Post, $"/v1/refunds", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing refund.</p>.
        /// </summary>
        public virtual Refund Get(string id, RefundGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Refund>(HttpMethod.Get, $"/v1/refunds/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing refund.</p>.
        /// </summary>
        public virtual Task<Refund> GetAsync(string id, RefundGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Refund>(HttpMethod.Get, $"/v1/refunds/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of all refunds you created. We return the refunds in sorted order,
        /// with the most recent refunds appearing first The 10 most recent refunds are always
        /// available by default on the Charge object.</p>.
        /// </summary>
        public virtual StripeList<Refund> List(RefundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Refund>>(HttpMethod.Get, $"/v1/refunds", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of all refunds you created. We return the refunds in sorted order,
        /// with the most recent refunds appearing first The 10 most recent refunds are always
        /// available by default on the Charge object.</p>.
        /// </summary>
        public virtual Task<StripeList<Refund>> ListAsync(RefundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Refund>>(HttpMethod.Get, $"/v1/refunds", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of all refunds you created. We return the refunds in sorted order,
        /// with the most recent refunds appearing first The 10 most recent refunds are always
        /// available by default on the Charge object.</p>.
        /// </summary>
        public virtual IEnumerable<Refund> ListAutoPaging(RefundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Refund>($"/v1/refunds", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of all refunds you created. We return the refunds in sorted order,
        /// with the most recent refunds appearing first The 10 most recent refunds are always
        /// available by default on the Charge object.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Refund> ListAutoPagingAsync(RefundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Refund>($"/v1/refunds", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the refund that you specify by setting the values of the passed parameters.
        /// Any parameters that you don’t provide remain unchanged.</p>.
        ///
        /// <p>This request only accepts <c>metadata</c> as an argument.</p>.
        /// </summary>
        public virtual Refund Update(string id, RefundUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Refund>(HttpMethod.Post, $"/v1/refunds/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the refund that you specify by setting the values of the passed parameters.
        /// Any parameters that you don’t provide remain unchanged.</p>.
        ///
        /// <p>This request only accepts <c>metadata</c> as an argument.</p>.
        /// </summary>
        public virtual Task<Refund> UpdateAsync(string id, RefundUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Refund>(HttpMethod.Post, $"/v1/refunds/{id}", options, requestOptions, cancellationToken);
        }
    }
}
