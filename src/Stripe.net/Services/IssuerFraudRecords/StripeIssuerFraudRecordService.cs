using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeIssuerFraudRecordService : StripeService
    {
        public StripeIssuerFraudRecordService() : base(null) { }
        public StripeIssuerFraudRecordService(string apiKey) : base(apiKey) { }

        public bool ExpandCharge { get; set; }



        //Sync
        public virtual StripeIssuerFraudRecord Get(string issuerFraudRecordId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeIssuerFraudRecord>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.IssuerFraudRecords}/{issuerFraudRecordId}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeList<StripeIssuerFraudRecord> List(StripeIssuerFraudRecordListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeIssuerFraudRecord>>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, Urls.IssuerFraudRecords, true),
                SetupRequestOptions(requestOptions))
            );
        }



        //Async
        public virtual async Task<StripeIssuerFraudRecord> GetAsync(string issuerFraudRecordId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeIssuerFraudRecord>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.IssuerFraudRecords}/{issuerFraudRecordId}", false),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }

        public virtual async Task<StripeList<StripeIssuerFraudRecord>> ListAsync(StripeIssuerFraudRecordListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeIssuerFraudRecord>>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, Urls.IssuerFraudRecords, true),
                SetupRequestOptions(requestOptions),
                cancellationToken).ConfigureAwait(false)
            );
        }
    }
}
