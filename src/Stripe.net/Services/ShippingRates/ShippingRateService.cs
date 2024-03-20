// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ShippingRateService : Service<ShippingRate>,
        ICreatable<ShippingRate, ShippingRateCreateOptions>,
        IListable<ShippingRate, ShippingRateListOptions>,
        IRetrievable<ShippingRate, ShippingRateGetOptions>,
        IUpdatable<ShippingRate, ShippingRateUpdateOptions>
    {
        public ShippingRateService()
        {
        }

        public ShippingRateService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/shipping_rates";

        /// <summary>
        /// <p>Creates a new shipping rate object.</p>.
        /// </summary>
        public virtual ShippingRate Create(ShippingRateCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ShippingRate>(HttpMethod.Post, $"/v1/shipping_rates", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new shipping rate object.</p>.
        /// </summary>
        public virtual Task<ShippingRate> CreateAsync(ShippingRateCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ShippingRate>(HttpMethod.Post, $"/v1/shipping_rates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns the shipping rate object with the given ID.</p>.
        /// </summary>
        public virtual ShippingRate Get(string id, ShippingRateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ShippingRate>(HttpMethod.Get, $"/v1/shipping_rates/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns the shipping rate object with the given ID.</p>.
        /// </summary>
        public virtual Task<ShippingRate> GetAsync(string id, ShippingRateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ShippingRate>(HttpMethod.Get, $"/v1/shipping_rates/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your shipping rates.</p>.
        /// </summary>
        public virtual StripeList<ShippingRate> List(ShippingRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ShippingRate>>(HttpMethod.Get, $"/v1/shipping_rates", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your shipping rates.</p>.
        /// </summary>
        public virtual Task<StripeList<ShippingRate>> ListAsync(ShippingRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ShippingRate>>(HttpMethod.Get, $"/v1/shipping_rates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your shipping rates.</p>.
        /// </summary>
        public virtual IEnumerable<ShippingRate> ListAutoPaging(ShippingRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ShippingRate>($"/v1/shipping_rates", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your shipping rates.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<ShippingRate> ListAutoPagingAsync(ShippingRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ShippingRate>($"/v1/shipping_rates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates an existing shipping rate object.</p>.
        /// </summary>
        public virtual ShippingRate Update(string id, ShippingRateUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ShippingRate>(HttpMethod.Post, $"/v1/shipping_rates/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates an existing shipping rate object.</p>.
        /// </summary>
        public virtual Task<ShippingRate> UpdateAsync(string id, ShippingRateUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ShippingRate>(HttpMethod.Post, $"/v1/shipping_rates/{id}", options, requestOptions, cancellationToken);
        }
    }
}
