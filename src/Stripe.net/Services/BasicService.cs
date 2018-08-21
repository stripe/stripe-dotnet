namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public abstract class BasicService<EntityReturned> : StripeService
    {
        protected BasicService()
            : base(null)
        {
        }

        protected BasicService(string apiKey)
            : base(apiKey)
        {
        }

        /*
         * this will replace StripeService altogether some day and steal it's name, but for now
         * it allows us to refactor slowly and build new services easier.
         */

        public EntityReturned GetEntity(string url, RequestOptions requestOptions, BaseOptions options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions)));
        }

        public StripeList<EntityReturned> GetEntityList(string url, RequestOptions requestOptions, BaseOptions options = null)
        {
            return Mapper<StripeList<EntityReturned>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(options, url, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public EntityReturned Post(string url, RequestOptions requestOptions, BaseOptions options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual EntityReturned DeleteEntity(string url, RequestOptions requestOptions, BaseOptions options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                Requestor.Delete(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<EntityReturned> GetEntityAsync(string url, RequestOptions requestOptions, CancellationToken cancellationToken, BaseOptions options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<EntityReturned>> GetEntityListAsync(string url, RequestOptions requestOptions, CancellationToken cancellationToken, BaseOptions options = null)
        {
            return Mapper<StripeList<EntityReturned>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(options, url, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public async Task<EntityReturned> PostAsync(string url, RequestOptions requestOptions, CancellationToken cancellationToken, BaseOptions options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public async Task<EntityReturned> DeleteEntityAsync(string url, RequestOptions requestOptions, CancellationToken cancellationToken, BaseOptions options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                await Requestor.DeleteAsync(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
