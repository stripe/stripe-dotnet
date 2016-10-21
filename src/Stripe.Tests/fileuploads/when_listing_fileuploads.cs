using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_fileuploads
    {
        private static StripeFileUploadService _fileService;
        private static List<StripeFileUpload> _fileUploads;

        Establish context = () =>
        {
            _fileService = new StripeFileUploadService();

            var fileStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Stripe.Tests.fileuploads.test_data.logo.png");
            _fileService.Create("logo.png", fileStream, StripeFilePurpose.BusinessLogo);
            var fileStream2 = Assembly.GetExecutingAssembly().GetManifestResourceStream("Stripe.Tests.fileuploads.test_data.logo.png");
            _fileService.Create("logo.png", fileStream2, StripeFilePurpose.BusinessLogo);
            var fileStream3 = Assembly.GetExecutingAssembly().GetManifestResourceStream("Stripe.Tests.fileuploads.test_data.logo.png");
            _fileService.Create("logo.png", fileStream3, StripeFilePurpose.BusinessLogo);
        };

        Because of = () =>
            _fileUploads = _fileService.List().ToList();

        It should_have_atleast_3_entries = () =>
            _fileUploads.Count.ShouldBeGreaterThanOrEqualTo(3);
    }
}