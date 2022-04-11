.PHONY: update-version
update-version:
	@echo "$(VERSION)" > VERSION
	@perl -pi -e 's/version: [.\d]+.{build}/version: $(VERSION).{build}/' appveyor.yml
	@perl -pi -e 's|<VersionPrefix\>[.\d]+</VersionPrefix>|<VersionPrefix>$(VERSION)</VersionPrefix>|' src/Stripe.net/Stripe.net.csproj
	@perl -pi -e 's|<Version>[.\d]+</Version>|<Version>$(VERSION)</Version>|' src/Stripe.net/Stripe.net.csproj
