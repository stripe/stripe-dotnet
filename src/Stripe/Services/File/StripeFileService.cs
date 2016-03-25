using System.IO;

namespace Stripe
{
    public class StripeFileService : StripeService
    {
        public StripeFileService(string apiKey = null) : base(apiKey)
        {
        }

        public StripeFileUpload UploadDisputeEvidence(string fileName, Stream stream, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);
            
            var response = Requestor.PostMultiPartFile(Urls.Files, fileName, stream, "dispute_evidence", requestOptions);
            
            return Mapper<StripeFileUpload>.MapFromJson(response);
        }

    }
}