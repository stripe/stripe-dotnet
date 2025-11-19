set quiet

import? '../sdk-codegen/utils.just'

_default:
    just --list --unsorted

# _supported_dotnet_versions is built from the <TargetFrameworks>...</TargetFrameworks> in the Stripe.net.csproj
_supported_dotnet_versions := `
  sed -n 's/.*<TargetFrameworks>\(.*\)<\/TargetFrameworks>.*/\1/p' src/Stripe.net/Stripe.net.csproj \
    | tr ';' '\n' \
    | sed -n 's/^net\([1-9]\{0,1\}[0-9]\.[^;]*\)$/\1/p' \
    | sed '/^$/d'
`
print_supported_dotnet_versions:
  echo "{{_supported_dotnet_versions}}"

print_latest_supported_dotnet_version:
  echo "{{_supported_dotnet_versions}}" | sort -h | tail -n 1

_mise_install_dotnet:
  #!/usr/bin/env bash
  if [[ $(mise ls --current | grep -q "dotnet") == "" ]];
  then
    echo "Installing dotnet via mise..."
    mise install dotnet
  fi

  export DOTNET_ROOT="$(mise where dotnet)"

_dotnet_install tpv:
  ./scripts/dotnet-install.sh --channel {{ tpv }} --install-dir "$(mise where dotnet)"

_ensure_latest_dotnet:
  #!/usr/bin/env bash
  dotnet_version=`just print_latest_supported_dotnet_version`
  just _dotnet_install $dotnet_version

# Install dotnet via mise and ensure the latest sdk version is installed
install: _mise_install_dotnet _ensure_latest_dotnet
    dotnet restore src/Stripe.net.sln

# base test command that other, more specific commands use
[no-quiet]
[no-exit-message]
_test no_build framework config filter="":
    dotnet test {{no_build}} {{framework}} src/StripeTests/StripeTests.csproj -c {{config}} {{ if filter == "" {""} else {"--filter " + filter} }}

# ⭐ run tests in debug mode
# Note that running on a specified dotnet version requires having that version installed
test: _ensure_latest_dotnet
  #!/usr/bin/env bash
  dotnet_version=`just print_latest_supported_dotnet_version`
  just _test "" "-f net$dotnet_version" "Debug"

# run a test matching a filter
# Note that running on a specified dotnet version requires having that version installed
test-one name: _ensure_latest_dotnet
  #!/usr/bin/env bash
  dotnet_version=`just print_latest_supported_dotnet_version`
  just _test "" "-f net$dotnet_version" "Debug" "{{name}}"

# skip build and don't specify the dotnet framework
ci-test: (_test "--no-build" "" "Release")

# ⭐ format all files
format *args:
    dotnet format whitespace --folder {{args}}
    # This sets TargetFramework because of a race condition in dotnet format when it tries to format to multiple targets at a time,
    # which could lead to code with compiler errors after it completes
    # NOTE: this will work on any dotnet version 5.0 or above
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
