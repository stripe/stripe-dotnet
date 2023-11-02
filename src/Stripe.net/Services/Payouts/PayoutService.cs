// File generated from our OpenAPI spec
namespace Stripe
{
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
            : base(null)
        {
        }

        public PayoutService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/payouts";

        public virtual Payout Cancel(string id, PayoutCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Payout>(HttpMethod.Post, $"/v1/payouts/{id}/cancel", options, requestOptions);
        }

        public virtual Task<Payout> CancelAsync(string id, PayoutCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Payout>(HttpMethod.Post, $"/v1/payouts/{id}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual Payout Create(PayoutCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Payout>(HttpMethod.Post, $"/v1/payouts", options, requestOptions);
        }

        public virtual Task<Payout> CreateAsync(PayoutCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Payout>(HttpMethod.Post, $"/v1/payouts", options, requestOptions, cancellationToken);
        }

        public virtual Payout Get(string id, PayoutGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Payout>(HttpMethod.Get, $"/v1/payouts/{id}", options, requestOptions);
        }

        public virtual Task<Payout> GetAsync(string id, PayoutGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Payout>(HttpMethod.Get, $"/v1/payouts/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Payout> List(PayoutListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Payout>>(HttpMethod.Get, $"/v1/payouts", options, requestOptions);
        }

        public virtual Task<StripeList<Payout>> ListAsync(PayoutListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Payout>>(HttpMethod.Get, $"/v1/payouts", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Payout> ListAutoPaging(PayoutListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Payout>($"/v1/payouts", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Payout> ListAutoPagingAsync(PayoutListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Payout>($"/v1/payouts", options, requestOptions, cancellationToken);
        }

        public virtual Payout Reverse(string id, PayoutReverseOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Payout>(HttpMethod.Post, $"/v1/payouts/{id}/reverse", options, requestOptions);
        }

        public virtual Task<Payout> ReverseAsync(string id, PayoutReverseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Payout>(HttpMethod.Post, $"/v1/payouts/{id}/reverse", options, requestOptions, cancellationToken);
        }

        public virtual Payout Update(string id, PayoutUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Payout>(HttpMethod.Post, $"/v1/payouts/{id}", options, requestOptions);
        }

        public virtual Task<Payout> UpdateAsync(string id, PayoutUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Payout>(HttpMethod.Post, $"/v1/payouts/{id}", options, requestOptions, cancellationToken);
        }
    }
}
