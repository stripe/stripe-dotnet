set quiet

import? '../sdk-codegen/justfile'

_default:
    just --list --unsorted

# base test command that other, more specific commands use
[no-quiet]
[no-exit-message]
_test no_build framework config:
    dotnet test {{no_build}} {{framework}} src/StripeTests/StripeTests.csproj -c {{config}}

# ⭐ run tests in debug mode
test: (_test "" "-f net8.0" "Debug")

# skip build and don't specify the dotnet framework
ci-test: (_test "--no-build" "" "Release")

# ⭐ format all files
format *args:
    # This sets TargetFramework because of a race condition in dotnet format when it tries to format to multiple targets at a time, which could lead to code with compiler errors after it completes
    TargetFramework=net5.0 dotnet format src/Stripe.net/Stripe.net.csproj --severity warn {{args}}

# for backwards compatibility; ideally removed later
[private]
alias codegen-format := format

# verify, but don't modify, the project's formatting
format-check: (format "--verify-no-changes")

# called by tooling
[private]
update-version version:
    echo "{{ version }}" > VERSION
    perl -pi -e 's|<Version>[.\-\d\w]+</Version>|<Version>{{ version }}</Version>|' src/Stripe.net/Stripe.net.csproj
    perl -pi -e 's|Current = "[.\-\d\w]+";|Current = "{{ version }}";|' src/Stripe.net/Constants/Version.cs
