// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CashBalanceService : ServiceNested<CashBalance>
    {
        public CashBalanceService()
            : base(null)
        {
        }

        public CashBalanceService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/customers/{PARENT_ID}/cash_balance";

        public virtual CashBalance Get(string parentId, CashBalanceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CashBalance>(HttpMethod.Get, $"/v1/customers/{parentId}/cash_balance", options, requestOptions);
        }

        public virtual Task<CashBalance> GetAsync(string parentId, CashBalanceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CashBalance>(HttpMethod.Get, $"/v1/customers/{parentId}/cash_balance", options, requestOptions, cancellationToken);
        }

        public virtual CashBalance Update(string parentId, CashBalanceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CashBalance>(HttpMethod.Post, $"/v1/customers/{parentId}/cash_balance", options, requestOptions);
        }

        public virtual Task<CashBalance> UpdateAsync(string parentId, CashBalanceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CashBalance>(HttpMethod.Post, $"/v1/customers/{parentId}/cash_balance", options, requestOptions, cancellationToken);
        }

        [Obsolete("This method is deprecated and will be removed in a future release")]
        protected override string InstanceUrl(string parentId, string id)
        {
            if (string.IsNullOrWhiteSpace(parentId))
            {
                throw new ArgumentException(
                    "The parent resource ID cannot be null or whitespace.",
                    nameof(parentId));
            }

            return $"{this.ClassUrl(parentId)}";
        }
    }
}
