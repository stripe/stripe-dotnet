// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentIntentService : Service<PaymentIntent>,
        ICreatable<PaymentIntent, PaymentIntentCreateOptions>,
        IListable<PaymentIntent, PaymentIntentListOptions>,
        IRetrievable<PaymentIntent, PaymentIntentGetOptions>,
        ISearchable<PaymentIntent, PaymentIntentSearchOptions>,
        IUpdatable<PaymentIntent, PaymentIntentUpdateOptions>
    {
        public PaymentIntentService()
        {
        }

        public PaymentIntentService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/payment_intents";

        /// <summary>
        /// <p>Manually reconcile the remaining amount for a <c>customer_balance</c>
        /// PaymentIntent.</p>.
        /// </summary>
        public virtual PaymentIntent ApplyCustomerBalance(string id, PaymentIntentApplyCustomerBalanceOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents/{id}/apply_customer_balance", options, requestOptions);
        }

        /// <summary>
        /// <p>Manually reconcile the remaining amount for a <c>customer_balance</c>
        /// PaymentIntent.</p>.
        /// </summary>
        public virtual Task<PaymentIntent> ApplyCustomerBalanceAsync(string id, PaymentIntentApplyCustomerBalanceOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents/{id}/apply_customer_balance", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>You can cancel a PaymentIntent object when it’s in one of these statuses:
        /// <c>requires_payment_method</c>, <c>requires_capture</c>, <c>requires_confirmation</c>,
        /// <c>requires_action</c> or, <a href="https://stripe.com/docs/payments/intents">in rare
        /// cases</a>, <c>processing</c>. </p>.
        ///
        /// <p>After it’s canceled, no additional charges are made by the PaymentIntent and any
        /// operations on the PaymentIntent fail with an error. For PaymentIntents with a
        /// <c>status</c> of <c>requires_capture</c>, the remaining <c>amount_capturable</c> is
        /// automatically refunded. </p>.
        ///
        /// <p>You can’t cancel the PaymentIntent for a Checkout Session. <a
        /// href="https://stripe.com/docs/api/checkout/sessions/expire">Expire the Checkout
        /// Session</a> instead.</p>.
        /// </summary>
        public virtual PaymentIntent Cancel(string id, PaymentIntentCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents/{id}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>You can cancel a PaymentIntent object when it’s in one of these statuses:
        /// <c>requires_payment_method</c>, <c>requires_capture</c>, <c>requires_confirmation</c>,
        /// <c>requires_action</c> or, <a href="https://stripe.com/docs/payments/intents">in rare
        /// cases</a>, <c>processing</c>. </p>.
        ///
        /// <p>After it’s canceled, no additional charges are made by the PaymentIntent and any
        /// operations on the PaymentIntent fail with an error. For PaymentIntents with a
        /// <c>status</c> of <c>requires_capture</c>, the remaining <c>amount_capturable</c> is
        /// automatically refunded. </p>.
        ///
        /// <p>You can’t cancel the PaymentIntent for a Checkout Session. <a
        /// href="https://stripe.com/docs/api/checkout/sessions/expire">Expire the Checkout
        /// Session</a> instead.</p>.
        /// </summary>
        public virtual Task<PaymentIntent> CancelAsync(string id, PaymentIntentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents/{id}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Capture the funds of an existing uncaptured PaymentIntent when its status is
        /// <c>requires_capture</c>.</p>.
        ///
        /// <p>Uncaptured PaymentIntents are cancelled a set number of days (7 by default) after
        /// their creation.</p>.
        ///
        /// <p>Learn more about <a href="https://stripe.com/docs/payments/capture-later">separate
        /// authorization and capture</a>.</p>.
        /// </summary>
        public virtual PaymentIntent Capture(string id, PaymentIntentCaptureOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents/{id}/capture", options, requestOptions);
        }

        /// <summary>
        /// <p>Capture the funds of an existing uncaptured PaymentIntent when its status is
        /// <c>requires_capture</c>.</p>.
        ///
        /// <p>Uncaptured PaymentIntents are cancelled a set number of days (7 by default) after
        /// their creation.</p>.
        ///
        /// <p>Learn more about <a href="https://stripe.com/docs/payments/capture-later">separate
        /// authorization and capture</a>.</p>.
        /// </summary>
        public virtual Task<PaymentIntent> CaptureAsync(string id, PaymentIntentCaptureOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents/{id}/capture", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Confirm that your customer intends to pay with current or provided payment method.
        /// Upon confirmation, the PaymentIntent will attempt to initiate a payment. If the selected
        /// payment method requires additional authentication steps, the PaymentIntent will
        /// transition to the <c>requires_action</c> status and suggest additional actions via
        /// <c>next_action</c>. If payment fails, the PaymentIntent transitions to the
        /// <c>requires_payment_method</c> status or the <c>canceled</c> status if the confirmation
        /// limit is reached. If payment succeeds, the PaymentIntent will transition to the
        /// <c>succeeded</c> status (or <c>requires_capture</c>, if <c>capture_method</c> is set to
        /// <c>manual</c>). If the <c>confirmation_method</c> is <c>automatic</c>, payment may be
        /// attempted using our <a
        /// href="https://stripe.com/docs/stripe-js/reference#stripe-handle-card-payment">client
        /// SDKs</a> and the PaymentIntent’s <a
        /// href="https://stripe.com/docs/api#payment_intent_object-client_secret">client_secret</a>.
        /// After <c>next_action</c>s are handled by the client, no additional confirmation is
        /// required to complete the payment. If the <c>confirmation_method</c> is <c>manual</c>,
        /// all payment attempts must be initiated using a secret key. If any actions are required
        /// for the payment, the PaymentIntent will return to the <c>requires_confirmation</c> state
        /// after those actions are completed. Your server needs to then explicitly re-confirm the
        /// PaymentIntent to initiate the next payment attempt.</p>.
        /// </summary>
        public virtual PaymentIntent Confirm(string id, PaymentIntentConfirmOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents/{id}/confirm", options, requestOptions);
        }

        /// <summary>
        /// <p>Confirm that your customer intends to pay with current or provided payment method.
        /// Upon confirmation, the PaymentIntent will attempt to initiate a payment. If the selected
        /// payment method requires additional authentication steps, the PaymentIntent will
        /// transition to the <c>requires_action</c> status and suggest additional actions via
        /// <c>next_action</c>. If payment fails, the PaymentIntent transitions to the
        /// <c>requires_payment_method</c> status or the <c>canceled</c> status if the confirmation
        /// limit is reached. If payment succeeds, the PaymentIntent will transition to the
        /// <c>succeeded</c> status (or <c>requires_capture</c>, if <c>capture_method</c> is set to
        /// <c>manual</c>). If the <c>confirmation_method</c> is <c>automatic</c>, payment may be
        /// attempted using our <a
        /// href="https://stripe.com/docs/stripe-js/reference#stripe-handle-card-payment">client
        /// SDKs</a> and the PaymentIntent’s <a
        /// href="https://stripe.com/docs/api#payment_intent_object-client_secret">client_secret</a>.
        /// After <c>next_action</c>s are handled by the client, no additional confirmation is
        /// required to complete the payment. If the <c>confirmation_method</c> is <c>manual</c>,
        /// all payment attempts must be initiated using a secret key. If any actions are required
        /// for the payment, the PaymentIntent will return to the <c>requires_confirmation</c> state
        /// after those actions are completed. Your server needs to then explicitly re-confirm the
        /// PaymentIntent to initiate the next payment attempt.</p>.
        /// </summary>
        public virtual Task<PaymentIntent> ConfirmAsync(string id, PaymentIntentConfirmOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents/{id}/confirm", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a PaymentIntent object.</p>.
        ///
        /// <p>After the PaymentIntent is created, attach a payment method and <a
        /// href="https://stripe.com/docs/api/payment_intents/confirm">confirm</a> to continue the
        /// payment. Learn more about <a href="https://stripe.com/docs/payments/payment-intents">the
        /// available payment flows with the Payment Intents API</a>.</p>.
        ///
        /// <p>When you use <c>confirm=true</c> during creation, it’s equivalent to creating and
        /// confirming the PaymentIntent in the same call. You can use any parameters available in
        /// the <a href="https://stripe.com/docs/api/payment_intents/confirm">confirm API</a> when
        /// you supply <c>confirm=true</c>.</p>.
        /// </summary>
        public virtual PaymentIntent Create(PaymentIntentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a PaymentIntent object.</p>.
        ///
        /// <p>After the PaymentIntent is created, attach a payment method and <a
        /// href="https://stripe.com/docs/api/payment_intents/confirm">confirm</a> to continue the
        /// payment. Learn more about <a href="https://stripe.com/docs/payments/payment-intents">the
        /// available payment flows with the Payment Intents API</a>.</p>.
        ///
        /// <p>When you use <c>confirm=true</c> during creation, it’s equivalent to creating and
        /// confirming the PaymentIntent in the same call. You can use any parameters available in
        /// the <a href="https://stripe.com/docs/api/payment_intents/confirm">confirm API</a> when
        /// you supply <c>confirm=true</c>.</p>.
        /// </summary>
        public virtual Task<PaymentIntent> CreateAsync(PaymentIntentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of a PaymentIntent that has previously been created. </p>.
        ///
        /// <p>You can retrieve a PaymentIntent client-side using a publishable key when the
        /// <c>client_secret</c> is in the query string. </p>.
        ///
        /// <p>If you retrieve a PaymentIntent with a publishable key, it only returns a subset of
        /// properties. Refer to the <a
        /// href="https://stripe.com/docs/api#payment_intent_object">payment intent</a> object
        /// reference for more details.</p>.
        /// </summary>
        public virtual PaymentIntent Get(string id, PaymentIntentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentIntent>(HttpMethod.Get, $"/v1/payment_intents/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a PaymentIntent that has previously been created. </p>.
        ///
        /// <p>You can retrieve a PaymentIntent client-side using a publishable key when the
        /// <c>client_secret</c> is in the query string. </p>.
        ///
        /// <p>If you retrieve a PaymentIntent with a publishable key, it only returns a subset of
        /// properties. Refer to the <a
        /// href="https://stripe.com/docs/api#payment_intent_object">payment intent</a> object
        /// reference for more details.</p>.
        /// </summary>
        public virtual Task<PaymentIntent> GetAsync(string id, PaymentIntentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentIntent>(HttpMethod.Get, $"/v1/payment_intents/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Perform an incremental authorization on an eligible <a
        /// href="https://stripe.com/docs/api/payment_intents/object">PaymentIntent</a>. To be
        /// eligible, the PaymentIntent’s status must be <c>requires_capture</c> and <a
        /// href="https://stripe.com/docs/api/charges/object#charge_object-payment_method_details-card_present-incremental_authorization_supported">incremental_authorization_supported</a>
        /// must be <c>true</c>.</p>.
        ///
        /// <p>Incremental authorizations attempt to increase the authorized amount on your
        /// customer’s card to the new, higher <c>amount</c> provided. Similar to the initial
        /// authorization, incremental authorizations can be declined. A single PaymentIntent can
        /// call this endpoint multiple times to further increase the authorized amount.</p>.
        ///
        /// <p>If the incremental authorization succeeds, the PaymentIntent object returns with the
        /// updated <a
        /// href="https://stripe.com/docs/api/payment_intents/object#payment_intent_object-amount">amount</a>.
        /// If the incremental authorization fails, a <a
        /// href="https://stripe.com/docs/error-codes#card-declined">card_declined</a> error
        /// returns, and no other fields on the PaymentIntent or Charge update. The PaymentIntent
        /// object remains capturable for the previously authorized amount.</p>.
        ///
        /// <p>Each PaymentIntent can have a maximum of 10 incremental authorization attempts,
        /// including declines. After it’s captured, a PaymentIntent can no longer be
        /// incremented.</p>.
        ///
        /// <p>Learn more about <a
        /// href="https://stripe.com/docs/terminal/features/incremental-authorizations">incremental
        /// authorizations</a>.</p>.
        /// </summary>
        public virtual PaymentIntent IncrementAuthorization(string id, PaymentIntentIncrementAuthorizationOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents/{id}/increment_authorization", options, requestOptions);
        }

        /// <summary>
        /// <p>Perform an incremental authorization on an eligible <a
        /// href="https://stripe.com/docs/api/payment_intents/object">PaymentIntent</a>. To be
        /// eligible, the PaymentIntent’s status must be <c>requires_capture</c> and <a
        /// href="https://stripe.com/docs/api/charges/object#charge_object-payment_method_details-card_present-incremental_authorization_supported">incremental_authorization_supported</a>
        /// must be <c>true</c>.</p>.
        ///
        /// <p>Incremental authorizations attempt to increase the authorized amount on your
        /// customer’s card to the new, higher <c>amount</c> provided. Similar to the initial
        /// authorization, incremental authorizations can be declined. A single PaymentIntent can
        /// call this endpoint multiple times to further increase the authorized amount.</p>.
        ///
        /// <p>If the incremental authorization succeeds, the PaymentIntent object returns with the
        /// updated <a
        /// href="https://stripe.com/docs/api/payment_intents/object#payment_intent_object-amount">amount</a>.
        /// If the incremental authorization fails, a <a
        /// href="https://stripe.com/docs/error-codes#card-declined">card_declined</a> error
        /// returns, and no other fields on the PaymentIntent or Charge update. The PaymentIntent
        /// object remains capturable for the previously authorized amount.</p>.
        ///
        /// <p>Each PaymentIntent can have a maximum of 10 incremental authorization attempts,
        /// including declines. After it’s captured, a PaymentIntent can no longer be
        /// incremented.</p>.
        ///
        /// <p>Learn more about <a
        /// href="https://stripe.com/docs/terminal/features/incremental-authorizations">incremental
        /// authorizations</a>.</p>.
        /// </summary>
        public virtual Task<PaymentIntent> IncrementAuthorizationAsync(string id, PaymentIntentIncrementAuthorizationOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents/{id}/increment_authorization", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of PaymentIntents.</p>.
        /// </summary>
        public virtual StripeList<PaymentIntent> List(PaymentIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentIntent>>(HttpMethod.Get, $"/v1/payment_intents", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of PaymentIntents.</p>.
        /// </summary>
        public virtual Task<StripeList<PaymentIntent>> ListAsync(PaymentIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentIntent>>(HttpMethod.Get, $"/v1/payment_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of PaymentIntents.</p>.
        /// </summary>
        public virtual IEnumerable<PaymentIntent> ListAutoPaging(PaymentIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PaymentIntent>($"/v1/payment_intents", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of PaymentIntents.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<PaymentIntent> ListAutoPagingAsync(PaymentIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PaymentIntent>($"/v1/payment_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Search for PaymentIntents you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual StripeSearchResult<PaymentIntent> Search(PaymentIntentSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeSearchResult<PaymentIntent>>(HttpMethod.Get, $"/v1/payment_intents/search", options, requestOptions);
        }

        /// <summary>
        /// <p>Search for PaymentIntents you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual Task<StripeSearchResult<PaymentIntent>> SearchAsync(PaymentIntentSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeSearchResult<PaymentIntent>>(HttpMethod.Get, $"/v1/payment_intents/search", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Search for PaymentIntents you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual IEnumerable<PaymentIntent> SearchAutoPaging(PaymentIntentSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.SearchRequestAutoPaging<PaymentIntent>($"/v1/payment_intents/search", options, requestOptions);
        }

        /// <summary>
        /// <p>Search for PaymentIntents you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<PaymentIntent> SearchAutoPagingAsync(PaymentIntentSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.SearchRequestAutoPagingAsync<PaymentIntent>($"/v1/payment_intents/search", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates properties on a PaymentIntent object without confirming.</p>.
        ///
        /// <p>Depending on which properties you update, you might need to confirm the PaymentIntent
        /// again. For example, updating the <c>payment_method</c> always requires you to confirm
        /// the PaymentIntent again. If you prefer to update and confirm at the same time, we
        /// recommend updating properties through the <a
        /// href="https://stripe.com/docs/api/payment_intents/confirm">confirm API</a> instead.</p>.
        /// </summary>
        public virtual PaymentIntent Update(string id, PaymentIntentUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates properties on a PaymentIntent object without confirming.</p>.
        ///
        /// <p>Depending on which properties you update, you might need to confirm the PaymentIntent
        /// again. For example, updating the <c>payment_method</c> always requires you to confirm
        /// the PaymentIntent again. If you prefer to update and confirm at the same time, we
        /// recommend updating properties through the <a
        /// href="https://stripe.com/docs/api/payment_intents/confirm">confirm API</a> instead.</p>.
        /// </summary>
        public virtual Task<PaymentIntent> UpdateAsync(string id, PaymentIntentUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Verifies microdeposits on a PaymentIntent object.</p>.
        /// </summary>
        public virtual PaymentIntent VerifyMicrodeposits(string id, PaymentIntentVerifyMicrodepositsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents/{id}/verify_microdeposits", options, requestOptions);
        }

        /// <summary>
        /// <p>Verifies microdeposits on a PaymentIntent object.</p>.
        /// </summary>
        public virtual Task<PaymentIntent> VerifyMicrodepositsAsync(string id, PaymentIntentVerifyMicrodepositsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentIntent>(HttpMethod.Post, $"/v1/payment_intents/{id}/verify_microdeposits", options, requestOptions, cancellationToken);
        }
    }
}
