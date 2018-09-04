namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class TransactionService : StripeService,
        IListable<Transaction, TransactionListOptions>,
        IRetrievable<Transaction>,
        IUpdatable<Transaction, TransactionUpdateOptions>
    {
        private static string classUrl = Urls.BaseUrl + "/issuing/transactions";

        public TransactionService()
            : base(null)
        {
        }

        public TransactionService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Transaction Update(string transactionId, TransactionUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Transaction>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{transactionId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Transaction Get(string transactionId, RequestOptions requestOptions = null)
        {
            return Mapper<Transaction>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{classUrl}/{transactionId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<Transaction> List(TransactionListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<Transaction>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Transaction> UpdateAsync(string transactionId, TransactionUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Transaction>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{transactionId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Transaction> GetAsync(string transactionId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Transaction>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{classUrl}/{transactionId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<Transaction>> ListAsync(TransactionListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<Transaction>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
