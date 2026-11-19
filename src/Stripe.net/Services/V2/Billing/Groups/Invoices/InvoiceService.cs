// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.Groups
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InvoiceService : Service
    {
        internal InvoiceService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal InvoiceService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create an empty invoice using the billing group's settings.
        /// </summary>
        public virtual V2.Billing.GroupInvoice Create(string id, InvoiceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Billing.GroupInvoice>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/groups/{WebUtility.UrlEncode(id)}/invoices", options, requestOptions);
        }

        /// <summary>
        /// Create an empty invoice using the billing group's settings.
        /// </summary>
        public virtual Task<V2.Billing.GroupInvoice> CreateAsync(string id, InvoiceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Billing.GroupInvoice>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/groups/{WebUtility.UrlEncode(id)}/invoices", options, requestOptions, cancellationToken);
        }
    }
}
