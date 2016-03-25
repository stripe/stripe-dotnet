using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_uploading_a_file
    {
        protected static StripeFileUpload StripeFile;

        private static StripeFileService _stipeFileService;

        Establish context = () =>
        {
            _stipeFileService = new StripeFileService();
        };

        //TODO:
        //Because of = () =>
        //    StripeFile = _stipeFileService.UploadDisputeEvidence(...);

    }
}