namespace Stripe.Reporting
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ReportTypeService : StripeService,
        IListable<ReportType, ReportTypeListOptions>,
        IRetrievable<ReportType>
    {
        private static string classUrl = Urls.BaseUrl + "/reporting/report_types";

        public ReportTypeService()
            : base(null)
        {
        }

        public ReportTypeService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual ReportType Get(string reportTypeId, RequestOptions requestOptions = null)
        {
            return Mapper<ReportType>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{classUrl}/{reportTypeId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<ReportType> List(ReportTypeListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<ReportType>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<ReportType> GetAsync(string reportTypeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<ReportType>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{classUrl}/{reportTypeId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<ReportType>> ListAsync(ReportTypeListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<ReportType>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}
