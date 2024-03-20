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
        {
        }

        public FormService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves the details of a tax form that has previously been created. Supply the
        /// unique tax form ID that was returned from your previous request, and Stripe will return
        /// the corresponding tax form information.</p>.
        /// </summary>
        public virtual Form Get(string id, FormGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Form>(HttpMethod.Get, $"/v1/tax/forms/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a tax form that has previously been created. Supply the
        /// unique tax form ID that was returned from your previous request, and Stripe will return
        /// the corresponding tax form information.</p>.
        /// </summary>
        public virtual Task<Form> GetAsync(string id, FormGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Form>(HttpMethod.Get, $"/v1/tax/forms/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of tax forms which were previously created. The tax forms are returned
        /// in sorted order, with the oldest tax forms appearing first.</p>.
        /// </summary>
        public virtual StripeList<Form> List(FormListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Form>>(HttpMethod.Get, $"/v1/tax/forms", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of tax forms which were previously created. The tax forms are returned
        /// in sorted order, with the oldest tax forms appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<Form>> ListAsync(FormListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Form>>(HttpMethod.Get, $"/v1/tax/forms", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of tax forms which were previously created. The tax forms are returned
        /// in sorted order, with the oldest tax forms appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<Form> ListAutoPaging(FormListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Form>($"/v1/tax/forms", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of tax forms which were previously created. The tax forms are returned
        /// in sorted order, with the oldest tax forms appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Form> ListAutoPagingAsync(FormListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Form>($"/v1/tax/forms", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Download the PDF for a tax form.</p>.
        /// </summary>
        public virtual Stream Pdf(string id, FormPdfOptions options = null, RequestOptions requestOptions = null)
        {
            requestOptions ??= new RequestOptions();
            if (requestOptions.BaseUrl == null)
            {
                requestOptions = requestOptions.Clone();
                requestOptions.BaseUrl = this.Client.FilesBase;
            }

            return this.RequestStreaming(HttpMethod.Get, $"/v1/tax/forms/{id}/pdf", options, requestOptions);
        }

        /// <summary>
        /// <p>Download the PDF for a tax form.</p>.
        /// </summary>
        public virtual Task<Stream> PdfAsync(string id, FormPdfOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            requestOptions ??= new RequestOptions();
            if (requestOptions.BaseUrl == null)
            {
                requestOptions = requestOptions.Clone();
                requestOptions.BaseUrl = this.Client.FilesBase;
            }

            return this.RequestStreamingAsync(HttpMethod.Get, $"/v1/tax/forms/{id}/pdf", options, requestOptions, cancellationToken);
        }
    }
}
