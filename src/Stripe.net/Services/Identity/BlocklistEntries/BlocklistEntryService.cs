// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class BlocklistEntryService : Service,
        ICreatable<BlocklistEntry, BlocklistEntryCreateOptions>,
        IListable<BlocklistEntry, BlocklistEntryListOptions>,
        IRetrievable<BlocklistEntry, BlocklistEntryGetOptions>
    {
        public BlocklistEntryService()
        {
        }

        internal BlocklistEntryService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public BlocklistEntryService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a BlocklistEntry object from a verification report.</p>.
        ///
        /// <p>A blocklist entry prevents future identity verifications that match the same identity
        /// information. You can create blocklist entries from verification reports that contain
        /// document extracted data or a selfie.</p>.
        ///
        /// <p>Related guide: <a
        /// href="https://stripe.com/docs/identity/review-tools#add-a-blocklist-entry">Identity
        /// Verification Blocklist</a></p>.
        /// </summary>
        public virtual BlocklistEntry Create(BlocklistEntryCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<BlocklistEntry>(BaseAddress.Api, HttpMethod.Post, $"/v1/identity/blocklist_entries", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a BlocklistEntry object from a verification report.</p>.
        ///
        /// <p>A blocklist entry prevents future identity verifications that match the same identity
        /// information. You can create blocklist entries from verification reports that contain
        /// document extracted data or a selfie.</p>.
        ///
        /// <p>Related guide: <a
        /// href="https://stripe.com/docs/identity/review-tools#add-a-blocklist-entry">Identity
        /// Verification Blocklist</a></p>.
        /// </summary>
        public virtual Task<BlocklistEntry> CreateAsync(BlocklistEntryCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BlocklistEntry>(BaseAddress.Api, HttpMethod.Post, $"/v1/identity/blocklist_entries", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Disables a BlocklistEntry object.</p>.
        ///
        /// <p>After a BlocklistEntry is disabled, it will no longer block future verifications that
        /// match the same information. This action is irreversible. To re-enable it, a new
        /// BlocklistEntry must be created using the same verification report.</p>.
        ///
        /// <p>Related guide: <a
        /// href="https://stripe.com/docs/identity/review-tools#disable-a-blocklist-entry">Identity
        /// Verification Blocklist</a></p>.
        /// </summary>
        public virtual BlocklistEntry Disable(string id, BlocklistEntryDisableOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<BlocklistEntry>(BaseAddress.Api, HttpMethod.Post, $"/v1/identity/blocklist_entries/{WebUtility.UrlEncode(id)}/disable", options, requestOptions);
        }

        /// <summary>
        /// <p>Disables a BlocklistEntry object.</p>.
        ///
        /// <p>After a BlocklistEntry is disabled, it will no longer block future verifications that
        /// match the same information. This action is irreversible. To re-enable it, a new
        /// BlocklistEntry must be created using the same verification report.</p>.
        ///
        /// <p>Related guide: <a
        /// href="https://stripe.com/docs/identity/review-tools#disable-a-blocklist-entry">Identity
        /// Verification Blocklist</a></p>.
        /// </summary>
        public virtual Task<BlocklistEntry> DisableAsync(string id, BlocklistEntryDisableOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BlocklistEntry>(BaseAddress.Api, HttpMethod.Post, $"/v1/identity/blocklist_entries/{WebUtility.UrlEncode(id)}/disable", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a BlocklistEntry object by its identifier.</p>.
        ///
        /// <p>Related guide: <a
        /// href="https://stripe.com/docs/identity/review-tools#block-list">Identity Verification
        /// Blocklist</a></p>.
        /// </summary>
        public virtual BlocklistEntry Get(string id, BlocklistEntryGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<BlocklistEntry>(BaseAddress.Api, HttpMethod.Get, $"/v1/identity/blocklist_entries/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a BlocklistEntry object by its identifier.</p>.
        ///
        /// <p>Related guide: <a
        /// href="https://stripe.com/docs/identity/review-tools#block-list">Identity Verification
        /// Blocklist</a></p>.
        /// </summary>
        public virtual Task<BlocklistEntry> GetAsync(string id, BlocklistEntryGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BlocklistEntry>(BaseAddress.Api, HttpMethod.Get, $"/v1/identity/blocklist_entries/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of BlocklistEntry objects associated with your account.</p>.
        ///
        /// <p>The blocklist entries are returned sorted by creation date, with the most recently
        /// created entries appearing first.</p>.
        ///
        /// <p>Related guide: <a
        /// href="https://stripe.com/docs/identity/review-tools#block-list">Identity Verification
        /// Blocklist</a></p>.
        /// </summary>
        public virtual StripeList<BlocklistEntry> List(BlocklistEntryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<BlocklistEntry>>(BaseAddress.Api, HttpMethod.Get, $"/v1/identity/blocklist_entries", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of BlocklistEntry objects associated with your account.</p>.
        ///
        /// <p>The blocklist entries are returned sorted by creation date, with the most recently
        /// created entries appearing first.</p>.
        ///
        /// <p>Related guide: <a
        /// href="https://stripe.com/docs/identity/review-tools#block-list">Identity Verification
        /// Blocklist</a></p>.
        /// </summary>
        public virtual Task<StripeList<BlocklistEntry>> ListAsync(BlocklistEntryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<BlocklistEntry>>(BaseAddress.Api, HttpMethod.Get, $"/v1/identity/blocklist_entries", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of BlocklistEntry objects associated with your account.</p>.
        ///
        /// <p>The blocklist entries are returned sorted by creation date, with the most recently
        /// created entries appearing first.</p>.
        ///
        /// <p>Related guide: <a
        /// href="https://stripe.com/docs/identity/review-tools#block-list">Identity Verification
        /// Blocklist</a></p>.
        /// </summary>
        public virtual IEnumerable<BlocklistEntry> ListAutoPaging(BlocklistEntryListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<BlocklistEntry>($"/v1/identity/blocklist_entries", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of BlocklistEntry objects associated with your account.</p>.
        ///
        /// <p>The blocklist entries are returned sorted by creation date, with the most recently
        /// created entries appearing first.</p>.
        ///
        /// <p>Related guide: <a
        /// href="https://stripe.com/docs/identity/review-tools#block-list">Identity Verification
        /// Blocklist</a></p>.
        /// </summary>
        public virtual IAsyncEnumerable<BlocklistEntry> ListAutoPagingAsync(BlocklistEntryListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<BlocklistEntry>($"/v1/identity/blocklist_entries", options, requestOptions, cancellationToken);
        }
    }
}
