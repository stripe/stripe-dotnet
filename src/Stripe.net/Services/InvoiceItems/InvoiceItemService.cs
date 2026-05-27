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

    public class InvoiceItemService : Service,
        ICreatable<InvoiceItem, InvoiceItemCreateOptions>,
        IDeletable<InvoiceItem, InvoiceItemDeleteOptions>,
        IListable<InvoiceItem, InvoiceItemListOptions>,
        IRetrievable<InvoiceItem, InvoiceItemGetOptions>,
        IUpdatable<InvoiceItem, InvoiceItemUpdateOptions>
    {
        public InvoiceItemService()
        {
        }

        internal InvoiceItemService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public InvoiceItemService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates an item to be added to a draft invoice (up to 250 items per invoice). If no
        /// invoice is specified, the item will be on the next invoice created for the customer
        /// specified.</p>.
        /// </summary>
        public virtual InvoiceItem Create(InvoiceItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<InvoiceItem>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoiceitems", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates an item to be added to a draft invoice (up to 250 items per invoice). If no
        /// invoice is specified, the item will be on the next invoice created for the customer
        /// specified.</p>.
        /// </summary>
        public virtual Task<InvoiceItem> CreateAsync(InvoiceItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoiceItem>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoiceitems", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Deletes an invoice item, removing it from an invoice. Deleting invoice items is only
        /// possible when they’re not attached to invoices, or if it’s attached to a draft
        /// invoice.</p>.
        /// </summary>
        public virtual InvoiceItem Delete(string id, InvoiceItemDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InvoiceItem>(BaseAddress.Api, HttpMethod.Delete, $"/v1/invoiceitems/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Deletes an invoice item, removing it from an invoice. Deleting invoice items is only
        /// possible when they’re not attached to invoices, or if it’s attached to a draft
        /// invoice.</p>.
        /// </summary>
        public virtual Task<InvoiceItem> DeleteAsync(string id, InvoiceItemDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoiceItem>(BaseAddress.Api, HttpMethod.Delete, $"/v1/invoiceitems/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the invoice item with the given ID.</p>.
        /// </summary>
        public virtual InvoiceItem Get(string id, InvoiceItemGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InvoiceItem>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoiceitems/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the invoice item with the given ID.</p>.
        /// </summary>
        public virtual Task<InvoiceItem> GetAsync(string id, InvoiceItemGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoiceItem>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoiceitems/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your invoice items. Invoice items are returned sorted by creation
        /// date, with the most recently created invoice items appearing first.</p>.
        /// </summary>
        public virtual StripeList<InvoiceItem> List(InvoiceItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoiceitems", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your invoice items. Invoice items are returned sorted by creation
        /// date, with the most recently created invoice items appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<InvoiceItem>> ListAsync(InvoiceItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoiceitems", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your invoice items. Invoice items are returned sorted by creation
        /// date, with the most recently created invoice items appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<InvoiceItem> ListAutoPaging(InvoiceItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceItem>($"/v1/invoiceitems", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your invoice items. Invoice items are returned sorted by creation
        /// date, with the most recently created invoice items appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<InvoiceItem> ListAutoPagingAsync(InvoiceItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceItem>($"/v1/invoiceitems", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Serializes an InvoiceItem create request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeBatchCreate(InvoiceItemCreateOptions options = null, RequestOptions requestOptions = null)
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
        /// Serializes an InvoiceItem delete request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeBatchDelete(string invoiceitem, InvoiceItemDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            var requestId = Guid.NewGuid().ToString();
            var stripeVersion = StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var requestBody = new Dictionary<string, object>
            {
                { "id", requestId },
                { "path_params", new Dictionary<string, string> { { "invoiceitem", invoiceitem } } },
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
        /// Serializes an InvoiceItem update request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeBatchUpdate(string invoiceitem, InvoiceItemUpdateOptions options = null, RequestOptions requestOptions = null)
        {
            var requestId = Guid.NewGuid().ToString();
            var stripeVersion = StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var requestBody = new Dictionary<string, object>
            {
                { "id", requestId },
                { "path_params", new Dictionary<string, string> { { "invoiceitem", invoiceitem } } },
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
        /// <p>Updates the amount or description of an invoice item on an upcoming invoice. Updating
        /// an invoice item is only possible before the invoice it’s attached to is closed.</p>.
        /// </summary>
        public virtual InvoiceItem Update(string id, InvoiceItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<InvoiceItem>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoiceitems/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the amount or description of an invoice item on an upcoming invoice. Updating
        /// an invoice item is only possible before the invoice it’s attached to is closed.</p>.
        /// </summary>
        public virtual Task<InvoiceItem> UpdateAsync(string id, InvoiceItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoiceItem>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoiceitems/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
