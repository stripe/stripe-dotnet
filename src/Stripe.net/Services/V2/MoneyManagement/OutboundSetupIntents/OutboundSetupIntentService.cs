// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OutboundSetupIntentService : Service
    {
        internal OutboundSetupIntentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal OutboundSetupIntentService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Cancel an OutboundSetupIntent object.
        /// </summary>
        public virtual OutboundSetupIntent Cancel(string id, OutboundSetupIntentCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OutboundSetupIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_setup_intents/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancel an OutboundSetupIntent object.
        /// </summary>
        public virtual Task<OutboundSetupIntent> CancelAsync(string id, OutboundSetupIntentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OutboundSetupIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_setup_intents/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Create an OutboundSetupIntent object.
        /// </summary>
        public virtual OutboundSetupIntent Create(OutboundSetupIntentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<OutboundSetupIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_setup_intents", options, requestOptions);
        }

        /// <summary>
        /// Create an OutboundSetupIntent object.
        /// </summary>
        public virtual Task<OutboundSetupIntent> CreateAsync(OutboundSetupIntentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OutboundSetupIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_setup_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve an OutboundSetupIntent object.
        /// </summary>
        public virtual OutboundSetupIntent Get(string id, OutboundSetupIntentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OutboundSetupIntent>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/outbound_setup_intents/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve an OutboundSetupIntent object.
        /// </summary>
        public virtual Task<OutboundSetupIntent> GetAsync(string id, OutboundSetupIntentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OutboundSetupIntent>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/outbound_setup_intents/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List the OutboundSetupIntent objects.
        /// </summary>
        public virtual V2.StripeList<OutboundSetupIntent> List(OutboundSetupIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<OutboundSetupIntent>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/outbound_setup_intents", options, requestOptions);
        }

        /// <summary>
        /// List the OutboundSetupIntent objects.
        /// </summary>
        public virtual Task<V2.StripeList<OutboundSetupIntent>> ListAsync(OutboundSetupIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<OutboundSetupIntent>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/outbound_setup_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List the OutboundSetupIntent objects.
        /// </summary>
        public virtual IEnumerable<OutboundSetupIntent> ListAutoPaging(OutboundSetupIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<OutboundSetupIntent>($"/v2/money_management/outbound_setup_intents", options, requestOptions);
        }

        /// <summary>
        /// List the OutboundSetupIntent objects.
        /// </summary>
        public virtual IAsyncEnumerable<OutboundSetupIntent> ListAutoPagingAsync(OutboundSetupIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<OutboundSetupIntent>($"/v2/money_management/outbound_setup_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update an OutboundSetupIntent object.
        /// </summary>
        public virtual OutboundSetupIntent Update(string id, OutboundSetupIntentUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<OutboundSetupIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_setup_intents/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update an OutboundSetupIntent object.
        /// </summary>
        public virtual Task<OutboundSetupIntent> UpdateAsync(string id, OutboundSetupIntentUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OutboundSetupIntent>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/outbound_setup_intents/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
