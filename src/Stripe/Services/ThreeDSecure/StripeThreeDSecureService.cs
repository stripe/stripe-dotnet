using System.Threading;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeThreeDSecureService : StripeService
    {
        public StripeThreeDSecureService(string apiKey = null) : base(apiKey) { }

        //Sync
        public virtual StripeThreeDSecure Create(StripeThreeDSecureCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeThreeDSecure>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, Urls.ThreeDSecure, false),
                SetupRequestOptions(requestOptions))
            );
        }

        //Async
        public virtual async Task<StripeThreeDSecure> CreateAsync(StripeThreeDSecureCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeThreeDSecure>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.ThreeDSecure, false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }
    }
}
