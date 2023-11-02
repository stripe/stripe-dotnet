// File generated from our OpenAPI spec
namespace Stripe
{
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
            : base(null)
        {
        }

        public ShippingRateService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/shipping_rates";

        public virtual ShippingRate Create(ShippingRateCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ShippingRate>(HttpMethod.Post, $"/v1/shipping_rates", options, requestOptions);
        }

        public virtual Task<ShippingRate> CreateAsync(ShippingRateCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ShippingRate>(HttpMethod.Post, $"/v1/shipping_rates", options, requestOptions, cancellationToken);
        }

        public virtual ShippingRate Get(string id, ShippingRateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ShippingRate>(HttpMethod.Get, $"/v1/shipping_rates/{id}", options, requestOptions);
        }

        public virtual Task<ShippingRate> GetAsync(string id, ShippingRateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ShippingRate>(HttpMethod.Get, $"/v1/shipping_rates/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ShippingRate> List(ShippingRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ShippingRate>>(HttpMethod.Get, $"/v1/shipping_rates", options, requestOptions);
        }

        public virtual Task<StripeList<ShippingRate>> ListAsync(ShippingRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ShippingRate>>(HttpMethod.Get, $"/v1/shipping_rates", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ShippingRate> ListAutoPaging(ShippingRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ShippingRate>($"/v1/shipping_rates", options, requestOptions);
        }

        public virtual IAsyncEnumerable<ShippingRate> ListAutoPagingAsync(ShippingRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ShippingRate>($"/v1/shipping_rates", options, requestOptions, cancellationToken);
        }

        public virtual ShippingRate Update(string id, ShippingRateUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ShippingRate>(HttpMethod.Post, $"/v1/shipping_rates/{id}", options, requestOptions);
        }

        public virtual Task<ShippingRate> UpdateAsync(string id, ShippingRateUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ShippingRate>(HttpMethod.Post, $"/v1/shipping_rates/{id}", options, requestOptions, cancellationToken);
        }
    }
}
