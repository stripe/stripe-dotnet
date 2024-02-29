// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
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

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/tax/forms";

        public virtual Form Get(string id, FormGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Form>(HttpMethod.Get, $"/v1/tax/forms/{id}", options, requestOptions);
        }

        public virtual Task<Form> GetAsync(string id, FormGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Form>(HttpMethod.Get, $"/v1/tax/forms/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Form> List(FormListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Form>>(HttpMethod.Get, $"/v1/tax/forms", options, requestOptions);
        }

        public virtual Task<StripeList<Form>> ListAsync(FormListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Form>>(HttpMethod.Get, $"/v1/tax/forms", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Form> ListAutoPaging(FormListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Form>($"/v1/tax/forms", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Form> ListAutoPagingAsync(FormListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Form>($"/v1/tax/forms", options, requestOptions, cancellationToken);
        }

        public virtual Stream Pdf(string id, FormPdfOptions options = null, RequestOptions requestOptions = null)
        {
            requestOptions ??= new RequestOptions();
            requestOptions.BaseUrl ??= this.Client.FilesBase;
            return this.RequestStreaming(HttpMethod.Get, $"/v1/tax/forms/{id}/pdf", options, requestOptions);
        }

        public virtual Task<Stream> PdfAsync(string id, FormPdfOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            requestOptions ??= new RequestOptions();
            requestOptions.BaseUrl ??= this.Client.FilesBase;
            return this.RequestStreamingAsync(HttpMethod.Get, $"/v1/tax/forms/{id}/pdf", options, requestOptions, cancellationToken);
        }
    }
}
