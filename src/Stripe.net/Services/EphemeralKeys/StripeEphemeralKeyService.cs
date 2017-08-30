using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeEphemeralKeyService : StripeService
    {
        public StripeEphemeralKeyService(string apiKey = null) : base(apiKey) { }



        //Sync
        public virtual StripeEphemeralKey Create(StripeEphemeralKeyCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeEphemeralKey>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, Urls.EphemeralKeys, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeDeleted Delete(string EphemeralKeyId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeDeleted>.MapFromJson(
                Requestor.Delete(this.ApplyAllParameters(null, $"{Urls.EphemeralKeys}/{EphemeralKeyId}", false),
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeEphemeralKey> CreateAsync(StripeEphemeralKeyCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeEphemeralKey>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.EphemeralKeys, false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeDeleted> DeleteAsync(string EphemeralKeyId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeDeleted>.MapFromJson(
                await Requestor.DeleteAsync(this.ApplyAllParameters(null, $"{Urls.EphemeralKeys}/{EphemeralKeyId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }
    }
}
