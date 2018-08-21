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

        public virtual StripeBalance Get(RequestOptions requestOptions = null)
        {
            return Mapper<StripeBalance>.MapFromJson(
                Requestor.GetString(Urls.Balance, this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeBalanceTransaction Get(string id, RequestOptions requestOptions = null)
        {
            return Mapper<StripeBalanceTransaction>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.BalanceTransactions}/{id}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripeBalanceTransaction> List(BalanceTransactionListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeBalanceTransaction>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, Urls.BalanceTransactions, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeBalance> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeBalance>.MapFromJson(
                await Requestor.GetStringAsync(Urls.Balance, this.SetupRequestOptions(requestOptions), cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeBalanceTransaction> GetAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeBalanceTransaction>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.BalanceTransactions}/{id}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripeBalanceTransaction>> ListAsync(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeBalanceTransaction>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(options, Urls.BalanceTransactions, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
