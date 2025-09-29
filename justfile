set quiet

import? '../sdk-codegen/utils.just'

_default:
    just --list --unsorted

# base test command that other, more specific commands use
[no-quiet]
[no-exit-message]
_test no_build framework config filter="":
    dotnet test {{no_build}} {{framework}} src/StripeTests/StripeTests.csproj -c {{config}} {{ if filter == "" {""} else {"--filter " + filter} }}

# ⭐ run tests in debug mode
test: (_test "" "-f net8.0" "Debug")

# run a test matching a filter
test-one name: (_test "" "-f net8.0" "Debug" name)

# skip build and don't specify the dotnet framework
ci-test: (_test "--no-build" "" "Release")

# ⭐ format all files
format *args:
    dotnet format whitespace --folder {{args}}
    # This sets TargetFramework because of a race condition in dotnet format when it tries to format to multiple targets at a time, which could lead to code with compiler errors after it completes
    dotnet format whitespace --folder {{args}}
    TargetFramework=net5.0 dotnet format src/Stripe.net.sln --severity warn {{args}}

# verify, but don't modify, the project's formatting
format-check: (format "--verify-no-changes")

# called by tooling
[private]
update-version version:
    echo "{{ version }}" > VERSION
    perl -pi -e 's|<Version>[.\-\d\w]+</Version>|<Version>{{ version }}</Version>|' src/Stripe.net/Stripe.net.csproj
    perl -pi -e 's|Current = "[.\-\d\w]+";|Current = "{{ version }}";|' src/Stripe.net/Constants/Version.cs

[working-directory("src/Examples/")]
run-example example:
    dotnet run --project Examples.csproj {{ example }}
