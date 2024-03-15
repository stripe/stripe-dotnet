// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InvoicePaymentService : ServiceNested<InvoicePayment>,
        INestedListable<InvoicePayment, InvoicePaymentListOptions>,
        INestedRetrievable<InvoicePayment, InvoicePaymentGetOptions>
    {
        public InvoicePaymentService()
            : base(null)
        {
        }

        public InvoicePaymentService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/invoices/{PARENT_ID}/payments";

        /// <summary>
        /// <p>Retrieves the invoice payment with the given ID.</p>.
        /// </summary>
        public virtual InvoicePayment Get(string parentId, string id, InvoicePaymentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InvoicePayment>(HttpMethod.Get, $"/v1/invoices/{parentId}/payments/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the invoice payment with the given ID.</p>.
        /// </summary>
        public virtual Task<InvoicePayment> GetAsync(string parentId, string id, InvoicePaymentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoicePayment>(HttpMethod.Get, $"/v1/invoices/{parentId}/payments/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving an invoice, there is an includable payments property containing the
        /// first handful of those items. There is also a URL where you can retrieve the full
        /// (paginated) list of payments.</p>.
        /// </summary>
        public virtual StripeList<InvoicePayment> List(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoicePayment>>(HttpMethod.Get, $"/v1/invoices/{parentId}/payments", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an invoice, there is an includable payments property containing the
        /// first handful of those items. There is also a URL where you can retrieve the full
        /// (paginated) list of payments.</p>.
        /// </summary>
        public virtual Task<StripeList<InvoicePayment>> ListAsync(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoicePayment>>(HttpMethod.Get, $"/v1/invoices/{parentId}/payments", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving an invoice, there is an includable payments property containing the
        /// first handful of those items. There is also a URL where you can retrieve the full
        /// (paginated) list of payments.</p>.
        /// </summary>
        public virtual IEnumerable<InvoicePayment> ListAutoPaging(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoicePayment>($"/v1/invoices/{parentId}/payments", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an invoice, there is an includable payments property containing the
        /// first handful of those items. There is also a URL where you can retrieve the full
        /// (paginated) list of payments.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<InvoicePayment> ListAutoPagingAsync(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoicePayment>($"/v1/invoices/{parentId}/payments", options, requestOptions, cancellationToken);
        }
    }
}
