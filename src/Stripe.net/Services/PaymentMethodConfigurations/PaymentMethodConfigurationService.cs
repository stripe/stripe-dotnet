// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentMethodConfigurationService : Service<PaymentMethodConfiguration>,
        ICreatable<PaymentMethodConfiguration, PaymentMethodConfigurationCreateOptions>,
        IListable<PaymentMethodConfiguration, PaymentMethodConfigurationListOptions>,
        IRetrievable<PaymentMethodConfiguration, PaymentMethodConfigurationGetOptions>,
        IUpdatable<PaymentMethodConfiguration, PaymentMethodConfigurationUpdateOptions>
    {
        public PaymentMethodConfigurationService()
            : base(null)
        {
        }

        public PaymentMethodConfigurationService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/payment_method_configurations";

        public virtual PaymentMethodConfiguration Create(PaymentMethodConfigurationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<PaymentMethodConfiguration> CreateAsync(PaymentMethodConfigurationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual PaymentMethodConfiguration Get(string id, PaymentMethodConfigurationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<PaymentMethodConfiguration> GetAsync(string id, PaymentMethodConfigurationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<PaymentMethodConfiguration> List(PaymentMethodConfigurationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<PaymentMethodConfiguration>> ListAsync(PaymentMethodConfigurationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<PaymentMethodConfiguration> ListAutoPaging(PaymentMethodConfigurationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<PaymentMethodConfiguration> ListAutoPagingAsync(PaymentMethodConfigurationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual PaymentMethodConfiguration Update(string id, PaymentMethodConfigurationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<PaymentMethodConfiguration> UpdateAsync(string id, PaymentMethodConfigurationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
