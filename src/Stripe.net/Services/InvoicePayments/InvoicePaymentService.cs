// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
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

        public override string BasePath => "/v1/invoices/{PARENT_ID}/payments";

        public virtual InvoicePayment Get(string parentId, string id, InvoicePaymentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(parentId, id, options, requestOptions);
        }

        public virtual Task<InvoicePayment> GetAsync(string parentId, string id, InvoicePaymentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<InvoicePayment> List(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(parentId, options, requestOptions);
        }

        public virtual Task<StripeList<InvoicePayment>> ListAsync(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoicePayment> ListAutoPaging(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(parentId, options, requestOptions);
        }

        public virtual IAsyncEnumerable<InvoicePayment> ListAutoPagingAsync(string parentId, InvoicePaymentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(parentId, options, requestOptions, cancellationToken);
        }
    }
}
