.PHONY: update-version codegen-format
update-version:
	@echo "$(VERSION)" > VERSION
	@perl -pi -e 's|<Version>[.\d]+</Version>|<Version>$(VERSION)</Version>|' src/Stripe.net/Stripe.net.csproj

codegen-format:
	dotnet format whitespace src/Stripe.net/
