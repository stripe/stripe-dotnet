using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeTopupService : StripeService
    {
        public StripeTopupService(string apiKey = null) : base(apiKey) { }

        public bool ExpandBalanceTransaction { get; set; }
        public bool ExpandSource { get; set; }


        //Sync
        public virtual StripeTopup Create(StripeTopupCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeTopup>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, Urls.Topups, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeTopup Get(string topupId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeTopup>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.Topups}/{topupId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeList<StripeTopup> List(StripeTopupListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeTopup>>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.Topups, true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeTopup Update(string topupId, StripeTopupUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeTopup>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, $"{Urls.Topups}/{topupId}", false),
                SetupRequestOptions(requestOptions))
            );
        }


        //Async
        public virtual async Task<StripeTopup> CreateAsync(StripeTopupCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeTopup>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, Urls.Topups, false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeTopup> GetAsync(string topupId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeTopup>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.Topups}/{topupId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }

        public virtual async Task<StripeList<StripeTopup>> ListAsync(StripeTopupListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeTopup>>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.Topups, true),
                    SetupRequestOptions(requestOptions),
                    cancellationToken)
            );
        }

        public virtual async Task<StripeTopup> UpdateAsync(string topupId, StripeTopupUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeTopup>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, $"{Urls.Topups}/{topupId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }
    }
}
