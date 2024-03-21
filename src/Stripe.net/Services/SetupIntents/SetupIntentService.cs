// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SetupIntentService : Service<SetupIntent>,
        ICreatable<SetupIntent, SetupIntentCreateOptions>,
        IListable<SetupIntent, SetupIntentListOptions>,
        IRetrievable<SetupIntent, SetupIntentGetOptions>,
        IUpdatable<SetupIntent, SetupIntentUpdateOptions>
    {
        public SetupIntentService()
        {
        }

        public SetupIntentService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/setup_intents";

        /// <summary>
        /// <p>You can cancel a SetupIntent object when it’s in one of these statuses:
        /// <c>requires_payment_method</c>, <c>requires_confirmation</c>, or <c>requires_action</c>.
        /// </p>.
        ///
        /// <p>After you cancel it, setup is abandoned and any operations on the SetupIntent fail
        /// with an error.</p>.
        /// </summary>
        public virtual SetupIntent Cancel(string id, SetupIntentCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>You can cancel a SetupIntent object when it’s in one of these statuses:
        /// <c>requires_payment_method</c>, <c>requires_confirmation</c>, or <c>requires_action</c>.
        /// </p>.
        ///
        /// <p>After you cancel it, setup is abandoned and any operations on the SetupIntent fail
        /// with an error.</p>.
        /// </summary>
        public virtual Task<SetupIntent> CancelAsync(string id, SetupIntentCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Confirm that your customer intends to set up the current or provided payment method.
        /// For example, you would confirm a SetupIntent when a customer hits the “Save” button on a
        /// payment method management page on your website.</p>.
        ///
        /// <p>If the selected payment method does not require any additional steps from the
        /// customer, the SetupIntent will transition to the <c>succeeded</c> status.</p>.
        ///
        /// <p>Otherwise, it will transition to the <c>requires_action</c> status and suggest
        /// additional actions via <c>next_action</c>. If setup fails, the SetupIntent will
        /// transition to the <c>requires_payment_method</c> status or the <c>canceled</c> status if
        /// the confirmation limit is reached.</p>.
        /// </summary>
        public virtual SetupIntent Confirm(string id, SetupIntentConfirmOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}/confirm", options, requestOptions);
        }

        /// <summary>
        /// <p>Confirm that your customer intends to set up the current or provided payment method.
        /// For example, you would confirm a SetupIntent when a customer hits the “Save” button on a
        /// payment method management page on your website.</p>.
        ///
        /// <p>If the selected payment method does not require any additional steps from the
        /// customer, the SetupIntent will transition to the <c>succeeded</c> status.</p>.
        ///
        /// <p>Otherwise, it will transition to the <c>requires_action</c> status and suggest
        /// additional actions via <c>next_action</c>. If setup fails, the SetupIntent will
        /// transition to the <c>requires_payment_method</c> status or the <c>canceled</c> status if
        /// the confirmation limit is reached.</p>.
        /// </summary>
        public virtual Task<SetupIntent> ConfirmAsync(string id, SetupIntentConfirmOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}/confirm", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a SetupIntent object.</p>.
        ///
        /// <p>After you create the SetupIntent, attach a payment method and <a
        /// href="https://stripe.com/docs/api/setup_intents/confirm">confirm</a> it to collect any
        /// required permissions to charge the payment method later.</p>.
        /// </summary>
        public virtual SetupIntent Create(SetupIntentCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a SetupIntent object.</p>.
        ///
        /// <p>After you create the SetupIntent, attach a payment method and <a
        /// href="https://stripe.com/docs/api/setup_intents/confirm">confirm</a> it to collect any
        /// required permissions to charge the payment method later.</p>.
        /// </summary>
        public virtual Task<SetupIntent> CreateAsync(SetupIntentCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of a SetupIntent that has previously been created. </p>.
        ///
        /// <p>Client-side retrieval using a publishable key is allowed when the
        /// <c>client_secret</c> is provided in the query string. </p>.
        ///
        /// <p>When retrieved with a publishable key, only a subset of properties will be returned.
        /// Please refer to the <a
        /// href="https://stripe.com/docs/api#setup_intent_object">SetupIntent</a> object reference
        /// for more details.</p>.
        /// </summary>
        public virtual SetupIntent Get(string id, SetupIntentGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SetupIntent>(HttpMethod.Get, $"/v1/setup_intents/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a SetupIntent that has previously been created. </p>.
        ///
        /// <p>Client-side retrieval using a publishable key is allowed when the
        /// <c>client_secret</c> is provided in the query string. </p>.
        ///
        /// <p>When retrieved with a publishable key, only a subset of properties will be returned.
        /// Please refer to the <a
        /// href="https://stripe.com/docs/api#setup_intent_object">SetupIntent</a> object reference
        /// for more details.</p>.
        /// </summary>
        public virtual Task<SetupIntent> GetAsync(string id, SetupIntentGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SetupIntent>(HttpMethod.Get, $"/v1/setup_intents/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of SetupIntents.</p>.
        /// </summary>
        public virtual StripeList<SetupIntent> List(SetupIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<SetupIntent>>(HttpMethod.Get, $"/v1/setup_intents", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of SetupIntents.</p>.
        /// </summary>
        public virtual Task<StripeList<SetupIntent>> ListAsync(SetupIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<SetupIntent>>(HttpMethod.Get, $"/v1/setup_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of SetupIntents.</p>.
        /// </summary>
        public virtual IEnumerable<SetupIntent> ListAutoPaging(SetupIntentListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<SetupIntent>($"/v1/setup_intents", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of SetupIntents.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<SetupIntent> ListAutoPagingAsync(SetupIntentListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<SetupIntent>($"/v1/setup_intents", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a SetupIntent object.</p>.
        /// </summary>
        public virtual SetupIntent Update(string id, SetupIntentUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a SetupIntent object.</p>.
        /// </summary>
        public virtual Task<SetupIntent> UpdateAsync(string id, SetupIntentUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Verifies microdeposits on a SetupIntent object.</p>.
        /// </summary>
        public virtual SetupIntent VerifyMicrodeposits(string id, SetupIntentVerifyMicrodepositsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}/verify_microdeposits", options, requestOptions);
        }

        /// <summary>
        /// <p>Verifies microdeposits on a SetupIntent object.</p>.
        /// </summary>
        public virtual Task<SetupIntent> VerifyMicrodepositsAsync(string id, SetupIntentVerifyMicrodepositsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SetupIntent>(HttpMethod.Post, $"/v1/setup_intents/{id}/verify_microdeposits", options, requestOptions, cancellationToken);
        }
    }
}
