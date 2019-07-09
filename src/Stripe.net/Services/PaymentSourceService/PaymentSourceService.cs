namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentSourceService : ServiceNested<IPaymentSource>,
        INestedCreatable<IPaymentSource, PaymentSourceCreateOptions>,
        INestedDeletable<IPaymentSource>,
        INestedListable<IPaymentSource, PaymentSourceListOptions>,
        INestedRetrievable<IPaymentSource, PaymentSourceGetOptions>,
        INestedUpdatable<IPaymentSource, PaymentSourceUpdateOptions>
    {
        public PaymentSourceService()
            : base(null)
        {
        }

        public PaymentSourceService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/customers/{PARENT_ID}/sources";

        public virtual IPaymentSource Create(string accountId, PaymentSourceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(accountId, options, requestOptions);
        }

        public virtual Task<IPaymentSource> CreateAsync(string accountId, PaymentSourceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateNestedEntityAsync(accountId, options, requestOptions, cancellationToken);
        }

        public virtual IPaymentSource Delete(string accountId, string paymentSourceId, RequestOptions requestOptions = null)
        {
            return this.DeleteNestedEntity(accountId, paymentSourceId, null, requestOptions);
        }

        public virtual Task<IPaymentSource> DeleteAsync(string accountId, string paymentSourceId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteNestedEntityAsync(accountId, paymentSourceId, null, requestOptions, cancellationToken);
        }

        public virtual IPaymentSource Get(string accountId, string paymentSourceId, PaymentSourceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(accountId, paymentSourceId, options, requestOptions);
        }

        public virtual Task<IPaymentSource> GetAsync(string accountId, string paymentSourceId, PaymentSourceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetNestedEntityAsync(accountId, paymentSourceId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<IPaymentSource> List(string accountId, PaymentSourceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(accountId, options, requestOptions);
        }

        public virtual Task<StripeList<IPaymentSource>> ListAsync(string accountId, PaymentSourceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListNestedEntitiesAsync(accountId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<IPaymentSource> ListAutoPaging(string accountId, PaymentSourceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(accountId, options, requestOptions);
        }

        public virtual IPaymentSource Update(string accountId, string paymentSourceId, PaymentSourceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(accountId, paymentSourceId, options, requestOptions);
        }

        public virtual Task<IPaymentSource> UpdateAsync(string accountId, string paymentSourceId, PaymentSourceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateNestedEntityAsync(accountId, paymentSourceId, options, requestOptions, cancellationToken);
        }
    }
}
