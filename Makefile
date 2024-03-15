.PHONY: update-version codegen-format test ci-test
update-version:
	@echo "$(VERSION)" > VERSION
	@perl -pi -e 's|<Version>[.\-\d\w]+</Version>|<Version>$(VERSION)</Version>|' src/Stripe.net/Stripe.net.csproj

codegen-format:
	dotnet format src/Stripe.net/Stripe.net.csproj --severity warn

ci-test:
	dotnet test --no-build src/StripeTests/StripeTests.csproj -c Release

ci-test-debug:
	dotnet test --no-build src/StripeTests/StripeTests.csproj -c Debug

test:
	dotnet test -f net8.0 src/StripeTests/StripeTests.csproj -c Debug
