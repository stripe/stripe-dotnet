namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;
    using Stripe.Infrastructure.Extensions;

    public abstract class Service<EntityReturned>
        where EntityReturned : IStripeEntity
    {
        protected Service()
        {
        }

        protected Service(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey { get; set; }

        public abstract string BasePath { get; }

        protected EntityReturned CreateEntity(BaseOptions options, RequestOptions requestOptions)
        {
            return this.PostRequest<EntityReturned>(this.ClassUrl(), options, requestOptions);
        }

        protected Task<EntityReturned> CreateEntityAsync(BaseOptions options, RequestOptions requestOptions, CancellationToken cancellationToken)
        {
            return this.PostRequestAsync<EntityReturned>(this.ClassUrl(), options, requestOptions, cancellationToken);
        }

        protected EntityReturned DeleteEntity(string id, BaseOptions options, RequestOptions requestOptions)
        {
            return this.DeleteRequest<EntityReturned>(this.InstanceUrl(id), options, requestOptions);
        }

        protected Task<EntityReturned> DeleteEntityAsync(string id, BaseOptions options, RequestOptions requestOptions, CancellationToken cancellationToken)
        {
            return this.DeleteRequestAsync<EntityReturned>(this.InstanceUrl(id), options, requestOptions, cancellationToken);
        }

        protected EntityReturned GetEntity(string id, BaseOptions options, RequestOptions requestOptions)
        {
            return this.GetRequest<EntityReturned>(this.InstanceUrl(id), options, requestOptions, false);
        }

        protected Task<EntityReturned> GetEntityAsync(string id, BaseOptions options, RequestOptions requestOptions, CancellationToken cancellationToken)
        {
            return this.GetRequestAsync<EntityReturned>(this.InstanceUrl(id), options, requestOptions, false, cancellationToken);
        }

        protected StripeList<EntityReturned> ListEntities(ListOptions options, RequestOptions requestOptions)
        {
            return this.GetRequest<StripeList<EntityReturned>>(this.ClassUrl(), options, requestOptions, true);
        }

        protected Task<StripeList<EntityReturned>> ListEntitiesAsync(ListOptions options, RequestOptions requestOptions, CancellationToken cancellationToken)
        {
            return this.GetRequestAsync<StripeList<EntityReturned>>(this.ClassUrl(), options, requestOptions, true, cancellationToken);
        }

        protected IEnumerable<EntityReturned> ListEntitiesAutoPaging(ListOptions options, RequestOptions requestOptions)
        {
            return this.ListRequestAutoPaging<EntityReturned>(this.ClassUrl(), options, requestOptions);
        }

        protected EntityReturned UpdateEntity(string id, BaseOptions options, RequestOptions requestOptions)
        {
            return this.PostRequest<EntityReturned>(this.InstanceUrl(id), options, requestOptions);
        }

        protected Task<EntityReturned> UpdateEntityAsync(string id, BaseOptions options, RequestOptions requestOptions, CancellationToken cancellationToken)
        {
            return this.PostRequestAsync<EntityReturned>(this.InstanceUrl(id), options, requestOptions, cancellationToken);
        }

        protected T DeleteRequest<T>(string url, BaseOptions options, RequestOptions requestOptions)
        {
            return Mapper<T>.MapFromJson(
                Requestor.Delete(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions)));
        }

        protected async Task<T> DeleteRequestAsync<T>(string url, BaseOptions options, RequestOptions requestOptions, CancellationToken cancellationToken)
        {
            return Mapper<T>.MapFromJson(
                await Requestor.DeleteAsync(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        protected T GetRequest<T>(string url, BaseOptions options, RequestOptions requestOptions, bool isListMethod)
        {
            return Mapper<T>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(options, url, isListMethod),
                    this.SetupRequestOptions(requestOptions)));
        }

        protected async Task<T> GetRequestAsync<T>(string url, BaseOptions options, RequestOptions requestOptions, bool isListMethod, CancellationToken cancellationToken)
        {
            return Mapper<T>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(options, url, isListMethod),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        protected IEnumerable<T> ListRequestAutoPaging<T>(string url, ListOptions options, RequestOptions requestOptions)
        {
            var page = this.GetRequest<StripeList<T>>(url, options, requestOptions, true);

            while (true)
            {
                string itemId = null;
                foreach (var item in page)
                {
                    itemId = ((IHasId)item).Id;
                    yield return item;
                }

                if (!page.HasMore || string.IsNullOrEmpty(itemId))
                {
                    break;
                }

                options.StartingAfter = itemId;
                page = this.GetRequest<StripeList<T>>(this.ClassUrl(), options, requestOptions, true);
            }
        }

        protected T PostRequest<T>(string url, BaseOptions options, RequestOptions requestOptions)
        {
            return Mapper<T>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions)));
        }

        protected async Task<T> PostRequestAsync<T>(string url, BaseOptions options, RequestOptions requestOptions, CancellationToken cancellationToken)
        {
            return Mapper<T>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        protected RequestOptions SetupRequestOptions(RequestOptions requestOptions)
        {
            if (requestOptions == null)
            {
                requestOptions = new RequestOptions();
            }

            if (!string.IsNullOrEmpty(this.ApiKey))
            {
                requestOptions.ApiKey = this.ApiKey;
            }

            return requestOptions;
        }

        protected virtual string ClassUrl(string baseUrl = null)
        {
            baseUrl = baseUrl ?? StripeConfiguration.ApiBase;
            return $"{baseUrl}{this.BasePath}";
        }

        protected virtual string InstanceUrl(string id, string baseUrl = null)
        {
            return $"{this.ClassUrl(baseUrl)}/{WebUtility.UrlEncode(id)}";
        }
    }
}
