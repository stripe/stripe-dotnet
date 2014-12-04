using System.Threading.Tasks;

namespace Stripe
{
    public class StripeDisputeService : StripeService
    {
        public StripeDisputeService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCharge { get; set; }
        public bool ExpandBalanceTransaction { get; set; }

        public virtual StripeDispute Update(string chargeId, string evidence = null)
        {
            var url = FormatUpdateUrl(chargeId, evidence);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeDispute>.MapFromJson(response);
        }

        public virtual async Task<StripeDispute> UpdateAsync(string chargeId, string evidence = null)
        {
            var url = FormatUpdateUrl(chargeId, evidence);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeDispute>.MapFromJson(response);
        }

        private string FormatUpdateUrl(string chargeId, string evidence)
        {
            var url = string.Format("{0}/dispute", chargeId);
            url = this.ApplyAllParameters(null, url, false);

            if (!string.IsNullOrEmpty(evidence))
                url = ParameterBuilder.ApplyParameterToUrl(url, "evidence", evidence);
            return url;
        }
    }
}