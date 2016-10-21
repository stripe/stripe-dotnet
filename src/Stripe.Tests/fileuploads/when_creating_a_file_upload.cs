using System.IO;
using System.Reflection;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_file_upload
    {
        private static StripeFileUploadService _fileService;
        private static StripeFileUpload _fileUpload;
        private static Stream _fileStream;

        Establish context = () =>
        {
            _fileService = new StripeFileUploadService();

            _fileStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Stripe.Tests.fileuploads.test_data.logo.png");
        };

        Because of = () =>
            _fileUpload = _fileService.Create("logo.png", _fileStream, StripeFilePurpose.BusinessLogo);

        It should_not_be_null = () =>
            _fileUpload.ShouldNotBeNull();

        It should_have_the_correct_id = () =>
            _fileUpload.Id.ShouldStartWith("file_");

        It should_have_the_correct_purpose = () =>
            _fileUpload.Purpose.ShouldEqual(StripeFilePurpose.BusinessLogo);

        It should_have_the_correct_type = () =>
            _fileUpload.Type.ShouldEqual("png");

        It should_have_the_correct_url = () =>
            _fileUpload.Url.ShouldContain("stripe-images");
    }
}
