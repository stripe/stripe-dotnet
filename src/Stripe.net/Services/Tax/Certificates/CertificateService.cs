// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CertificateService : Service,
        ICreatable<Certificate, CertificateCreateOptions>,
        IDeletable<Certificate, CertificateDeleteOptions>,
        IListable<Certificate, CertificateListOptions>,
        IRetrievable<Certificate, CertificateGetOptions>
    {
        public CertificateService()
        {
        }

        internal CertificateService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CertificateService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Create a tax certificate associated with a tax exemption.</p>.
        /// </summary>
        public virtual Certificate Create(CertificateCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Certificate>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax/certificates", options, requestOptions);
        }

        /// <summary>
        /// <p>Create a tax certificate associated with a tax exemption.</p>.
        /// </summary>
        public virtual Task<Certificate> CreateAsync(CertificateCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Certificate>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax/certificates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Delete a tax certificate associated with a tax exemption.</p>.
        /// </summary>
        public virtual Certificate Delete(string id, CertificateDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Certificate>(BaseAddress.Api, HttpMethod.Delete, $"/v1/tax/certificates/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Delete a tax certificate associated with a tax exemption.</p>.
        /// </summary>
        public virtual Task<Certificate> DeleteAsync(string id, CertificateDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Certificate>(BaseAddress.Api, HttpMethod.Delete, $"/v1/tax/certificates/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a tax certificate associated with a tax exemption.</p>.
        /// </summary>
        public virtual Certificate Get(string id, CertificateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Certificate>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/certificates/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a tax certificate associated with a tax exemption.</p>.
        /// </summary>
        public virtual Task<Certificate> GetAsync(string id, CertificateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Certificate>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/certificates/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List certificates for an existing tax exemption.</p>.
        /// </summary>
        public virtual StripeList<Certificate> List(CertificateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Certificate>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/certificates", options, requestOptions);
        }

        /// <summary>
        /// <p>List certificates for an existing tax exemption.</p>.
        /// </summary>
        public virtual Task<StripeList<Certificate>> ListAsync(CertificateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Certificate>>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/certificates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List certificates for an existing tax exemption.</p>.
        /// </summary>
        public virtual IEnumerable<Certificate> ListAutoPaging(CertificateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Certificate>($"/v1/tax/certificates", options, requestOptions);
        }

        /// <summary>
        /// <p>List certificates for an existing tax exemption.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Certificate> ListAutoPagingAsync(CertificateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Certificate>($"/v1/tax/certificates", options, requestOptions, cancellationToken);
        }
    }
}
