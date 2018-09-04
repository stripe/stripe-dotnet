namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class BalanceTransactionService : BasicService<BalanceTransaction>,
        IListable<BalanceTransaction, BalanceTransactionListOptions>,
        IRetrievable<BalanceTransaction>
    {
        private static string classUrl = Urls.BaseUrl + "/balance/history";

        public BalanceTransactionService()
            : base(null)
        {
        }

        public BalanceTransactionService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandSource { get; set; }

        public virtual BalanceTransaction Get(string balanceTransactionId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{classUrl}/{balanceTransactionId}", requestOptions);
        }

        public virtual Task<BalanceTransaction> GetAsync(string balanceTransactionId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{classUrl}/{balanceTransactionId}", requestOptions, cancellationToken);
        }

        public virtual StripeList<BalanceTransaction> List(BalanceTransactionListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList(classUrl, requestOptions, listOptions);
        }

        public virtual Task<StripeList<BalanceTransaction>> ListAsync(BalanceTransactionListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync(classUrl, requestOptions, cancellationToken, listOptions);
        }
    }
}
