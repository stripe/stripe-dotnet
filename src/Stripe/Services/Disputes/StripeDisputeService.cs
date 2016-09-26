using System;
using System.Threading;
using System.Threading.Tasks;

﻿namespace Stripe
{
    public class StripeDisputeService : StripeService
    {
        public StripeDisputeService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCharge { get; set; }
        #region Remove in 7.0
        [Obsolete("Balance transactions are now a list on StripeDispute")]
        public bool ExpandBalanceTransaction { get; set; }
        #endregion

        //Sync
        public virtual StripeDispute Get(string disputeId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeDispute>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.Disputes}/{disputeId}"),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        #region Remove in 7.0
        [Obsolete("This method will be replaced without requiring the charge id")]
        public virtual StripeDispute Update(string chargeId, string evidence = null, StripeRequestOptions requestOptions = null)
        {
            var url = this.ApplyAllParameters(null, $"{chargeId}/dispute", false);

            if (!string.IsNullOrEmpty(evidence))
                url = ParameterBuilder.ApplyParameterToUrl(url, "evidence", evidence);

            return Mapper<StripeDispute>.MapFromJson(
                Requestor.PostString(url,
                SetupRequestOptions(requestOptions))
            );
        }
        #endregion


        public virtual StripeDispute Close(string disputeId, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeDispute>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(null, $"{Urls.Disputes}/{disputeId}/close"),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        //public virtual IEnumerable<StripeFileUpload> List(StripeFileUploadListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        //{
        //    return Mapper<StripeFileUpload>.MapCollectionFromJson(
        //        Requestor.GetString(
        //            this.ApplyAllParameters(listOptions, Urls.Disputes, true),
        //            SetupRequestOptions(requestOptions)
        //        )
        //    );
        //}



        //Async
        public virtual async Task<StripeDispute> GetAsync(string disputeId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeDispute>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Disputes}/{disputeId}"),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }

        #region Remove in 7.0
        [Obsolete("This method will be replaced without requiring the charge id")]
        public virtual async Task<StripeDispute> UpdateAsync(string chargeId, string evidence = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.ApplyAllParameters(null, $"{chargeId}/dispute", false);

            if (!string.IsNullOrEmpty(evidence))
                url = ParameterBuilder.ApplyParameterToUrl(url, "evidence", evidence);

            return Mapper<StripeDispute>.MapFromJson(
                await Requestor.PostStringAsync(url,
                SetupRequestOptions(requestOptions),
                cancellationToken)
            );
        }
        #endregion

        public virtual async Task<StripeDispute> CloseAsync(string disputeId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeDispute>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.Disputes}/{disputeId}/close"),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }

        //public virtual async Task<IEnumerable<StripeFileUpload>> ListAsync(StripeFileUploadListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return Mapper<StripeFileUpload>.MapCollectionFromJson(
        //        await Requestor.GetStringAsync(
        //            this.ApplyAllParameters(listOptions, Urls.Disputes, true),
        //            SetupRequestOptions(requestOptions),
        //            cancellationToken
        //        )
        //    );
        //}
    }
}
