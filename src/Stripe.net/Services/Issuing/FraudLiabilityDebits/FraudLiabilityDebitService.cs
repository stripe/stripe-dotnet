// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FraudLiabilityDebitService : Service,
        IListable<FraudLiabilityDebit, FraudLiabilityDebitListOptions>,
        IRetrievable<FraudLiabilityDebit, FraudLiabilityDebitGetOptions>
    {
        public FraudLiabilityDebitService()
        {
        }

        internal FraudLiabilityDebitService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public FraudLiabilityDebitService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves an Issuing <c>FraudLiabilityDebit</c> object.</p>.
        /// </summary>
        public virtual FraudLiabilityDebit Get(string id, FraudLiabilityDebitGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FraudLiabilityDebit>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/fraud_liability_debits/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an Issuing <c>FraudLiabilityDebit</c> object.</p>.
        /// </summary>
        public virtual Task<FraudLiabilityDebit> GetAsync(string id, FraudLiabilityDebitGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FraudLiabilityDebit>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/fraud_liability_debits/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>FraudLiabilityDebit</c> objects. The objects are sorted
        /// in descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual StripeList<FraudLiabilityDebit> List(FraudLiabilityDebitListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<FraudLiabilityDebit>>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/fraud_liability_debits", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>FraudLiabilityDebit</c> objects. The objects are sorted
        /// in descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual Task<StripeList<FraudLiabilityDebit>> ListAsync(FraudLiabilityDebitListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<FraudLiabilityDebit>>(BaseAddress.Api, HttpMethod.Get, $"/v1/issuing/fraud_liability_debits", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>FraudLiabilityDebit</c> objects. The objects are sorted
        /// in descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual IEnumerable<FraudLiabilityDebit> ListAutoPaging(FraudLiabilityDebitListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<FraudLiabilityDebit>($"/v1/issuing/fraud_liability_debits", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Issuing <c>FraudLiabilityDebit</c> objects. The objects are sorted
        /// in descending order by creation date, with the most recently created object appearing
        /// first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<FraudLiabilityDebit> ListAutoPagingAsync(FraudLiabilityDebitListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<FraudLiabilityDebit>($"/v1/issuing/fraud_liability_debits", options, requestOptions, cancellationToken);
        }
    }
}
