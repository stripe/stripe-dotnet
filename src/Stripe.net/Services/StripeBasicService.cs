namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public abstract class StripeBasicService<EntityReturned> : StripeService
    {
        protected StripeBasicService()
            : base(null)
        {
        }

        protected StripeBasicService(string apiKey)
            : base(apiKey)
        {
        }

        /*
         * this will replace StripeService altogether some day and steal it's name, but for now
         * it allows us to refactor slowly and build new services easier.
         */

        public EntityReturned GetEntity(string url, StripeRequestOptions requestOptions, StripeBaseOptions options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions)));
        }

        public StripeList<EntityReturned> GetEntityList(string url, StripeRequestOptions requestOptions, StripeBaseOptions options = null)
        {
            return Mapper<StripeList<EntityReturned>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(options, url, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public EntityReturned Post(string url, StripeRequestOptions requestOptions, StripeBaseOptions options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual EntityReturned DeleteEntity(string url, StripeRequestOptions requestOptions, StripeBaseOptions options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                Requestor.Delete(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<EntityReturned> GetEntityAsync(string url, StripeRequestOptions requestOptions, CancellationToken cancellationToken, StripeBaseOptions options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<EntityReturned>> GetEntityListAsync(string url, StripeRequestOptions requestOptions, CancellationToken cancellationToken, StripeBaseOptions options = null)
        {
            return Mapper<StripeList<EntityReturned>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(options, url, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public async Task<EntityReturned> PostAsync(string url, StripeRequestOptions requestOptions, CancellationToken cancellationToken, StripeBaseOptions options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public async Task<EntityReturned> DeleteEntityAsync(string url, StripeRequestOptions requestOptions, CancellationToken cancellationToken, StripeBaseOptions options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                await Requestor.DeleteAsync(
                    this.ApplyAllParameters(options, url),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
