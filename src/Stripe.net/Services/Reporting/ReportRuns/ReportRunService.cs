namespace Stripe.Reporting
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ReportRunService : StripeService,
        ICreatable<ReportRun, ReportRunCreateOptions>,
        IListable<ReportRun, ReportRunListOptions>,
        IRetrievable<ReportRun>
    {
        private static string classUrl = Urls.BaseUrl + "/reporting/report_runs";

        public ReportRunService()
            : base(null)
        {
        }

        public ReportRunService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual ReportRun Create(ReportRunCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<ReportRun>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual ReportRun Get(string reportRunId, RequestOptions requestOptions = null)
        {
            return Mapper<ReportRun>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{classUrl}/{reportRunId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<ReportRun> List(ReportRunListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<ReportRun>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<ReportRun> CreateAsync(ReportRunCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<ReportRun>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<ReportRun> GetAsync(string reportRunId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<ReportRun>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{classUrl}/{reportRunId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<ReportRun>> ListAsync(ReportRunListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<ReportRun>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
