namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class AuthorizationService : StripeService,
        IListable<Authorization, AuthorizationListOptions>,
        IRetrievable<Authorization>,
        IUpdatable<Authorization, AuthorizationUpdateOptions>
    {
        private static string classUrl = Urls.BaseUrl + "/issuing/authorizations";

        public AuthorizationService()
            : base(null)
        {
        }

        public AuthorizationService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Authorization Approve(string authorizationId, AuthorizationApproveOptions approveOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<Authorization>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(approveOptions, $"{classUrl}/{authorizationId}/approve", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Authorization Decline(string authorizationId, AuthorizationDeclineOptions declineOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<Authorization>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(declineOptions, $"{classUrl}/{authorizationId}/decline", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Authorization Update(string authorizationId, AuthorizationUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Authorization>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{authorizationId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Authorization Get(string authorizationId, RequestOptions requestOptions = null)
        {
            return Mapper<Authorization>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{classUrl}/{authorizationId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<Authorization> List(AuthorizationListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<Authorization>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Authorization> ApproveAsync(string authorizationId, AuthorizationApproveOptions approveOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Authorization>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(approveOptions, $"{classUrl}/{authorizationId}/approve", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Authorization> DeclineAsync(string authorizationId, AuthorizationDeclineOptions declineOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Authorization>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(declineOptions, $"{classUrl}/{authorizationId}/decline", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Authorization> UpdateAsync(string authorizationId, AuthorizationUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Authorization>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{authorizationId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Authorization> GetAsync(string authorizationId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Authorization>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{classUrl}/{authorizationId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<Authorization>> ListAsync(AuthorizationListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<Authorization>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
