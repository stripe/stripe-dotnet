// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PersonService : Service
    {
        internal PersonService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal PersonService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create a Person associated with an Account.
        /// </summary>
        public virtual V2.Core.AccountPerson Create(string id, PersonCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Core.AccountPerson>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/accounts/{WebUtility.UrlEncode(id)}/persons", options, requestOptions);
        }

        /// <summary>
        /// Create a Person associated with an Account.
        /// </summary>
        public virtual Task<V2.Core.AccountPerson> CreateAsync(string id, PersonCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Core.AccountPerson>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/accounts/{WebUtility.UrlEncode(id)}/persons", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Delete a Person associated with an Account.
        /// </summary>
        public virtual V2.DeletedObject Delete(string parentId, string id, PersonDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.DeletedObject>(BaseAddress.Api, HttpMethod.Delete, $"/v2/core/accounts/{WebUtility.UrlEncode(parentId)}/persons/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Delete a Person associated with an Account.
        /// </summary>
        public virtual Task<V2.DeletedObject> DeleteAsync(string parentId, string id, PersonDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.DeletedObject>(BaseAddress.Api, HttpMethod.Delete, $"/v2/core/accounts/{WebUtility.UrlEncode(parentId)}/persons/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a Person associated with an Account.
        /// </summary>
        public virtual V2.Core.AccountPerson Get(string parentId, string id, PersonGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Core.AccountPerson>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/accounts/{WebUtility.UrlEncode(parentId)}/persons/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a Person associated with an Account.
        /// </summary>
        public virtual Task<V2.Core.AccountPerson> GetAsync(string parentId, string id, PersonGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Core.AccountPerson>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/accounts/{WebUtility.UrlEncode(parentId)}/persons/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of Persons associated with an Account.
        /// </summary>
        public virtual V2.StripeList<V2.Core.AccountPerson> List(string id, PersonListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<V2.Core.AccountPerson>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/accounts/{WebUtility.UrlEncode(id)}/persons", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of Persons associated with an Account.
        /// </summary>
        public virtual Task<V2.StripeList<V2.Core.AccountPerson>> ListAsync(string id, PersonListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<V2.Core.AccountPerson>>(BaseAddress.Api, HttpMethod.Get, $"/v2/core/accounts/{WebUtility.UrlEncode(id)}/persons", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of Persons associated with an Account.
        /// </summary>
        public virtual IEnumerable<V2.Core.AccountPerson> ListAutoPaging(string id, PersonListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<V2.Core.AccountPerson>($"/v2/core/accounts/{WebUtility.UrlEncode(id)}/persons", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of Persons associated with an Account.
        /// </summary>
        public virtual IAsyncEnumerable<V2.Core.AccountPerson> ListAutoPagingAsync(string id, PersonListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<V2.Core.AccountPerson>($"/v2/core/accounts/{WebUtility.UrlEncode(id)}/persons", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Updates a Person associated with an Account.
        /// </summary>
        public virtual V2.Core.AccountPerson Update(string parentId, string id, PersonUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<V2.Core.AccountPerson>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/accounts/{WebUtility.UrlEncode(parentId)}/persons/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Updates a Person associated with an Account.
        /// </summary>
        public virtual Task<V2.Core.AccountPerson> UpdateAsync(string parentId, string id, PersonUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.Core.AccountPerson>(BaseAddress.Api, HttpMethod.Post, $"/v2/core/accounts/{WebUtility.UrlEncode(parentId)}/persons/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
