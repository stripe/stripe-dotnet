// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class FormService : Service,
        IRetrievable<Form, FormGetOptions>,
        IUpdatable<Form, FormUpdateOptions>
    {
        public FormService()
        {
        }

        internal FormService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public FormService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves a risk Form by ID.</p>.
        ///
        /// <h3>Error Codes</h3>.
        ///
        /// <p>| Code | HTTP status | Description | | — | — | — | | <c>form_not_found</c> | 400 | No
        /// Form matches the supplied ID. |</p>.
        /// </summary>
        public virtual Form Get(string id, FormGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Form>(BaseAddress.Api, HttpMethod.Get, $"/v1/risk/forms/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a risk Form by ID.</p>.
        ///
        /// <h3>Error Codes</h3>.
        ///
        /// <p>| Code | HTTP status | Description | | — | — | — | | <c>form_not_found</c> | 400 | No
        /// Form matches the supplied ID. |</p>.
        /// </summary>
        public virtual Task<Form> GetAsync(string id, FormGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Form>(BaseAddress.Api, HttpMethod.Get, $"/v1/risk/forms/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a risk Form with the connected account’s response.</p>.
        ///
        /// <h3>Error Codes</h3>.
        ///
        /// <p>| Code | HTTP status | Description | | — | — | — | | <c>form_not_found</c> | 400 | No
        /// Form matches the supplied ID. | | <c>form_closed</c> | 400 | The Form is closed and
        /// cannot accept updates. | | <c>invalid_field_for_form_type</c> | 400 | A submitted field
        /// is not supported by this Form type. | | <c>form_field_already_submitted</c> | 400 | A
        /// submitted field has already been submitted. | | <c>form_insufficient_fields</c> | 400 |
        /// Required fields are missing for this Form type. | | <c>resource_missing</c> | 404 | A
        /// submitted file does not exist or is not accessible to the requesting account. |</p>.
        /// </summary>
        public virtual Form Update(string id, FormUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Form>(BaseAddress.Api, HttpMethod.Post, $"/v1/risk/forms/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a risk Form with the connected account’s response.</p>.
        ///
        /// <h3>Error Codes</h3>.
        ///
        /// <p>| Code | HTTP status | Description | | — | — | — | | <c>form_not_found</c> | 400 | No
        /// Form matches the supplied ID. | | <c>form_closed</c> | 400 | The Form is closed and
        /// cannot accept updates. | | <c>invalid_field_for_form_type</c> | 400 | A submitted field
        /// is not supported by this Form type. | | <c>form_field_already_submitted</c> | 400 | A
        /// submitted field has already been submitted. | | <c>form_insufficient_fields</c> | 400 |
        /// Required fields are missing for this Form type. | | <c>resource_missing</c> | 404 | A
        /// submitted file does not exist or is not accessible to the requesting account. |</p>.
        /// </summary>
        public virtual Task<Form> UpdateAsync(string id, FormUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Form>(BaseAddress.Api, HttpMethod.Post, $"/v1/risk/forms/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
