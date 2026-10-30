// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FundingIntentService : Service
    {
        internal FundingIntentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal FundingIntentService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Cancels a FundingIntent that can still be canceled.
        /// </summary>
        public virtual FundingIntent Cancel(string id, FundingIntentCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FundingIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/funding_intents/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancels a FundingIntent that can still be canceled.
        /// </summary>
        public virtual Task<FundingIntent> CancelAsync(string id, FundingIntentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FundingIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/funding_intents/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Confirms a FundingIntent that is ready for processing.
        /// </summary>
        public virtual FundingIntent Confirm(string id, FundingIntentConfirmOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FundingIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/funding_intents/{WebUtility.UrlEncode(id)}/confirm", options, requestOptions);
        }

        /// <summary>
        /// Confirms a FundingIntent that is ready for processing.
        /// </summary>
        public virtual Task<FundingIntent> ConfirmAsync(string id, FundingIntentConfirmOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FundingIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/funding_intents/{WebUtility.UrlEncode(id)}/confirm", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Creates a FundingIntent that adds funds to a FinancialAccount.
        /// </summary>
        public virtual FundingIntent Create(FundingIntentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FundingIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/funding_intents", options, requestOptions);
        }

        /// <summary>
        /// Creates a FundingIntent that adds funds to a FinancialAccount.
        /// </summary>
        public virtual Task<FundingIntent> CreateAsync(FundingIntentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FundingIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/funding_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a FundingIntent by ID.
        /// </summary>
        public virtual FundingIntent Get(string id, FundingIntentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FundingIntent>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/funding_intents/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a FundingIntent by ID.
        /// </summary>
        public virtual Task<FundingIntent> GetAsync(string id, FundingIntentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FundingIntent>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/funding_intents/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists FundingIntents.
        /// </summary>
        public virtual V2.StripeList<FundingIntent> List(FundingIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<FundingIntent>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/funding_intents", options, requestOptions);
        }

        /// <summary>
        /// Lists FundingIntents.
        /// </summary>
        public virtual Task<V2.StripeList<FundingIntent>> ListAsync(FundingIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<FundingIntent>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/funding_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists FundingIntents.
        /// </summary>
        public virtual IEnumerable<FundingIntent> ListAutoPaging(FundingIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<FundingIntent>($"/v2/money_management/funding_intents", options, requestOptions);
        }

        /// <summary>
        /// Lists FundingIntents.
        /// </summary>
        public virtual IAsyncEnumerable<FundingIntent> ListAutoPagingAsync(FundingIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<FundingIntent>($"/v2/money_management/funding_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Updates the mutable details of a FundingIntent.
        /// </summary>
        public virtual FundingIntent Update(string id, FundingIntentUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<FundingIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/funding_intents/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Updates the mutable details of a FundingIntent.
        /// </summary>
        public virtual Task<FundingIntent> UpdateAsync(string id, FundingIntentUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FundingIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/funding_intents/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
