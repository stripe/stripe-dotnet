// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class VerificationSessionService : Service<VerificationSession>,
        ICreatable<VerificationSession, VerificationSessionCreateOptions>,
        IListable<VerificationSession, VerificationSessionListOptions>,
        IRetrievable<VerificationSession, VerificationSessionGetOptions>,
        IUpdatable<VerificationSession, VerificationSessionUpdateOptions>
    {
        public VerificationSessionService()
        {
        }

        public VerificationSessionService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/identity/verification_sessions";

        /// <summary>
        /// <p>A VerificationSession object can be canceled when it is in <c>requires_input</c> <a
        /// href="https://stripe.com/docs/identity/how-sessions-work">status</a>.</p>.
        ///
        /// <p>Once canceled, future submission attempts are disabled. This cannot be undone. <a
        /// href="https://stripe.com/docs/identity/verification-sessions#cancel">Learn more</a>.</p>.
        /// </summary>
        public virtual VerificationSession Cancel(string id, VerificationSessionCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<VerificationSession>(HttpMethod.Post, $"/v1/identity/verification_sessions/{id}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>A VerificationSession object can be canceled when it is in <c>requires_input</c> <a
        /// href="https://stripe.com/docs/identity/how-sessions-work">status</a>.</p>.
        ///
        /// <p>Once canceled, future submission attempts are disabled. This cannot be undone. <a
        /// href="https://stripe.com/docs/identity/verification-sessions#cancel">Learn more</a>.</p>.
        /// </summary>
        public virtual Task<VerificationSession> CancelAsync(string id, VerificationSessionCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<VerificationSession>(HttpMethod.Post, $"/v1/identity/verification_sessions/{id}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a VerificationSession object.</p>.
        ///
        /// <p>After the VerificationSession is created, display a verification modal using the
        /// session <c>client_secret</c> or send your users to the session’s <c>url</c>.</p>.
        ///
        /// <p>If your API key is in test mode, verification checks won’t actually process, though
        /// everything else will occur as if in live mode.</p>.
        ///
        /// <p>Related guide: <a
        /// href="https://stripe.com/docs/identity/verify-identity-documents">Verify your users’
        /// identity documents</a></p>.
        /// </summary>
        public virtual VerificationSession Create(VerificationSessionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<VerificationSession>(HttpMethod.Post, $"/v1/identity/verification_sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a VerificationSession object.</p>.
        ///
        /// <p>After the VerificationSession is created, display a verification modal using the
        /// session <c>client_secret</c> or send your users to the session’s <c>url</c>.</p>.
        ///
        /// <p>If your API key is in test mode, verification checks won’t actually process, though
        /// everything else will occur as if in live mode.</p>.
        ///
        /// <p>Related guide: <a
        /// href="https://stripe.com/docs/identity/verify-identity-documents">Verify your users’
        /// identity documents</a></p>.
        /// </summary>
        public virtual Task<VerificationSession> CreateAsync(VerificationSessionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<VerificationSession>(HttpMethod.Post, $"/v1/identity/verification_sessions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of a VerificationSession that was previously created.</p>.
        ///
        /// <p>When the session status is <c>requires_input</c>, you can use this method to retrieve
        /// a valid <c>client_secret</c> or <c>url</c> to allow re-submission.</p>.
        /// </summary>
        public virtual VerificationSession Get(string id, VerificationSessionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<VerificationSession>(HttpMethod.Get, $"/v1/identity/verification_sessions/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a VerificationSession that was previously created.</p>.
        ///
        /// <p>When the session status is <c>requires_input</c>, you can use this method to retrieve
        /// a valid <c>client_secret</c> or <c>url</c> to allow re-submission.</p>.
        /// </summary>
        public virtual Task<VerificationSession> GetAsync(string id, VerificationSessionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<VerificationSession>(HttpMethod.Get, $"/v1/identity/verification_sessions/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of VerificationSessions</p>.
        /// </summary>
        public virtual StripeList<VerificationSession> List(VerificationSessionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<VerificationSession>>(HttpMethod.Get, $"/v1/identity/verification_sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of VerificationSessions</p>.
        /// </summary>
        public virtual Task<StripeList<VerificationSession>> ListAsync(VerificationSessionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<VerificationSession>>(HttpMethod.Get, $"/v1/identity/verification_sessions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of VerificationSessions</p>.
        /// </summary>
        public virtual IEnumerable<VerificationSession> ListAutoPaging(VerificationSessionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<VerificationSession>($"/v1/identity/verification_sessions", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of VerificationSessions</p>.
        /// </summary>
        public virtual IAsyncEnumerable<VerificationSession> ListAutoPagingAsync(VerificationSessionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<VerificationSession>($"/v1/identity/verification_sessions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Redact a VerificationSession to remove all collected information from Stripe. This
        /// will redact the VerificationSession and all objects related to it, including
        /// VerificationReports, Events, request logs, etc.</p>.
        ///
        /// <p>A VerificationSession object can be redacted when it is in <c>requires_input</c> or
        /// <c>verified</c> <a href="https://stripe.com/docs/identity/how-sessions-work">status</a>.
        /// Redacting a VerificationSession in <c>requires_action</c> state will automatically
        /// cancel it.</p>.
        ///
        /// <p>The redaction process may take up to four days. When the redaction process is in
        /// progress, the VerificationSession’s <c>redaction.status</c> field will be set to
        /// <c>processing</c>; when the process is finished, it will change to <c>redacted</c> and
        /// an <c>identity.verification_session.redacted</c> event will be emitted.</p>.
        ///
        /// <p>Redaction is irreversible. Redacted objects are still accessible in the Stripe API,
        /// but all the fields that contain personal data will be replaced by the string
        /// <c>[redacted]</c> or a similar placeholder. The <c>metadata</c> field will also be
        /// erased. Redacted objects cannot be updated or used for any purpose.</p>.
        ///
        /// <p><a href="https://stripe.com/docs/identity/verification-sessions#redact">Learn
        /// more</a>.</p>.
        /// </summary>
        public virtual VerificationSession Redact(string id, VerificationSessionRedactOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<VerificationSession>(HttpMethod.Post, $"/v1/identity/verification_sessions/{id}/redact", options, requestOptions);
        }

        /// <summary>
        /// <p>Redact a VerificationSession to remove all collected information from Stripe. This
        /// will redact the VerificationSession and all objects related to it, including
        /// VerificationReports, Events, request logs, etc.</p>.
        ///
        /// <p>A VerificationSession object can be redacted when it is in <c>requires_input</c> or
        /// <c>verified</c> <a href="https://stripe.com/docs/identity/how-sessions-work">status</a>.
        /// Redacting a VerificationSession in <c>requires_action</c> state will automatically
        /// cancel it.</p>.
        ///
        /// <p>The redaction process may take up to four days. When the redaction process is in
        /// progress, the VerificationSession’s <c>redaction.status</c> field will be set to
        /// <c>processing</c>; when the process is finished, it will change to <c>redacted</c> and
        /// an <c>identity.verification_session.redacted</c> event will be emitted.</p>.
        ///
        /// <p>Redaction is irreversible. Redacted objects are still accessible in the Stripe API,
        /// but all the fields that contain personal data will be replaced by the string
        /// <c>[redacted]</c> or a similar placeholder. The <c>metadata</c> field will also be
        /// erased. Redacted objects cannot be updated or used for any purpose.</p>.
        ///
        /// <p><a href="https://stripe.com/docs/identity/verification-sessions#redact">Learn
        /// more</a>.</p>.
        /// </summary>
        public virtual Task<VerificationSession> RedactAsync(string id, VerificationSessionRedactOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<VerificationSession>(HttpMethod.Post, $"/v1/identity/verification_sessions/{id}/redact", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a VerificationSession object.</p>.
        ///
        /// <p>When the session status is <c>requires_input</c>, you can use this method to update
        /// the verification check and options.</p>.
        /// </summary>
        public virtual VerificationSession Update(string id, VerificationSessionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<VerificationSession>(HttpMethod.Post, $"/v1/identity/verification_sessions/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a VerificationSession object.</p>.
        ///
        /// <p>When the session status is <c>requires_input</c>, you can use this method to update
        /// the verification check and options.</p>.
        /// </summary>
        public virtual Task<VerificationSession> UpdateAsync(string id, VerificationSessionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<VerificationSession>(HttpMethod.Post, $"/v1/identity/verification_sessions/{id}", options, requestOptions, cancellationToken);
        }
    }
}
