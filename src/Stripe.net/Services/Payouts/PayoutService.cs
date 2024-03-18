// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PayoutService : Service<Payout>,
        ICreatable<Payout, PayoutCreateOptions>,
        IListable<Payout, PayoutListOptions>,
        IRetrievable<Payout, PayoutGetOptions>,
        IUpdatable<Payout, PayoutUpdateOptions>
    {
        public PayoutService()
        {
        }

        public PayoutService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/payouts";

        /// <summary>
        /// <p>You can cancel a previously created payout if its status is <c>pending</c>. Stripe
        /// refunds the funds to your available balance. You can’t cancel automatic Stripe
        /// payouts.</p>.
        /// </summary>
        public virtual Payout Cancel(string id, PayoutCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Payout>(HttpMethod.Post, $"/v1/payouts/{id}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>You can cancel a previously created payout if its status is <c>pending</c>. Stripe
        /// refunds the funds to your available balance. You can’t cancel automatic Stripe
        /// payouts.</p>.
        /// </summary>
        public virtual Task<Payout> CancelAsync(string id, PayoutCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Payout>(HttpMethod.Post, $"/v1/payouts/{id}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>To send funds to your own bank account, create a new payout object. Your <a
        /// href="https://stripe.com/docs/api#balance">Stripe balance</a> must cover the payout
        /// amount. If it doesn’t, you receive an “Insufficient Funds” error.</p>.
        ///
        /// <p>If your API key is in test mode, money won’t actually be sent, though every other
        /// action occurs as if you’re in live mode.</p>.
        ///
        /// <p>If you create a manual payout on a Stripe account that uses multiple payment source
        /// types, you need to specify the source type balance that the payout draws from. The <a
        /// href="https://stripe.com/docs/api#balance_object">balance object</a> details available
        /// and pending amounts by source type.</p>.
        /// </summary>
        public virtual Payout Create(PayoutCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Payout>(HttpMethod.Post, $"/v1/payouts", options, requestOptions);
        }

        /// <summary>
        /// <p>To send funds to your own bank account, create a new payout object. Your <a
        /// href="https://stripe.com/docs/api#balance">Stripe balance</a> must cover the payout
        /// amount. If it doesn’t, you receive an “Insufficient Funds” error.</p>.
        ///
        /// <p>If your API key is in test mode, money won’t actually be sent, though every other
        /// action occurs as if you’re in live mode.</p>.
        ///
        /// <p>If you create a manual payout on a Stripe account that uses multiple payment source
        /// types, you need to specify the source type balance that the payout draws from. The <a
        /// href="https://stripe.com/docs/api#balance_object">balance object</a> details available
        /// and pending amounts by source type.</p>.
        /// </summary>
        public virtual Task<Payout> CreateAsync(PayoutCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Payout>(HttpMethod.Post, $"/v1/payouts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing payout. Supply the unique payout ID from either
        /// a payout creation request or the payout list. Stripe returns the corresponding payout
        /// information.</p>.
        /// </summary>
        public virtual Payout Get(string id, PayoutGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Payout>(HttpMethod.Get, $"/v1/payouts/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing payout. Supply the unique payout ID from either
        /// a payout creation request or the payout list. Stripe returns the corresponding payout
        /// information.</p>.
        /// </summary>
        public virtual Task<Payout> GetAsync(string id, PayoutGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Payout>(HttpMethod.Get, $"/v1/payouts/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of existing payouts sent to third-party bank accounts or payouts that
        /// Stripe sent to you. The payouts return in sorted order, with the most recently created
        /// payouts appearing first.</p>.
        /// </summary>
        public virtual StripeList<Payout> List(PayoutListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Payout>>(HttpMethod.Get, $"/v1/payouts", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of existing payouts sent to third-party bank accounts or payouts that
        /// Stripe sent to you. The payouts return in sorted order, with the most recently created
        /// payouts appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<Payout>> ListAsync(PayoutListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Payout>>(HttpMethod.Get, $"/v1/payouts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of existing payouts sent to third-party bank accounts or payouts that
        /// Stripe sent to you. The payouts return in sorted order, with the most recently created
        /// payouts appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<Payout> ListAutoPaging(PayoutListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Payout>($"/v1/payouts", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of existing payouts sent to third-party bank accounts or payouts that
        /// Stripe sent to you. The payouts return in sorted order, with the most recently created
        /// payouts appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Payout> ListAutoPagingAsync(PayoutListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Payout>($"/v1/payouts", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Reverses a payout by debiting the destination bank account. At this time, you can
        /// only reverse payouts for connected accounts to US bank accounts. If the payout is manual
        /// and in the <c>pending</c> status, use <c>/v1/payouts/:id/cancel</c> instead.</p>.
        ///
        /// <p>By requesting a reversal through <c>/v1/payouts/:id/reverse</c>, you confirm that the
        /// authorized signatory of the selected bank account authorizes the debit on the bank
        /// account and that no other authorization is required.</p>.
        /// </summary>
        public virtual Payout Reverse(string id, PayoutReverseOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Payout>(HttpMethod.Post, $"/v1/payouts/{id}/reverse", options, requestOptions);
        }

        /// <summary>
        /// <p>Reverses a payout by debiting the destination bank account. At this time, you can
        /// only reverse payouts for connected accounts to US bank accounts. If the payout is manual
        /// and in the <c>pending</c> status, use <c>/v1/payouts/:id/cancel</c> instead.</p>.
        ///
        /// <p>By requesting a reversal through <c>/v1/payouts/:id/reverse</c>, you confirm that the
        /// authorized signatory of the selected bank account authorizes the debit on the bank
        /// account and that no other authorization is required.</p>.
        /// </summary>
        public virtual Task<Payout> ReverseAsync(string id, PayoutReverseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Payout>(HttpMethod.Post, $"/v1/payouts/{id}/reverse", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the specified payout by setting the values of the parameters you pass. We
        /// don’t change parameters that you don’t provide. This request only accepts the metadata
        /// as arguments.</p>.
        /// </summary>
        public virtual Payout Update(string id, PayoutUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Payout>(HttpMethod.Post, $"/v1/payouts/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specified payout by setting the values of the parameters you pass. We
        /// don’t change parameters that you don’t provide. This request only accepts the metadata
        /// as arguments.</p>.
        /// </summary>
        public virtual Task<Payout> UpdateAsync(string id, PayoutUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Payout>(HttpMethod.Post, $"/v1/payouts/{id}", options, requestOptions, cancellationToken);
        }
    }
}
