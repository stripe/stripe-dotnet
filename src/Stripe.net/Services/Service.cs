namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public abstract class Service<EntityReturned>
    {
        protected Service()
        {
        }

        protected Service(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey { get; set; }

        public virtual EntityReturned DeleteEntity(string url, RequestOptions requestOptions, BaseOptions options = null)
        {
            return this.DeleteRequest<EntityReturned>(url, options, requestOptions);
        }

        public Task<EntityReturned> DeleteEntityAsync(string url, RequestOptions requestOptions, CancellationToken cancellationToken, BaseOptions options = null)
        {
            return this.DeleteRequestAsync<EntityReturned>(url, options, requestOptions, cancellationToken);
        }

        public EntityReturned GetEntity(string url, RequestOptions requestOptions, BaseOptions options = null)
        {
            return this.GetRequest<EntityReturned>(url, options, requestOptions);
        }

        public Task<EntityReturned> GetEntityAsync(string url, RequestOptions requestOptions, CancellationToken cancellationToken, BaseOptions options = null)
        {
            return this.GetRequestAsync<EntityReturned>(url, options, requestOptions, cancellationToken);
        }

        public StripeList<EntityReturned> GetEntityList(string url, RequestOptions requestOptions, BaseOptions options = null)
        {
            return this.GetRequest<StripeList<EntityReturned>>(url, options, requestOptions);
        }

        public Task<StripeList<EntityReturned>> GetEntityListAsync(string url, RequestOptions requestOptions, CancellationToken cancellationToken, BaseOptions options = null)
        {
            return this.GetRequestAsync<StripeList<EntityReturned>>(url, options, requestOptions, cancellationToken);
        }

        public EntityReturned Post(string url, RequestOptions requestOptions, BaseOptions options = null)
        {
            return this.PostRequest<EntityReturned>(url, options, requestOptions);
        }

        public Task<EntityReturned> PostAsync(string url, RequestOptions requestOptions, CancellationToken cancellationToken, BaseOptions options = null)
        {
            return this.PostRequestAsync<EntityReturned>(url, options, requestOptions, cancellationToken);
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

        protected T GetRequest<T>(string url, BaseOptions options, RequestOptions requestOptions)
        {
            return Mapper<T>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions)));
        }

        protected async Task<T> GetRequestAsync<T>(string url, BaseOptions options, RequestOptions requestOptions, CancellationToken cancellationToken)
        {
            return Mapper<T>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
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
    }
}
