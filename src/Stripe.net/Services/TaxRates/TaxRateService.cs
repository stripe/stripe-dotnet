// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading;
    using System.Threading.Tasks;

    public class TaxRateService : Service,
        ICreatable<TaxRate, TaxRateCreateOptions>,
        IListable<TaxRate, TaxRateListOptions>,
        IRetrievable<TaxRate, TaxRateGetOptions>,
        IUpdatable<TaxRate, TaxRateUpdateOptions>
    {
        public TaxRateService()
        {
        }

        internal TaxRateService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public TaxRateService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a new tax rate.</p>.
        /// </summary>
        public virtual TaxRate Create(TaxRateCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<TaxRate>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax_rates", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new tax rate.</p>.
        /// </summary>
        public virtual Task<TaxRate> CreateAsync(TaxRateCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxRate>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax_rates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a tax rate with the given ID</p>.
        /// </summary>
        public virtual TaxRate Get(string id, TaxRateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxRate>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_rates/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a tax rate with the given ID</p>.
        /// </summary>
        public virtual Task<TaxRate> GetAsync(string id, TaxRateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxRate>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_rates/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your tax rates. Tax rates are returned sorted by creation date,
        /// with the most recently created tax rates appearing first.</p>.
        /// </summary>
        public virtual StripeList<TaxRate> List(TaxRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TaxRate>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_rates", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your tax rates. Tax rates are returned sorted by creation date,
        /// with the most recently created tax rates appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<TaxRate>> ListAsync(TaxRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TaxRate>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax_rates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your tax rates. Tax rates are returned sorted by creation date,
        /// with the most recently created tax rates appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<TaxRate> ListAutoPaging(TaxRateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TaxRate>($"/v1/tax_rates", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your tax rates. Tax rates are returned sorted by creation date,
        /// with the most recently created tax rates appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<TaxRate> ListAutoPagingAsync(TaxRateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TaxRate>($"/v1/tax_rates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Serializes a TaxRate create request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeBatchCreate(TaxRateCreateOptions options = null, RequestOptions requestOptions = null)
        {
            var requestId = Guid.NewGuid().ToString();
            var stripeVersion = StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var requestBody = new Dictionary<string, object>
            {
                { "id", requestId },
                { "path_params", null },
                { "params", options },
                { "stripe_version", stripeVersion },
            };
            if (stripeContext != null)
            {
                requestBody["context"] = stripeContext;
            }

            return JsonSerializer.Serialize(requestBody, new JsonSerializerOptions(StripeConfiguration.SerializerOptions) { DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull });
        }

        /// <summary>
        /// Serializes a TaxRate update request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeBatchUpdate(string taxRate, TaxRateUpdateOptions options = null, RequestOptions requestOptions = null)
        {
            var requestId = Guid.NewGuid().ToString();
            var stripeVersion = StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var requestBody = new Dictionary<string, object>
            {
                { "id", requestId },
                { "path_params", new Dictionary<string, string> { { "tax_rate", taxRate } } },
                { "params", options },
                { "stripe_version", stripeVersion },
            };
            if (stripeContext != null)
            {
                requestBody["context"] = stripeContext;
            }

            return JsonSerializer.Serialize(requestBody, new JsonSerializerOptions(StripeConfiguration.SerializerOptions) { DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull });
        }

        /// <summary>
        /// <p>Updates an existing tax rate.</p>.
        /// </summary>
        public virtual TaxRate Update(string id, TaxRateUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<TaxRate>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax_rates/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates an existing tax rate.</p>.
        /// </summary>
        public virtual Task<TaxRate> UpdateAsync(string id, TaxRateUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxRate>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax_rates/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
