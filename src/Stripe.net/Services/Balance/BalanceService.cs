namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class BalanceService : StripeService
    {
        public BalanceService()
            : base(null)
        {
        }

        public BalanceService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandSource { get; set; }

        public virtual Balance Get(RequestOptions requestOptions = null)
        {
            return Mapper<Balance>.MapFromJson(
                Requestor.GetString(Urls.Balance, this.SetupRequestOptions(requestOptions)));
        }

        public virtual BalanceTransaction Get(string id, RequestOptions requestOptions = null)
        {
            return Mapper<BalanceTransaction>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.BalanceTransactions}/{id}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<BalanceTransaction> List(BalanceTransactionListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<BalanceTransaction>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.BalanceTransactions, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Balance> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Balance>.MapFromJson(
                await Requestor.GetStringAsync(Urls.Balance, this.SetupRequestOptions(requestOptions), cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<BalanceTransaction> GetAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<BalanceTransaction>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.BalanceTransactions}/{id}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<BalanceTransaction>> ListAsync(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<BalanceTransaction>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(options, Urls.BalanceTransactions, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
