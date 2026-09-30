// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class EarnedCreditService : Service
    {
        internal EarnedCreditService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal EarnedCreditService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves an EarnedCredit.
        /// </summary>
        public virtual EarnedCredit Get(string id, EarnedCreditGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<EarnedCredit>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/earned_credits/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves an EarnedCredit.
        /// </summary>
        public virtual Task<EarnedCredit> GetAsync(string id, EarnedCreditGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<EarnedCredit>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/earned_credits/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of EarnedCredits.
        /// </summary>
        public virtual V2.StripeList<EarnedCredit> List(EarnedCreditListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<EarnedCredit>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/earned_credits", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of EarnedCredits.
        /// </summary>
        public virtual Task<V2.StripeList<EarnedCredit>> ListAsync(EarnedCreditListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<EarnedCredit>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/earned_credits", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of EarnedCredits.
        /// </summary>
        public virtual IEnumerable<EarnedCredit> ListAutoPaging(EarnedCreditListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<EarnedCredit>($"/v2/money_management/earned_credits", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of EarnedCredits.
        /// </summary>
        public virtual IAsyncEnumerable<EarnedCredit> ListAutoPagingAsync(EarnedCreditListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<EarnedCredit>($"/v2/money_management/earned_credits", options, requestOptions, cancellationToken);
        }
    }
}
