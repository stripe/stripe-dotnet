// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RegistrationService : Service<Registration>,
        ICreatable<Registration, RegistrationCreateOptions>,
        IListable<Registration, RegistrationListOptions>,
        IRetrievable<Registration, RegistrationGetOptions>,
        IUpdatable<Registration, RegistrationUpdateOptions>
    {
        public RegistrationService()
            : base(null)
        {
        }

        public RegistrationService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/tax/registrations";

        public virtual Registration Create(RegistrationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Registration>(HttpMethod.Post, $"/v1/tax/registrations", options, requestOptions);
        }

        public virtual Task<Registration> CreateAsync(RegistrationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Registration>(HttpMethod.Post, $"/v1/tax/registrations", options, requestOptions, cancellationToken);
        }

        public virtual Registration Get(string id, RegistrationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Registration>(HttpMethod.Get, $"/v1/tax/registrations/{id}", options, requestOptions);
        }

        public virtual Task<Registration> GetAsync(string id, RegistrationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Registration>(HttpMethod.Get, $"/v1/tax/registrations/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Registration> List(RegistrationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Registration>>(HttpMethod.Get, $"/v1/tax/registrations", options, requestOptions);
        }

        public virtual Task<StripeList<Registration>> ListAsync(RegistrationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Registration>>(HttpMethod.Get, $"/v1/tax/registrations", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Registration> ListAutoPaging(RegistrationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Registration>($"/v1/tax/registrations", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Registration> ListAutoPagingAsync(RegistrationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Registration>($"/v1/tax/registrations", options, requestOptions, cancellationToken);
        }

        public virtual Registration Update(string id, RegistrationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Registration>(HttpMethod.Post, $"/v1/tax/registrations/{id}", options, requestOptions);
        }

        public virtual Task<Registration> UpdateAsync(string id, RegistrationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Registration>(HttpMethod.Post, $"/v1/tax/registrations/{id}", options, requestOptions, cancellationToken);
        }
    }
}
