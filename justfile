set quiet

_default:
    just --list

test no_build="" config="Debug":
    dotnet test {{no_build}} -f net8.0 src/StripeTests/StripeTests.csproj -c {{config}}

# skip build and test in release mode
ci-test: (test "--no-build" "Release")
# skip build and test in debug mode
ci-test-debug: (test "--no-build")

format:
    TargetFramework=net5.0 dotnet format src/Stripe.net/Stripe.net.csproj --severity warn

update-version:
    echo "$(VERSION)" > VERSION
    perl -pi -e 's|<Version>[.\-\d\w]+</Version>|<Version>$(VERSION)</Version>|' src/Stripe.net/Stripe.net.csproj
    perl -pi -e 's|Current = "[.\-\d\w]+";|Current = "$(VERSION)";|' src/Stripe.net/Constants/Version.cs

_self_validate:
    #!/usr/bin/env python
    just print("{{justfile()}}")
    # could also do this in JQ?
    # just --dump --dump-format json | jq '.recipes | keys'
