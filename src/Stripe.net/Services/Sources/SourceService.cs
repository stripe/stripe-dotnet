namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class SourceService : BasicService<Source>,
        ICreatable<Source, SourceCreateOptions>,
        IRetrievable<Source>,
        IUpdatable<Source, SourceUpdateOptions>
    {
        public SourceService()
            : base(null)
        {
        }

        public SourceService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Source Create(SourceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/sources", requestOptions, options);
        }

        public virtual Source Get(string sourceId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions);
        }

        public virtual Source Update(string sourceId, SourceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions, options);
        }

        public virtual Source Attach(string customerId, SourceAttachOptions attachOptions, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, attachOptions);
        }

        public virtual Source Detach(string customerId, string sourceId, RequestOptions requestOptions = null)
        {
            var url = $"{Urls.BaseUrl}/customers/{customerId}/sources/{sourceId}";

            return Mapper<Source>.MapFromJson(
                Requestor.Delete(url, this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<Source> List(string customerId, SourceListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.CustomerSources, customerId);

            if (listOptions == null)
            {
                listOptions = new SourceListOptions();
            }

            return Mapper<StripeList<Source>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, url, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Task<Source> CreateAsync(SourceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/sources", requestOptions, cancellationToken, options);
        }

        public virtual Task<Source> GetAsync(string sourceId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions, cancellationToken);
        }

        public virtual Task<Source> UpdateAsync(string sourceId, SourceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<Source> AttachAsync(string customerId, SourceAttachOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, cancellationToken, options);
        }

        public virtual async Task<Source> DetachAsync(string customerId, string sourceId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = $"{Urls.BaseUrl}/customers/{customerId}/sources/{sourceId}";

            return Mapper<Source>.MapFromJson(
                await Requestor.DeleteAsync(
                    url,
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<Source>> ListAsync(string customerId, SourceListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.CustomerSources, customerId);

            if (listOptions == null)
            {
                listOptions = new SourceListOptions();
            }

            return Mapper<StripeList<Source>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, url, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
