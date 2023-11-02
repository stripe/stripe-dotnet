// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentMethodDomainService : Service<PaymentMethodDomain>,
        ICreatable<PaymentMethodDomain, PaymentMethodDomainCreateOptions>,
        IListable<PaymentMethodDomain, PaymentMethodDomainListOptions>,
        IRetrievable<PaymentMethodDomain, PaymentMethodDomainGetOptions>,
        IUpdatable<PaymentMethodDomain, PaymentMethodDomainUpdateOptions>
    {
        public PaymentMethodDomainService()
            : base(null)
        {
        }

        public PaymentMethodDomainService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/payment_method_domains";

        public virtual PaymentMethodDomain Create(PaymentMethodDomainCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethodDomain>(HttpMethod.Post, $"/v1/payment_method_domains", options, requestOptions);
        }

        public virtual Task<PaymentMethodDomain> CreateAsync(PaymentMethodDomainCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethodDomain>(HttpMethod.Post, $"/v1/payment_method_domains", options, requestOptions, cancellationToken);
        }

        public virtual PaymentMethodDomain Get(string id, PaymentMethodDomainGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethodDomain>(HttpMethod.Get, $"/v1/payment_method_domains/{id}", options, requestOptions);
        }

        public virtual Task<PaymentMethodDomain> GetAsync(string id, PaymentMethodDomainGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethodDomain>(HttpMethod.Get, $"/v1/payment_method_domains/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<PaymentMethodDomain> List(PaymentMethodDomainListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<PaymentMethodDomain>>(HttpMethod.Get, $"/v1/payment_method_domains", options, requestOptions);
        }

        public virtual Task<StripeList<PaymentMethodDomain>> ListAsync(PaymentMethodDomainListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<PaymentMethodDomain>>(HttpMethod.Get, $"/v1/payment_method_domains", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<PaymentMethodDomain> ListAutoPaging(PaymentMethodDomainListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PaymentMethodDomain>($"/v1/payment_method_domains", options, requestOptions);
        }

        public virtual IAsyncEnumerable<PaymentMethodDomain> ListAutoPagingAsync(PaymentMethodDomainListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PaymentMethodDomain>($"/v1/payment_method_domains", options, requestOptions, cancellationToken);
        }

        public virtual PaymentMethodDomain Update(string id, PaymentMethodDomainUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethodDomain>(HttpMethod.Post, $"/v1/payment_method_domains/{id}", options, requestOptions);
        }

        public virtual Task<PaymentMethodDomain> UpdateAsync(string id, PaymentMethodDomainUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethodDomain>(HttpMethod.Post, $"/v1/payment_method_domains/{id}", options, requestOptions, cancellationToken);
        }

        public virtual PaymentMethodDomain Validate(string id, PaymentMethodDomainValidateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PaymentMethodDomain>(HttpMethod.Post, $"/v1/payment_method_domains/{id}/validate", options, requestOptions);
        }

        public virtual Task<PaymentMethodDomain> ValidateAsync(string id, PaymentMethodDomainValidateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PaymentMethodDomain>(HttpMethod.Post, $"/v1/payment_method_domains/{id}/validate", options, requestOptions, cancellationToken);
        }
    }
}
