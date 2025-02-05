// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerPaymentSourceService : Service,
        INestedCreatable<IPaymentSource, CustomerPaymentSourceCreateOptions>,
        INestedDeletable<IPaymentSource, CustomerPaymentSourceDeleteOptions>,
        INestedListable<IPaymentSource, CustomerPaymentSourceListOptions>,
        INestedRetrievable<IPaymentSource, CustomerPaymentSourceGetOptions>,
        INestedUpdatable<IPaymentSource, CustomerPaymentSourceUpdateOptions>
    {
        public CustomerPaymentSourceService()
        {
        }

        internal CustomerPaymentSourceService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerPaymentSourceService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>When you create a new credit card, you must specify a customer or recipient on which
        /// to create it.</p>.
        ///
        /// <p>If the card’s owner has no default card, then the new card will become the default.
        /// However, if the owner already has a default, then it will not change. To change the
        /// default, you should <a href="https://stripe.com/docs/api#update_customer">update the
        /// customer</a> to have a new <c>default_source</c>.</p>.
        /// </summary>
        public virtual IPaymentSource Create(string parentId, CustomerPaymentSourceCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IPaymentSource>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources", options, requestOptions);
        }

        /// <summary>
        /// <p>When you create a new credit card, you must specify a customer or recipient on which
        /// to create it.</p>.
        ///
        /// <p>If the card’s owner has no default card, then the new card will become the default.
        /// However, if the owner already has a default, then it will not change. To change the
        /// default, you should <a href="https://stripe.com/docs/api#update_customer">update the
        /// customer</a> to have a new <c>default_source</c>.</p>.
        /// </summary>
        public virtual Task<IPaymentSource> CreateAsync(string parentId, CustomerPaymentSourceCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IPaymentSource>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Delete a specified source for a given customer.</p>.
        /// </summary>
        public virtual IPaymentSource Delete(string parentId, string id, CustomerPaymentSourceDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IPaymentSource>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Delete a specified source for a given customer.</p>.
        /// </summary>
        public virtual Task<IPaymentSource> DeleteAsync(string parentId, string id, CustomerPaymentSourceDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IPaymentSource>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieve a specified source for a given customer.</p>.
        /// </summary>
        public virtual IPaymentSource Get(string parentId, string id, CustomerPaymentSourceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<IPaymentSource>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve a specified source for a given customer.</p>.
        /// </summary>
        public virtual Task<IPaymentSource> GetAsync(string parentId, string id, CustomerPaymentSourceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IPaymentSource>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List sources for a specified customer.</p>.
        /// </summary>
        public virtual StripeList<IPaymentSource> List(string parentId, CustomerPaymentSourceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<IPaymentSource>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources", options, requestOptions);
        }

        /// <summary>
        /// <p>List sources for a specified customer.</p>.
        /// </summary>
        public virtual Task<StripeList<IPaymentSource>> ListAsync(string parentId, CustomerPaymentSourceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<IPaymentSource>>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>List sources for a specified customer.</p>.
        /// </summary>
        public virtual IEnumerable<IPaymentSource> ListAutoPaging(string parentId, CustomerPaymentSourceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<IPaymentSource>($"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources", options, requestOptions);
        }

        /// <summary>
        /// <p>List sources for a specified customer.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<IPaymentSource> ListAutoPagingAsync(string parentId, CustomerPaymentSourceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<IPaymentSource>($"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Update a specified source for a given customer.</p>.
        /// </summary>
        public virtual IPaymentSource Update(string parentId, string id, CustomerPaymentSourceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<IPaymentSource>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Update a specified source for a given customer.</p>.
        /// </summary>
        public virtual Task<IPaymentSource> UpdateAsync(string parentId, string id, CustomerPaymentSourceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<IPaymentSource>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Verify a specified bank account for a given customer.</p>.
        /// </summary>
        public virtual BankAccount Verify(string parentId, string id, CustomerPaymentSourceVerifyOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<BankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}/verify", options, requestOptions);
        }

        /// <summary>
        /// <p>Verify a specified bank account for a given customer.</p>.
        /// </summary>
        public virtual Task<BankAccount> VerifyAsync(string parentId, string id, CustomerPaymentSourceVerifyOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BankAccount>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/sources/{WebUtility.UrlEncode(id)}/verify", options, requestOptions, cancellationToken);
        }
    }
}
