namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class TopupService : Service<Topup>,
        ICreatable<Topup, TopupCreateOptions>,
        IListable<Topup, TopupListOptions>,
        IRetrievable<Topup>,
        IUpdatable<Topup, TopupUpdateOptions>
    {
        public TopupService(string apiKey = null)
            : base(apiKey)
        {
        }

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandSource { get; set; }

        public virtual Topup Cancel(string topupId, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/topups/{topupId}/cancel", requestOptions);
        }

        public virtual Topup Create(TopupCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/topups", requestOptions, options);
        }

        public virtual Topup Get(string topupId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/topups/{topupId}", requestOptions);
        }

        public virtual StripeList<Topup> List(TopupListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/topups", requestOptions, options);
        }

        public virtual Topup Update(string topupId, TopupUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/topups/{topupId}", requestOptions, options);
        }

        public virtual Task<Topup> CancelAsync(string topupId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/topups/{topupId}/cancel", requestOptions, cancellationToken);
        }

        public virtual Task<Topup> CreateAsync(TopupCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/topups", requestOptions, cancellationToken, options);
        }

        public virtual Task<Topup> GetAsync(string topupId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/topups/{topupId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<Topup>> ListAsync(TopupListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/topups", requestOptions, cancellationToken, options);
        }

        public virtual Task<Topup> UpdateAsync(string topupId, TopupUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/topups/{topupId}", requestOptions, cancellationToken);
        }
    }
}
