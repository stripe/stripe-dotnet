// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
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
        {
        }

        public RegistrationService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/tax/registrations";

        /// <summary>
        /// <p>Creates a new Tax <c>Registration</c> object.</p>.
        /// </summary>
        public virtual Registration Create(RegistrationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Registration>(HttpMethod.Post, $"/v1/tax/registrations", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new Tax <c>Registration</c> object.</p>.
        /// </summary>
        public virtual Task<Registration> CreateAsync(RegistrationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Registration>(HttpMethod.Post, $"/v1/tax/registrations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a Tax <c>Registration</c> object.</p>.
        /// </summary>
        public virtual Registration Get(string id, RegistrationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Registration>(HttpMethod.Get, $"/v1/tax/registrations/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a Tax <c>Registration</c> object.</p>.
        /// </summary>
        public virtual Task<Registration> GetAsync(string id, RegistrationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Registration>(HttpMethod.Get, $"/v1/tax/registrations/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Tax <c>Registration</c> objects.</p>.
        /// </summary>
        public virtual StripeList<Registration> List(RegistrationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Registration>>(HttpMethod.Get, $"/v1/tax/registrations", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Tax <c>Registration</c> objects.</p>.
        /// </summary>
        public virtual Task<StripeList<Registration>> ListAsync(RegistrationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Registration>>(HttpMethod.Get, $"/v1/tax/registrations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of Tax <c>Registration</c> objects.</p>.
        /// </summary>
        public virtual IEnumerable<Registration> ListAutoPaging(RegistrationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Registration>($"/v1/tax/registrations", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of Tax <c>Registration</c> objects.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Registration> ListAutoPagingAsync(RegistrationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Registration>($"/v1/tax/registrations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates an existing Tax <c>Registration</c> object.</p>.
        ///
        /// <p>A registration cannot be deleted after it has been created. If you wish to end a
        /// registration you may do so by setting <c>expires_at</c>.</p>.
        /// </summary>
        public virtual Registration Update(string id, RegistrationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Registration>(HttpMethod.Post, $"/v1/tax/registrations/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates an existing Tax <c>Registration</c> object.</p>.
        ///
        /// <p>A registration cannot be deleted after it has been created. If you wish to end a
        /// registration you may do so by setting <c>expires_at</c>.</p>.
        /// </summary>
        public virtual Task<Registration> UpdateAsync(string id, RegistrationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Registration>(HttpMethod.Post, $"/v1/tax/registrations/{id}", options, requestOptions, cancellationToken);
        }
    }
}
