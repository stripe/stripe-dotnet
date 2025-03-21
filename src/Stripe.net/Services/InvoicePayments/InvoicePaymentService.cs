// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InvoicePaymentService : Service,
        INestedListable<InvoicePayment, InvoicePaymentListOptions>,
        INestedRetrievable<InvoicePayment, InvoicePaymentGetOptions>
    {
        public InvoicePaymentService()
        {
        }

        internal InvoicePaymentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public InvoicePaymentService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves the invoice payment with the given ID.</p>.
        /// </summary>
        public virtual InvoicePayment Get(string parentId, string id, InvoicePaymentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InvoicePayment>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/{WebUtility.UrlEncode(parentId)}/payments/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the invoice payment with the given ID.</p>.
        /// </summary>
        public virtual Task<InvoicePayment> GetAsync(string parentId, string id, InvoicePaymentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoicePayment>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/{WebUtility.UrlEncode(parentId)}/payments/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving an invoice, there is an includable payments property containing the
        /// first handful of those items. There is also a URL where you can retrieve the full
        /// (paginated) list of payments.</p>.
        /// </summary>
        public virtual StripeList<InvoicePayment> List(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoicePayment>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/{WebUtility.UrlEncode(parentId)}/payments", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an invoice, there is an includable payments property containing the
        /// first handful of those items. There is also a URL where you can retrieve the full
        /// (paginated) list of payments.</p>.
        /// </summary>
        public virtual Task<StripeList<InvoicePayment>> ListAsync(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoicePayment>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/{WebUtility.UrlEncode(parentId)}/payments", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving an invoice, there is an includable payments property containing the
        /// first handful of those items. There is also a URL where you can retrieve the full
        /// (paginated) list of payments.</p>.
        /// </summary>
        public virtual IEnumerable<InvoicePayment> ListAutoPaging(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoicePayment>($"/v1/invoices/{WebUtility.UrlEncode(parentId)}/payments", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an invoice, there is an includable payments property containing the
        /// first handful of those items. There is also a URL where you can retrieve the full
        /// (paginated) list of payments.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<InvoicePayment> ListAutoPagingAsync(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoicePayment>($"/v1/invoices/{WebUtility.UrlEncode(parentId)}/payments", options, requestOptions, cancellationToken);
        }
    }
}
