namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class SourceService : Service<Source>,
        ICreatable<Source, SourceCreateOptions>,
        IRetrievable<Source, SourceGetOptions>,
        IUpdatable<Source, SourceUpdateOptions>,
        INestedListable<Source, SourceListOptions>
    {
        public SourceService()
            : base()
        {
        }

        internal SourceService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public SourceService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Source Create(SourceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/sources", options, requestOptions);
        }

        public virtual Task<Source> CreateAsync(SourceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/sources", options, requestOptions, cancellationToken);
        }

        public virtual Source Get(string id, SourceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(BaseAddress.Api, HttpMethod.Get, $"/v1/sources/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        public virtual Task<Source> GetAsync(string id, SourceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Source>(BaseAddress.Api, HttpMethod.Get, $"/v1/sources/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        public virtual Source Update(string id, SourceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/sources/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        public virtual Task<Source> UpdateAsync(string id, SourceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/sources/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        public virtual Source Verify(string id, SourceVerifyOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/sources/{WebUtility.UrlEncode(id)}/verify", options, requestOptions);
        }

        public virtual Task<Source> VerifyAsync(string id, SourceVerifyOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Source>(BaseAddress.Api, HttpMethod.Post, $"/v1/sources/{WebUtility.UrlEncode(id)}/verify", options, requestOptions, cancellationToken);
        }
    }
}
