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
        /// cannot accept updates. | | <c>invalid_field_for_form_type</c> | 400 | Submitted fields
        /// contain invalid values. | | <c>form_field_already_submitted</c> | 400 | A submitted
        /// field has already been submitted. | | <c>form_insufficient_fields</c> | 400 | Required
        /// fields are missing for this Form type. | | <c>resource_missing</c> | 404 | A submitted
        /// file does not exist or is not accessible to the requesting account. |</p>.
        ///
        /// <p>Validation errors include a summary in <c>message</c>. Missing required properties
        /// use <c>form_insufficient_fields</c> and include <c>missing_fields</c>, an array of
        /// public dotted paths. Missing required properties take precedence over value
        /// violations.</p>.
        ///
        /// <p>Invalid values use <c>invalid_field_for_form_type</c> and include <c>violations</c>.
        /// Each violation has a public dotted <c>field</c> path and a <c>reason</c> of
        /// <c>missing_value</c> or <c>invalid_value</c>. Reviewed-field violations include a
        /// corrective <c>message</c>; corrective messages for other Form types are omitted. For an
        /// array member, <c>target</c> identifies the member’s field path. For a scalar value,
        /// <c>target</c> is explicitly null.</p>.
        ///
        /// <p>For example, a reviewed-fields submission with an out-of-date timestamp and an
        /// omitted requested member returns both violations:</p>.
        ///
        /// <p><c>json { "error": { "type": "invalid_request_error", "code":
        /// "invalid_field_for_form_type", "message": "Submitted fields are invalid for Form type
        /// reviewed_fields. See violations for details and corrective actions for these fields:
        /// ’reviewed_fields.attestation.attested_at’, ’reviewed_fields.attestation.fields’.",
        /// "violations": [ { "field": "reviewed_fields.attestation.attested_at", "reason":
        /// "invalid_value", "message": "The attestation timestamp is out of date. Review and attest
        /// the requested information again, then provide the new attestation timestamp.", "target":
        /// null }, { "field": "reviewed_fields.attestation.fields", "reason": "missing_value",
        /// "message": "’defaults.profile.product_description’ is required by
        /// subject.fields_to_review but is missing from reviewed_fields.attestation.fields. Review
        /// this information, then include its path in the attestation.", "target":
        /// "defaults.profile.product_description" } ] } } </c></p>.
        ///
        /// <p>A v1 request with no extracted field submissions is rejected before the Form is
        /// loaded, including for reviewed-fields Forms. This early error uses
        /// <c>form_insufficient_fields</c> and omits <c>missing_fields</c>, <c>violations</c>, and
        /// <c>param</c>. Partially populated reviewed-fields requests use structured
        /// missing-property validation.</p>.
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
        /// cannot accept updates. | | <c>invalid_field_for_form_type</c> | 400 | Submitted fields
        /// contain invalid values. | | <c>form_field_already_submitted</c> | 400 | A submitted
        /// field has already been submitted. | | <c>form_insufficient_fields</c> | 400 | Required
        /// fields are missing for this Form type. | | <c>resource_missing</c> | 404 | A submitted
        /// file does not exist or is not accessible to the requesting account. |</p>.
        ///
        /// <p>Validation errors include a summary in <c>message</c>. Missing required properties
        /// use <c>form_insufficient_fields</c> and include <c>missing_fields</c>, an array of
        /// public dotted paths. Missing required properties take precedence over value
        /// violations.</p>.
        ///
        /// <p>Invalid values use <c>invalid_field_for_form_type</c> and include <c>violations</c>.
        /// Each violation has a public dotted <c>field</c> path and a <c>reason</c> of
        /// <c>missing_value</c> or <c>invalid_value</c>. Reviewed-field violations include a
        /// corrective <c>message</c>; corrective messages for other Form types are omitted. For an
        /// array member, <c>target</c> identifies the member’s field path. For a scalar value,
        /// <c>target</c> is explicitly null.</p>.
        ///
        /// <p>For example, a reviewed-fields submission with an out-of-date timestamp and an
        /// omitted requested member returns both violations:</p>.
        ///
        /// <p><c>json { "error": { "type": "invalid_request_error", "code":
        /// "invalid_field_for_form_type", "message": "Submitted fields are invalid for Form type
        /// reviewed_fields. See violations for details and corrective actions for these fields:
        /// ’reviewed_fields.attestation.attested_at’, ’reviewed_fields.attestation.fields’.",
        /// "violations": [ { "field": "reviewed_fields.attestation.attested_at", "reason":
        /// "invalid_value", "message": "The attestation timestamp is out of date. Review and attest
        /// the requested information again, then provide the new attestation timestamp.", "target":
        /// null }, { "field": "reviewed_fields.attestation.fields", "reason": "missing_value",
        /// "message": "’defaults.profile.product_description’ is required by
        /// subject.fields_to_review but is missing from reviewed_fields.attestation.fields. Review
        /// this information, then include its path in the attestation.", "target":
        /// "defaults.profile.product_description" } ] } } </c></p>.
        ///
        /// <p>A v1 request with no extracted field submissions is rejected before the Form is
        /// loaded, including for reviewed-fields Forms. This early error uses
        /// <c>form_insufficient_fields</c> and omits <c>missing_fields</c>, <c>violations</c>, and
        /// <c>param</c>. Partially populated reviewed-fields requests use structured
        /// missing-property validation.</p>.
        /// </summary>
        public virtual Task<Form> UpdateAsync(string id, FormUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Form>(BaseAddress.Api, HttpMethod.Post, $"/v1/risk/forms/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
