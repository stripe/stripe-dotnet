using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeBalanceService : StripeService
    {
        public StripeBalanceService() : base(null) { }
        public StripeBalanceService(string apiKey) : base(apiKey) { }

        public bool ExpandSource { get; set; }



        //Sync
        public virtual StripeBalance Get(StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeBalance>.MapFromJson(
                Requestor.GetString(Urls.Balance, SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeBalanceTransaction Get(string id, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeBalanceTransaction>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.BalanceTransactions}/{id}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeList<StripeBalanceTransaction> List(StripeBalanceTransactionListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeBalanceTransaction>>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.BalanceTransactions, true),
                    SetupRequestOptions(requestOptions))
            );
        }


        //Async
        public virtual async Task<StripeBalance> GetAsync(StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeBalance>.MapFromJson(
                await Requestor.GetStringAsync(Urls.Balance, SetupRequestOptions(requestOptions), cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeBalanceTransaction> GetAsync(string id, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeBalanceTransaction>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.BalanceTransactions}/{id}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeList<StripeBalanceTransaction>> ListAsync(StripeBalanceTransactionListOptions options = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeBalanceTransaction>>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(options, Urls.BalanceTransactions, true),
                    SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false)
            );
        }
    }
}
