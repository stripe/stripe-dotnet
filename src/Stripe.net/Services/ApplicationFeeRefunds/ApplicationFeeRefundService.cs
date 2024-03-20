// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ApplicationFeeRefundService : ServiceNested<ApplicationFeeRefund>,
        INestedCreatable<ApplicationFeeRefund, ApplicationFeeRefundCreateOptions>,
        INestedListable<ApplicationFeeRefund, ApplicationFeeRefundListOptions>,
        INestedRetrievable<ApplicationFeeRefund, ApplicationFeeRefundGetOptions>,
        INestedUpdatable<ApplicationFeeRefund, ApplicationFeeRefundUpdateOptions>
    {
        public ApplicationFeeRefundService()
        {
        }

        public ApplicationFeeRefundService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/application_fees/{PARENT_ID}/refunds";

        /// <summary>
        /// <p>Refunds an application fee that has previously been collected but not yet refunded.
        /// Funds will be refunded to the Stripe account from which the fee was originally
        /// collected.</p>.
        ///
        /// <p>You can optionally refund only part of an application fee. You can do so multiple
        /// times, until the entire fee has been refunded.</p>.
        ///
        /// <p>Once entirely refunded, an application fee can’t be refunded again. This method will
        /// raise an error when called on an already-refunded application fee, or when trying to
        /// refund more money than is left on an application fee.</p>.
        /// </summary>
        public virtual ApplicationFeeRefund Create(string parentId, ApplicationFeeRefundCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ApplicationFeeRefund>(HttpMethod.Post, $"/v1/application_fees/{parentId}/refunds", options, requestOptions);
        }

        /// <summary>
        /// <p>Refunds an application fee that has previously been collected but not yet refunded.
        /// Funds will be refunded to the Stripe account from which the fee was originally
        /// collected.</p>.
        ///
        /// <p>You can optionally refund only part of an application fee. You can do so multiple
        /// times, until the entire fee has been refunded.</p>.
        ///
        /// <p>Once entirely refunded, an application fee can’t be refunded again. This method will
        /// raise an error when called on an already-refunded application fee, or when trying to
        /// refund more money than is left on an application fee.</p>.
        /// </summary>
        public virtual Task<ApplicationFeeRefund> CreateAsync(string parentId, ApplicationFeeRefundCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApplicationFeeRefund>(HttpMethod.Post, $"/v1/application_fees/{parentId}/refunds", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>By default, you can see the 10 most recent refunds stored directly on the application
        /// fee object, but you can also retrieve details about a specific refund stored on the
        /// application fee.</p>.
        /// </summary>
        public virtual ApplicationFeeRefund Get(string parentId, string id, ApplicationFeeRefundGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ApplicationFeeRefund>(HttpMethod.Get, $"/v1/application_fees/{parentId}/refunds/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>By default, you can see the 10 most recent refunds stored directly on the application
        /// fee object, but you can also retrieve details about a specific refund stored on the
        /// application fee.</p>.
        /// </summary>
        public virtual Task<ApplicationFeeRefund> GetAsync(string parentId, string id, ApplicationFeeRefundGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApplicationFeeRefund>(HttpMethod.Get, $"/v1/application_fees/{parentId}/refunds/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>You can see a list of the refunds belonging to a specific application fee. Note that
        /// the 10 most recent refunds are always available by default on the application fee
        /// object. If you need more than those 10, you can use this API method and the <c>limit</c>
        /// and <c>starting_after</c> parameters to page through additional refunds.</p>.
        /// </summary>
        public virtual StripeList<ApplicationFeeRefund> List(string parentId, ApplicationFeeRefundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ApplicationFeeRefund>>(HttpMethod.Get, $"/v1/application_fees/{parentId}/refunds", options, requestOptions);
        }

        /// <summary>
        /// <p>You can see a list of the refunds belonging to a specific application fee. Note that
        /// the 10 most recent refunds are always available by default on the application fee
        /// object. If you need more than those 10, you can use this API method and the <c>limit</c>
        /// and <c>starting_after</c> parameters to page through additional refunds.</p>.
        /// </summary>
        public virtual Task<StripeList<ApplicationFeeRefund>> ListAsync(string parentId, ApplicationFeeRefundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ApplicationFeeRefund>>(HttpMethod.Get, $"/v1/application_fees/{parentId}/refunds", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>You can see a list of the refunds belonging to a specific application fee. Note that
        /// the 10 most recent refunds are always available by default on the application fee
        /// object. If you need more than those 10, you can use this API method and the <c>limit</c>
        /// and <c>starting_after</c> parameters to page through additional refunds.</p>.
        /// </summary>
        public virtual IEnumerable<ApplicationFeeRefund> ListAutoPaging(string parentId, ApplicationFeeRefundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ApplicationFeeRefund>($"/v1/application_fees/{parentId}/refunds", options, requestOptions);
        }

        /// <summary>
        /// <p>You can see a list of the refunds belonging to a specific application fee. Note that
        /// the 10 most recent refunds are always available by default on the application fee
        /// object. If you need more than those 10, you can use this API method and the <c>limit</c>
        /// and <c>starting_after</c> parameters to page through additional refunds.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<ApplicationFeeRefund> ListAutoPagingAsync(string parentId, ApplicationFeeRefundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ApplicationFeeRefund>($"/v1/application_fees/{parentId}/refunds", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the specified application fee refund by setting the values of the parameters
        /// passed. Any parameters not provided will be left unchanged.</p>.
        ///
        /// <p>This request only accepts metadata as an argument.</p>.
        /// </summary>
        public virtual ApplicationFeeRefund Update(string parentId, string id, ApplicationFeeRefundUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ApplicationFeeRefund>(HttpMethod.Post, $"/v1/application_fees/{parentId}/refunds/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specified application fee refund by setting the values of the parameters
        /// passed. Any parameters not provided will be left unchanged.</p>.
        ///
        /// <p>This request only accepts metadata as an argument.</p>.
        /// </summary>
        public virtual Task<ApplicationFeeRefund> UpdateAsync(string parentId, string id, ApplicationFeeRefundUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApplicationFeeRefund>(HttpMethod.Post, $"/v1/application_fees/{parentId}/refunds/{id}", options, requestOptions, cancellationToken);
        }
    }
}
