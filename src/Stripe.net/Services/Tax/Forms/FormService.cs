// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FormService : Service<Form>,
        IListable<Form, FormListOptions>,
        IRetrievable<Form, FormGetOptions>
    {
        public FormService()
            : base(null)
        {
        }

        public FormService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/tax/forms";

        public virtual Form Get(string id, FormGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Form> GetAsync(string id, FormGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Form> List(FormListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Form>> ListAsync(FormListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Form> ListAutoPaging(FormListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<Form> ListAutoPagingAsync(FormListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual Stream Pdf(string id, FormPdfOptions options = null, RequestOptions requestOptions = null)
        {
            requestOptions ??= new RequestOptions();
            requestOptions.BaseUrl ??= this.Client.FilesBase;
            return this.RequestStreaming(HttpMethod.Get, $"{this.InstanceUrl(id)}/pdf", options, requestOptions);
        }

        public virtual Task<Stream> PdfAsync(string id, FormPdfOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            requestOptions ??= new RequestOptions();
            requestOptions.BaseUrl ??= this.Client.FilesBase;
            return this.RequestStreamingAsync(HttpMethod.Get, $"{this.InstanceUrl(id)}/pdf", options, requestOptions, cancellationToken);
        }
    }
}
