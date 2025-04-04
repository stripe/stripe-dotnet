// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class TransactionService : Service,
        IRetrievable<Transaction, TransactionGetOptions>
    {
        private TransactionLineItemService lineItems;

        public TransactionService()
        {
        }

        internal TransactionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public TransactionService(IStripeClient client)
            : base(client)
        {
        }

        public virtual TransactionLineItemService LineItems => this.lineItems ??= new TransactionLineItemService(
            this.Requestor);

        /// <summary>
        /// <p>Creates a Tax Transaction from a calculation, if that calculation hasn’t expired.
        /// Calculations expire after 90 days.</p>.
        /// </summary>
        public virtual Transaction CreateFromCalculation(TransactionCreateFromCalculationOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax/transactions/create_from_calculation", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a Tax Transaction from a calculation, if that calculation hasn’t expired.
        /// Calculations expire after 90 days.</p>.
        /// </summary>
        public virtual Task<Transaction> CreateFromCalculationAsync(TransactionCreateFromCalculationOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax/transactions/create_from_calculation", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Partially or fully reverses a previously created <c>Transaction</c>.</p>.
        /// </summary>
        public virtual Transaction CreateReversal(TransactionCreateReversalOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax/transactions/create_reversal", options, requestOptions);
        }

        /// <summary>
        /// <p>Partially or fully reverses a previously created <c>Transaction</c>.</p>.
        /// </summary>
        public virtual Task<Transaction> CreateReversalAsync(TransactionCreateReversalOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax/transactions/create_reversal", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a Tax <c>Transaction</c> object.</p>.
        /// </summary>
        public virtual Transaction Get(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Transaction>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/transactions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a Tax <c>Transaction</c> object.</p>.
        /// </summary>
        public virtual Task<Transaction> GetAsync(string id, TransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Transaction>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/transactions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
