// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class CashBalanceService : ServiceNested<CashBalance>,
        INestedSingletonRetrievable<CashBalance, CashBalanceGetOptions>,
        INestedSingletonUpdatable<CashBalance, CashBalanceUpdateOptions>
    {
        public CashBalanceService()
            : base(null)
        {
        }

        public CashBalanceService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/customers/{PARENT_ID}/cash_balance";

        public virtual CashBalance Get(string parentId, CashBalanceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(parentId, null, options, requestOptions);
        }

        public virtual Task<CashBalance> GetAsync(string parentId, CashBalanceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetNestedEntityAsync(parentId, null, options, requestOptions, cancellationToken);
        }

        public virtual CashBalance Update(string parentId, CashBalanceUpdateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(parentId, null, options, requestOptions);
        }

        public virtual Task<CashBalance> UpdateAsync(string parentId, CashBalanceUpdateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateNestedEntityAsync(parentId, null, options, requestOptions, cancellationToken);
        }

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
