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
        {
        }

        public PromotionCodeService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/promotion_codes";

        /// <summary>
        /// <p>A promotion code points to a coupon. You can optionally restrict the code to a
        /// specific customer, redemption limit, and expiration date.</p>.
        /// </summary>
        public virtual PromotionCode Create(PromotionCodeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PromotionCode>(HttpMethod.Post, $"/v1/promotion_codes", options, requestOptions);
        }

        /// <summary>
        /// <p>A promotion code points to a coupon. You can optionally restrict the code to a
        /// specific customer, redemption limit, and expiration date.</p>.
        /// </summary>
        public virtual Task<PromotionCode> CreateAsync(PromotionCodeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PromotionCode>(HttpMethod.Post, $"/v1/promotion_codes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the promotion code with the given ID. In order to retrieve a promotion code
        /// by the customer-facing <c>code</c> use <a
        /// href="https://stripe.com/docs/api/promotion_codes/list">list</a> with the desired
        /// <c>code</c>.</p>.
        /// </summary>
        public virtual PromotionCode Get(string id, PromotionCodeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PromotionCode>(HttpMethod.Get, $"/v1/promotion_codes/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the promotion code with the given ID. In order to retrieve a promotion code
        /// by the customer-facing <c>code</c> use <a
        /// href="https://stripe.com/docs/api/promotion_codes/list">list</a> with the desired
        /// <c>code</c>.</p>.
        /// </summary>
        public virtual Task<PromotionCode> GetAsync(string id, PromotionCodeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PromotionCode>(HttpMethod.Get, $"/v1/promotion_codes/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your promotion codes.</p>.
        /// </summary>
        public virtual StripeList<PromotionCode> List(PromotionCodeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PromotionCode>>(HttpMethod.Get, $"/v1/promotion_codes", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your promotion codes.</p>.
        /// </summary>
        public virtual Task<StripeList<PromotionCode>> ListAsync(PromotionCodeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PromotionCode>>(HttpMethod.Get, $"/v1/promotion_codes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your promotion codes.</p>.
        /// </summary>
        public virtual IEnumerable<PromotionCode> ListAutoPaging(PromotionCodeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PromotionCode>($"/v1/promotion_codes", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your promotion codes.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<PromotionCode> ListAutoPagingAsync(PromotionCodeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PromotionCode>($"/v1/promotion_codes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the specified promotion code by setting the values of the parameters passed.
        /// Most fields are, by design, not editable.</p>.
        /// </summary>
        public virtual PromotionCode Update(string id, PromotionCodeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PromotionCode>(HttpMethod.Post, $"/v1/promotion_codes/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specified promotion code by setting the values of the parameters passed.
        /// Most fields are, by design, not editable.</p>.
        /// </summary>
        public virtual Task<PromotionCode> UpdateAsync(string id, PromotionCodeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PromotionCode>(HttpMethod.Post, $"/v1/promotion_codes/{id}", options, requestOptions, cancellationToken);
        }
    }
}
