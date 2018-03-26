using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSourceService : StripeBasicService<StripeSource>
    {
        public StripeSourceService() : base(null) { }
        public StripeSourceService(string apiKey) : base(apiKey) { }



        // Sync
        public virtual StripeSource Create(StripeSourceCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/sources", requestOptions, options);
        }

        public virtual StripeSource Get(string sourceId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions);
        }

        public virtual StripeSource Update(string sourceId, StripeSourceUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions, options);
        }

        public virtual StripeSource Attach(string customerId, StripeSourceAttachOptions attachOptions, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, attachOptions);
        }

        public virtual StripeSource Detach(string customerId, string sourceId, StripeRequestOptions requestOptions = null)
        {
            var url = $"{Urls.BaseUrl}/customers/{customerId}/sources/{sourceId}";

            return Mapper<StripeSource>.MapFromJson(
                Requestor.Delete(url, SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeList<StripeSource> List(string customerId, StripeSourceListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            var url = string.Format(Urls.CustomerSources, customerId);

            if (listOptions == null) {
                listOptions = new StripeSourceListOptions();
            }

            return Mapper<StripeList<StripeSource>>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, url, true),
                SetupRequestOptions(requestOptions))
            );
        }


        // Async
        public virtual Task<StripeSource> CreateAsync(StripeSourceCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/sources", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeSource> GetAsync(string sourceId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeSource> UpdateAsync(string sourceId, StripeSourceUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/sources/{sourceId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeSource> AttachAsync(string customerId, StripeSourceAttachOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/customers/{customerId}/sources", requestOptions, cancellationToken, options);
        }

        public virtual async Task<StripeSource> DetachAsync(string customerId, string sourceId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = $"{Urls.BaseUrl}/customers/{customerId}/sources/{sourceId}";

            return Mapper<StripeSource>.MapFromJson(
                await Requestor.DeleteAsync(url, 
                    SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false)
                );
        }

        public virtual async Task<StripeList<StripeSource>> ListAsync(string customerId, StripeSourceListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Urls.CustomerSources, customerId);

            if (listOptions == null) {
                listOptions = new StripeSourceListOptions();
            }

            return Mapper<StripeList<StripeSource>>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, url, true),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }
    }
}
