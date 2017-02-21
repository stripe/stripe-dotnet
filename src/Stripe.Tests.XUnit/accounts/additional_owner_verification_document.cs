using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.xUnit
{
    public class adding_additional_owner_verification_document : test
    {
        private StripeAccount Account { get; set; }

        public adding_additional_owner_verification_document()
        {
            // create a file
            var fileService = new StripeFileUploadService(_stripe_api_key);
            var fileStream = GetType().GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.Tests.XUnit._resources.bumble.jpg");
            var file = fileService.Create("bumble.jpg", fileStream, StripeFilePurpose.IdentityDocument);

            // create the new account
            var accountService = new StripeAccountService();

            Account = new StripeAccountService(_stripe_api_key).Create(
               new StripeAccountCreateOptions
               {
                   Email = $"bumble@some-email-somewhere.com",
                   Managed = true,
                   LegalEntity = new StripeAccountLegalEntityOptions
                   {
                       AdditionalOwners = new List<StripeAccountAdditionalOwner>
                       {
                            new StripeAccountAdditionalOwner
                            {
                                FirstName = "Bumble",
                                VerificationDocument = file.Id
                            },
                       }
                   }
               }
           );
        }

        [Fact]
        public void has_the_owner()
        {
            Account.LegalEntity.AdditionalOwners.Should().NotBeNull();
        }

        [Fact]
        public void has_the_verification_document()
        {
            Account.LegalEntity.AdditionalOwners.First().LegalEntityVerification.DocumentId.Should().NotBeNullOrEmpty();
        }
    }
}
