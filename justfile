set quiet

import? '../sdk-codegen/justfile'

_default:
    just --list

test no_build="" config="Debug":
    dotnet test {{no_build}} -f net8.0 src/StripeTests/StripeTests.csproj -c {{config}}

# skip build and test in release mode
test-release: (test "--no-build" "Release")
alias ci-test := test-release

# format files as needed
format check_only="":
    TargetFramework=net5.0 dotnet format src/Stripe.net/Stripe.net.csproj --severity warn {{check_only}}

# for backwards compatibility; ideally removed later
[private]
alias codegen-format := format

# verify, but don't modify, the project's formatting
format-check: (format "--verify-no-changes")

update-version:
    echo "$(VERSION)" > VERSION
    perl -pi -e 's|<Version>[.\-\d\w]+</Version>|<Version>$(VERSION)</Version>|' src/Stripe.net/Stripe.net.csproj
    perl -pi -e 's|Current = "[.\-\d\w]+";|Current = "$(VERSION)";|' src/Stripe.net/Constants/Version.cs
