using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeTransferReversalService : StripeBasicService<StripeTransfer>
    {
        public StripeTransferReversalService(string apiKey = null) : base(apiKey) { }

        public bool ExpandBalanceTransaction { get; set; }
        public bool ExpandTransfer { get; set; }


        //Sync
        public virtual StripeTransferReversal Create(string transferId, StripeTransferReversalCreateOptions createOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeTransferReversal>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, $"{Urls.BaseUrl}/transfers/{transferId}/reversals"),
                    SetupRequestOptions(requestOptions)
                )
            );
        }
        
        public virtual StripeTransferReversal Get(string transferId, string reversalId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeTransferReversal>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}"),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        public virtual StripeTransferReversal Update(string transferId,  string reversalId, StripeTransferReversalUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeTransferReversal>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}"),
                    SetupRequestOptions(requestOptions)
                )
            );         
        }

        public virtual IEnumerable<StripeTransferReversal> List(string transferId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeTransferReversal>.MapCollectionFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, $"{Urls.BaseUrl}/transfers/{transferId}/reversals", true),
                    SetupRequestOptions(requestOptions)
                )
            );
        }



        // Async
        public virtual async Task<StripeTransferReversal> CreateAsync(string transferId, StripeTransferReversalCreateOptions createOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeTransferReversal>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, $"{Urls.BaseUrl}/transfers/{transferId}/reversals"),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }

        public virtual async Task<StripeTransferReversal> GetAsync(string transferId, string reversalId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeTransferReversal>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}"),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }

        public virtual async Task<StripeTransferReversal> UpdateAsync(string transferId,  string reversalId, StripeTransferReversalUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeTransferReversal>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{Urls.BaseUrl}/transfers/{transferId}/reversals/{reversalId}"),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );         
        }

        public virtual async Task<IEnumerable<StripeTransferReversal>> ListAsync(string transferId, StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeTransferReversal>.MapCollectionFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, $"{Urls.BaseUrl}/transfers/{transferId}/reversals", true),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }
    }
}
