// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FileService : Service<File>,
        ICreatable<File, FileCreateOptions>,
        IListable<File, FileListOptions>,
        IRetrievable<File, FileGetOptions>
    {
        public FileService()
        {
        }

        internal FileService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public FileService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>To upload a file to Stripe, you need to send a request of type
        /// <c>multipart/form-data</c>. Include the file you want to upload in the request, and the
        /// parameters for creating a file.</p>.
        ///
        /// <p>All of Stripe’s officially supported Client libraries support sending
        /// <c>multipart/form-data</c>.</p>.
        /// </summary>
        public virtual File Create(FileCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<File>(BaseAddress.Files, HttpMethod.Post, $"/v1/files", options, requestOptions);
        }

        /// <summary>
        /// <p>To upload a file to Stripe, you need to send a request of type
        /// <c>multipart/form-data</c>. Include the file you want to upload in the request, and the
        /// parameters for creating a file.</p>.
        ///
        /// <p>All of Stripe’s officially supported Client libraries support sending
        /// <c>multipart/form-data</c>.</p>.
        /// </summary>
        public virtual Task<File> CreateAsync(FileCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<File>(BaseAddress.Files, HttpMethod.Post, $"/v1/files", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing file object. After you supply a unique file ID,
        /// Stripe returns the corresponding file object. Learn how to <a
        /// href="https://stripe.com/docs/file-upload#download-file-contents">access file
        /// contents</a>.</p>.
        /// </summary>
        public virtual File Get(string id, FileGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<File>(BaseAddress.Api, HttpMethod.Get, $"/v1/files/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing file object. After you supply a unique file ID,
        /// Stripe returns the corresponding file object. Learn how to <a
        /// href="https://stripe.com/docs/file-upload#download-file-contents">access file
        /// contents</a>.</p>.
        /// </summary>
        public virtual Task<File> GetAsync(string id, FileGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<File>(BaseAddress.Api, HttpMethod.Get, $"/v1/files/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of the files that your account has access to. Stripe sorts and returns
        /// the files by their creation dates, placing the most recently created files at the
        /// top.</p>.
        /// </summary>
        public virtual StripeList<File> List(FileListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<File>>(BaseAddress.Api, HttpMethod.Get, $"/v1/files", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of the files that your account has access to. Stripe sorts and returns
        /// the files by their creation dates, placing the most recently created files at the
        /// top.</p>.
        /// </summary>
        public virtual Task<StripeList<File>> ListAsync(FileListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<File>>(BaseAddress.Api, HttpMethod.Get, $"/v1/files", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of the files that your account has access to. Stripe sorts and returns
        /// the files by their creation dates, placing the most recently created files at the
        /// top.</p>.
        /// </summary>
        public virtual IEnumerable<File> ListAutoPaging(FileListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<File>($"/v1/files", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of the files that your account has access to. Stripe sorts and returns
        /// the files by their creation dates, placing the most recently created files at the
        /// top.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<File> ListAutoPagingAsync(FileListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<File>($"/v1/files", options, requestOptions, cancellationToken);
        }
    }
}
