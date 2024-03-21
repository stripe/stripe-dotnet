// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class BalanceService : Service<Balance>,
        ISingletonRetrievable<Balance>
    {
        public BalanceService()
        {
        }

        public BalanceService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/balance";

        [Obsolete("This member is deprecated and will be removed in a future release")]
        protected override string InstanceUrl(string id)
        {
            return this.ClassUrl();
        }

        /// <summary>
        /// <p>Retrieves the current account balance, based on the authentication that was used to
        /// make the request. For a sample request, see <a
        /// href="https://stripe.com/docs/connect/account-balances#accounting-for-negative-balances">Accounting
        /// for negative balances</a>.</p>.
        /// </summary>
        public virtual Balance Get(RequestOptions requestOptions = null)
        {
            return this.Request<Balance>(HttpMethod.Get, $"/v1/balance", null, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the current account balance, based on the authentication that was used to
        /// make the request. For a sample request, see <a
        /// href="https://stripe.com/docs/connect/account-balances#accounting-for-negative-balances">Accounting
        /// for negative balances</a>.</p>.
        /// </summary>
        public virtual Task<Balance> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Balance>(HttpMethod.Get, $"/v1/balance", null, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the current account balance, based on the authentication that was used to
        /// make the request. For a sample request, see <a
        /// href="https://stripe.com/docs/connect/account-balances#accounting-for-negative-balances">Accounting
        /// for negative balances</a>.</p>.
        /// </summary>
        public virtual Balance Get(BalanceGetOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Balance>(HttpMethod.Get, $"/v1/balance", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the current account balance, based on the authentication that was used to
        /// make the request. For a sample request, see <a
        /// href="https://stripe.com/docs/connect/account-balances#accounting-for-negative-balances">Accounting
        /// for negative balances</a>.</p>.
        /// </summary>
        public virtual Task<Balance> GetAsync(BalanceGetOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Balance>(HttpMethod.Get, $"/v1/balance", options, requestOptions, cancellationToken);
        }
    }
}
