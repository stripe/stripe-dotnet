// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.RateCards
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RateService : Service
    {
        internal RateService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal RateService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Set the Rate for a Metered Item on the latest version of a Rate Card object. This will
        /// create a new Rate Card version if the Metered Item already has a rate on the Rate Card.
        /// </summary>
        public virtual V2.Billing.RateCardRate Create(string id, RateCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.RateCardRate>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/rates", options, requestOptions);
        }

        /// <summary>
        /// Set the Rate for a Metered Item on the latest version of a Rate Card object. This will
        /// create a new Rate Card version if the Metered Item already has a rate on the Rate Card.
        /// </summary>
        public virtual Task<V2.Billing.RateCardRate> CreateAsync(string id, RateCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.RateCardRate>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/rates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Remove an existing Rate from a Rate Card. This will create a new Rate Card Version
        /// without that Rate.
        /// </summary>
        public virtual V2.DeletedObject Delete(string parentId, string id, RateDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.DeletedObject>(BaseAddress.Api, HttpMethod.Delete, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(parentId)}/rates/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Remove an existing Rate from a Rate Card. This will create a new Rate Card Version
        /// without that Rate.
        /// </summary>
        public virtual Task<V2.DeletedObject> DeleteAsync(string parentId, string id, RateDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.DeletedObject>(BaseAddress.Api, HttpMethod.Delete, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(parentId)}/rates/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a Rate object.
        /// </summary>
        public virtual V2.Billing.RateCardRate Get(string parentId, string id, RateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.RateCardRate>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(parentId)}/rates/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a Rate object.
        /// </summary>
        public virtual Task<V2.Billing.RateCardRate> GetAsync(string parentId, string id, RateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.RateCardRate>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(parentId)}/rates/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Rates associated with a Rate Card for a specific version (defaults to latest).
        /// Rates remain active for all subsequent versions until a new rate is created for the same
        /// Metered Item.
        /// </summary>
        public virtual V2.StripeList<V2.Billing.RateCardRate> List(string id, RateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Billing.RateCardRate>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/rates", options, requestOptions);
        }

        /// <summary>
        /// List all Rates associated with a Rate Card for a specific version (defaults to latest).
        /// Rates remain active for all subsequent versions until a new rate is created for the same
        /// Metered Item.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Billing.RateCardRate>> ListAsync(string id, RateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Billing.RateCardRate>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/rates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Rates associated with a Rate Card for a specific version (defaults to latest).
        /// Rates remain active for all subsequent versions until a new rate is created for the same
        /// Metered Item.
        /// </summary>
        public virtual IEnumerable<V2.Billing.RateCardRate> ListAutoPaging(string id, RateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Billing.RateCardRate>($"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/rates", options, requestOptions);
        }

        /// <summary>
        /// List all Rates associated with a Rate Card for a specific version (defaults to latest).
        /// Rates remain active for all subsequent versions until a new rate is created for the same
        /// Metered Item.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Billing.RateCardRate> ListAutoPagingAsync(string id, RateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Billing.RateCardRate>($"/v2/billing/rate_cards/{WebUtility.UrlEncode(id)}/rates", options, requestOptions, cancellationToken);
        }
    }
}
