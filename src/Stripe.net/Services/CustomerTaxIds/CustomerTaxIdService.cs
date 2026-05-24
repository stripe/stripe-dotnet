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

    public class CustomerTaxIdService : Service,
        INestedCreatable<TaxId, CustomerTaxIdCreateOptions>,
        INestedDeletable<TaxId, CustomerTaxIdDeleteOptions>,
        INestedListable<TaxId, CustomerTaxIdListOptions>,
        INestedRetrievable<TaxId, CustomerTaxIdGetOptions>
    {
        public CustomerTaxIdService()
        {
        }

        internal CustomerTaxIdService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerTaxIdService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a new <c>tax_id</c> object for a customer.</p>.
        /// </summary>
        public virtual TaxId Create(string parentId, CustomerTaxIdCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxId>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_ids", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new <c>tax_id</c> object for a customer.</p>.
        /// </summary>
        public virtual Task<TaxId> CreateAsync(string parentId, CustomerTaxIdCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxId>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_ids", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Deletes an existing <c>tax_id</c> object.</p>.
        /// </summary>
        public virtual TaxId Delete(string parentId, string id, CustomerTaxIdDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxId>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_ids/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Deletes an existing <c>tax_id</c> object.</p>.
        /// </summary>
        public virtual Task<TaxId> DeleteAsync(string parentId, string id, CustomerTaxIdDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxId>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_ids/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the <c>tax_id</c> object with the given identifier.</p>.
        /// </summary>
        public virtual TaxId Get(string parentId, string id, CustomerTaxIdGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TaxId>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_ids/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the <c>tax_id</c> object with the given identifier.</p>.
        /// </summary>
        public virtual Task<TaxId> GetAsync(string parentId, string id, CustomerTaxIdGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TaxId>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_ids/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of tax IDs for a customer.</p>.
        /// </summary>
        public virtual StripeList<TaxId> List(string parentId, CustomerTaxIdListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TaxId>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_ids", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of tax IDs for a customer.</p>.
        /// </summary>
        public virtual Task<StripeList<TaxId>> ListAsync(string parentId, CustomerTaxIdListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TaxId>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_ids", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of tax IDs for a customer.</p>.
        /// </summary>
        public virtual IEnumerable<TaxId> ListAutoPaging(string parentId, CustomerTaxIdListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TaxId>($"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_ids", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of tax IDs for a customer.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<TaxId> ListAutoPagingAsync(string parentId, CustomerTaxIdListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TaxId>($"/v1/customers/{WebUtility.UrlEncode(parentId)}/tax_ids", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Serializes a CustomerTaxId create request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeBatchCreateForCustomer(string customer, CustomerTaxIdCreateOptions options = null, RequestOptions requestOptions = null)
        {
            var requestId = Guid.NewGuid().ToString();
            var stripeVersion = StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var requestBody = new Dictionary<string, object>
            {
                { "id", requestId },
                { "path_params", new Dictionary<string, string> { { "customer", customer } } },
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
        /// Serializes a CustomerTaxId delete request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeBatchDelete(string customer, string id, CustomerTaxIdDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            var requestId = Guid.NewGuid().ToString();
            var stripeVersion = StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var requestBody = new Dictionary<string, object>
            {
                { "id", requestId },
                { "path_params", new Dictionary<string, string> { { "customer", customer }, { "id", id } } },
                { "params", options },
                { "stripe_version", stripeVersion },
            };
            if (stripeContext != null)
            {
                requestBody["context"] = stripeContext;
            }

            return JsonSerializer.Serialize(requestBody, new JsonSerializerOptions(StripeConfiguration.SerializerOptions) { DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull });
        }
    }
}
