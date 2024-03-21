// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ChargeService : Service<Charge>,
        ICreatable<Charge, ChargeCreateOptions>,
        IListable<Charge, ChargeListOptions>,
        IRetrievable<Charge, ChargeGetOptions>,
        ISearchable<Charge, ChargeSearchOptions>,
        IUpdatable<Charge, ChargeUpdateOptions>
    {
        public ChargeService()
        {
        }

        public ChargeService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/charges";

        /// <summary>
        /// <p>Capture the payment of an existing, uncaptured charge that was created with the
        /// <c>capture</c> option set to false.</p>.
        ///
        /// <p>Uncaptured payments expire a set number of days after they are created (<a
        /// href="https://stripe.com/docs/charges/placing-a-hold">7 by default</a>), after which
        /// they are marked as refunded and capture attempts will fail.</p>.
        ///
        /// <p>Don’t use this method to capture a PaymentIntent-initiated charge. Use <a
        /// href="https://stripe.com/docs/api/payment_intents/capture">Capture a
        /// PaymentIntent</a>.</p>.
        /// </summary>
        public virtual Charge Capture(string id, ChargeCaptureOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Charge>(HttpMethod.Post, $"/v1/charges/{id}/capture", options, requestOptions);
        }

        /// <summary>
        /// <p>Capture the payment of an existing, uncaptured charge that was created with the
        /// <c>capture</c> option set to false.</p>.
        ///
        /// <p>Uncaptured payments expire a set number of days after they are created (<a
        /// href="https://stripe.com/docs/charges/placing-a-hold">7 by default</a>), after which
        /// they are marked as refunded and capture attempts will fail.</p>.
        ///
        /// <p>Don’t use this method to capture a PaymentIntent-initiated charge. Use <a
        /// href="https://stripe.com/docs/api/payment_intents/capture">Capture a
        /// PaymentIntent</a>.</p>.
        /// </summary>
        public virtual Task<Charge> CaptureAsync(string id, ChargeCaptureOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Charge>(HttpMethod.Post, $"/v1/charges/{id}/capture", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>This method is no longer recommended—use the <a
        /// href="https://stripe.com/docs/api/payment_intents">Payment Intents API</a> to initiate a
        /// new payment instead. Confirmation of the PaymentIntent creates the <c>Charge</c> object
        /// used to request payment.</p>.
        /// </summary>
        public virtual Charge Create(ChargeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Charge>(HttpMethod.Post, $"/v1/charges", options, requestOptions);
        }

        /// <summary>
        /// <p>This method is no longer recommended—use the <a
        /// href="https://stripe.com/docs/api/payment_intents">Payment Intents API</a> to initiate a
        /// new payment instead. Confirmation of the PaymentIntent creates the <c>Charge</c> object
        /// used to request payment.</p>.
        /// </summary>
        public virtual Task<Charge> CreateAsync(ChargeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Charge>(HttpMethod.Post, $"/v1/charges", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of a charge that has previously been created. Supply the unique
        /// charge ID that was returned from your previous request, and Stripe will return the
        /// corresponding charge information. The same information is returned when creating or
        /// refunding the charge.</p>.
        /// </summary>
        public virtual Charge Get(string id, ChargeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Charge>(HttpMethod.Get, $"/v1/charges/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a charge that has previously been created. Supply the unique
        /// charge ID that was returned from your previous request, and Stripe will return the
        /// corresponding charge information. The same information is returned when creating or
        /// refunding the charge.</p>.
        /// </summary>
        public virtual Task<Charge> GetAsync(string id, ChargeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Charge>(HttpMethod.Get, $"/v1/charges/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of charges you’ve previously created. The charges are returned in
        /// sorted order, with the most recent charges appearing first.</p>.
        /// </summary>
        public virtual StripeList<Charge> List(ChargeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Charge>>(HttpMethod.Get, $"/v1/charges", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of charges you’ve previously created. The charges are returned in
        /// sorted order, with the most recent charges appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<Charge>> ListAsync(ChargeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Charge>>(HttpMethod.Get, $"/v1/charges", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of charges you’ve previously created. The charges are returned in
        /// sorted order, with the most recent charges appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<Charge> ListAutoPaging(ChargeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Charge>($"/v1/charges", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of charges you’ve previously created. The charges are returned in
        /// sorted order, with the most recent charges appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Charge> ListAutoPagingAsync(ChargeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Charge>($"/v1/charges", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Search for charges you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual StripeSearchResult<Charge> Search(ChargeSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeSearchResult<Charge>>(HttpMethod.Get, $"/v1/charges/search", options, requestOptions);
        }

        /// <summary>
        /// <p>Search for charges you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual Task<StripeSearchResult<Charge>> SearchAsync(ChargeSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeSearchResult<Charge>>(HttpMethod.Get, $"/v1/charges/search", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Search for charges you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual IEnumerable<Charge> SearchAutoPaging(ChargeSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.SearchRequestAutoPaging<Charge>($"/v1/charges/search", options, requestOptions);
        }

        /// <summary>
        /// <p>Search for charges you’ve previously created using Stripe’s <a
        /// href="https://stripe.com/docs/search#search-query-language">Search Query Language</a>.
        /// Don’t use search in read-after-write flows where strict consistency is necessary. Under
        /// normal operating conditions, data is searchable in less than a minute. Occasionally,
        /// propagation of new or updated data can be up to an hour behind during outages. Search
        /// functionality is not available to merchants in India.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Charge> SearchAutoPagingAsync(ChargeSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.SearchRequestAutoPagingAsync<Charge>($"/v1/charges/search", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the specified charge by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged.</p>.
        /// </summary>
        public virtual Charge Update(string id, ChargeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Charge>(HttpMethod.Post, $"/v1/charges/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specified charge by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged.</p>.
        /// </summary>
        public virtual Task<Charge> UpdateAsync(string id, ChargeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Charge>(HttpMethod.Post, $"/v1/charges/{id}", options, requestOptions, cancellationToken);
        }
    }
}
