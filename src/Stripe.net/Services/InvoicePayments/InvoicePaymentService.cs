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

        public virtual InvoicePayment Get(string parentId, string id, InvoicePaymentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InvoicePayment>(HttpMethod.Get, $"/v1/invoices/{parentId}/payments/{id}", options, requestOptions);
        }

        public virtual Task<InvoicePayment> GetAsync(string parentId, string id, InvoicePaymentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoicePayment>(HttpMethod.Get, $"/v1/invoices/{parentId}/payments/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<InvoicePayment> List(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoicePayment>>(HttpMethod.Get, $"/v1/invoices/{parentId}/payments", options, requestOptions);
        }

        public virtual Task<StripeList<InvoicePayment>> ListAsync(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoicePayment>>(HttpMethod.Get, $"/v1/invoices/{parentId}/payments", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoicePayment> ListAutoPaging(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoicePayment>($"/v1/invoices/{parentId}/payments", options, requestOptions);
        }

        public virtual IAsyncEnumerable<InvoicePayment> ListAutoPagingAsync(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoicePayment>($"/v1/invoices/{parentId}/payments", options, requestOptions, cancellationToken);
        }
    }
}
