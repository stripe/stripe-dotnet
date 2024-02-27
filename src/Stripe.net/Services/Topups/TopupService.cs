// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TopupService : Service<Topup>,
        ICreatable<Topup, TopupCreateOptions>,
        IListable<Topup, TopupListOptions>,
        IRetrievable<Topup, TopupGetOptions>,
        IUpdatable<Topup, TopupUpdateOptions>
    {
        public TopupService()
            : base(null)
        {
        }

        public TopupService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/topups";

        public virtual Topup Cancel(string id, TopupCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Topup>(HttpMethod.Post, $"/v1/topups/{id}/cancel", options, requestOptions);
        }

        public virtual Task<Topup> CancelAsync(string id, TopupCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Topup>(HttpMethod.Post, $"/v1/topups/{id}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual Topup Create(TopupCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Topup>(HttpMethod.Post, $"/v1/topups", options, requestOptions);
        }

        public virtual Task<Topup> CreateAsync(TopupCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Topup>(HttpMethod.Post, $"/v1/topups", options, requestOptions, cancellationToken);
        }

        public virtual Topup Get(string id, TopupGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Topup>(HttpMethod.Get, $"/v1/topups/{id}", options, requestOptions);
        }

        public virtual Task<Topup> GetAsync(string id, TopupGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Topup>(HttpMethod.Get, $"/v1/topups/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Topup> List(TopupListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Topup>>(HttpMethod.Get, $"/v1/topups", options, requestOptions);
        }

        public virtual Task<StripeList<Topup>> ListAsync(TopupListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Topup>>(HttpMethod.Get, $"/v1/topups", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Topup> ListAutoPaging(TopupListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Topup>($"/v1/topups", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Topup> ListAutoPagingAsync(TopupListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Topup>($"/v1/topups", options, requestOptions, cancellationToken);
        }

        public virtual Topup Update(string id, TopupUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Topup>(HttpMethod.Post, $"/v1/topups/{id}", options, requestOptions);
        }

        public virtual Task<Topup> UpdateAsync(string id, TopupUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Topup>(HttpMethod.Post, $"/v1/topups/{id}", options, requestOptions, cancellationToken);
        }
    }
}
