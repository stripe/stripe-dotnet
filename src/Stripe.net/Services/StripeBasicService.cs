using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public abstract class StripeBasicService<EntityReturned> : StripeService
    {
        protected StripeBasicService(string apiKey = null) : base(apiKey) { }

        // ************************************************************************************
        // this will replace StripeService altogether some day and steal it's name, but for now
        // it allows us to refactor slowly and build new services easier.

        // Sync
        public EntityReturned GetEntity(string url, StripeRequestOptions requestOptions, object options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(options, url),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        public StripeList<EntityReturned> GetEntityList(string url, StripeRequestOptions requestOptions, object options = null)
        {
            return Mapper<StripeList<EntityReturned>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(options, url, true),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        public EntityReturned Post(string url, StripeRequestOptions requestOptions, object options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(options, url),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        public virtual StripeDeleted DeleteEntity(string url, StripeRequestOptions requestOptions, object options = null)
        {
            return Mapper<StripeDeleted>.MapFromJson(
                Requestor.Delete(
                    this.ApplyAllParameters(options, url),
                    SetupRequestOptions(requestOptions)
                )
             );
        }



        // Async
        public virtual async Task<EntityReturned> GetEntityAsync(string url, StripeRequestOptions requestOptions, CancellationToken cancellationToken, object options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(options, url),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }

        public virtual async Task<StripeList<EntityReturned>> GetEntityListAsync(string url, StripeRequestOptions requestOptions, CancellationToken cancellationToken, object options = null)
        {
            return Mapper<StripeList<EntityReturned>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(options, url, true),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }

        public async Task<EntityReturned> PostAsync(string url, StripeRequestOptions requestOptions, CancellationToken cancellationToken, object options = null)
        {
            return Mapper<EntityReturned>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(options, url),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }

        public async Task<StripeDeleted> DeleteEntityAsync(string url, StripeRequestOptions requestOptions, CancellationToken cancellationToken, object options = null)
        {
            return Mapper<StripeDeleted>.MapFromJson(
                await Requestor.DeleteAsync(
                    this.ApplyAllParameters(options, url),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
             );
        }


    }
}
