using System.Reflection;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_a_file_upload
    {
        private static StripeFileUploadService _fileService;
        private static StripeFileUpload _initialFileUpload;
        private static StripeFileUpload _retrievedFileUpload;

        Establish context = () =>
        {
            _fileService = new StripeFileUploadService();

            var fileStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Stripe.Tests.fileuploads.test_data.logo.png");
            _initialFileUpload = _fileService.Create("logo.png", fileStream, StripeFilePurpose.BusinessLogo);
        };

        Because of = () =>
            _retrievedFileUpload = _fileService.Get(_initialFileUpload.Id);
        
        It should_not_be_null = () =>
            _retrievedFileUpload.ShouldNotBeNull();

        It should_have_the_correct_id = () =>
            _retrievedFileUpload.Id.ShouldEqual(_initialFileUpload.Id);

        It should_have_the_correct_purpose = () =>
            _retrievedFileUpload.Purpose.ShouldEqual(_initialFileUpload.Purpose);

        It should_have_the_correct_type = () =>
            _retrievedFileUpload.Type.ShouldEqual(_initialFileUpload.Type);
    }
}
