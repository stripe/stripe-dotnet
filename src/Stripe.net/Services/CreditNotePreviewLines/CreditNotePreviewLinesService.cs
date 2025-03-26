// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreditNotePreviewLinesService : ServiceNested<CreditNoteLineItem>
    {
        public CreditNotePreviewLinesService()
        {
        }

        internal CreditNotePreviewLinesService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CreditNotePreviewLinesService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>When retrieving a credit note preview, you’ll get a <strong>lines</strong> property
        /// containing the first handful of those items. This URL you can retrieve the full
        /// (paginated) list of line items.</p>.
        /// </summary>
        public virtual StripeList<CreditNoteLineItem> List(CreditNotePreviewLinesListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CreditNoteLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/credit_notes/preview/lines", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a credit note preview, you’ll get a <strong>lines</strong> property
        /// containing the first handful of those items. This URL you can retrieve the full
        /// (paginated) list of line items.</p>.
        /// </summary>
        public virtual Task<StripeList<CreditNoteLineItem>> ListAsync(CreditNotePreviewLinesListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CreditNoteLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/credit_notes/preview/lines", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a credit note preview, you’ll get a <strong>lines</strong> property
        /// containing the first handful of those items. This URL you can retrieve the full
        /// (paginated) list of line items.</p>.
        /// </summary>
        public virtual IEnumerable<CreditNoteLineItem> ListAutoPaging(CreditNotePreviewLinesListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CreditNoteLineItem>($"/v1/credit_notes/preview/lines", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a credit note preview, you’ll get a <strong>lines</strong> property
        /// containing the first handful of those items. This URL you can retrieve the full
        /// (paginated) list of line items.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<CreditNoteLineItem> ListAutoPagingAsync(CreditNotePreviewLinesListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CreditNoteLineItem>($"/v1/credit_notes/preview/lines", options, requestOptions, cancellationToken);
        }
    }
}
