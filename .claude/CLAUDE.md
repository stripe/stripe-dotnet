# stripe-dotnet

## Testing

- Run all tests: `just test` (auto-installs correct .NET version)
- Run a specific test: `just test-one TestClassName` or `just test-one FullyQualifiedName`

## Formatting

- Format: `just format`
- Format check: `just format-check`
- Uses `dotnet format` (whitespace + analyzers)

## Key Locations

- HTTP client interface: `src/Stripe.net/Infrastructure/Public/IHttpClient.cs`
- HTTP implementation: `src/Stripe.net/Infrastructure/Public/SystemNetHttpClient.cs`
- Main client class: `src/Stripe.net/Infrastructure/Public/StripeClient.cs`
- Client options: `src/Stripe.net/Infrastructure/Public/StripeClientOptions.cs`
- Request building: `src/Stripe.net/Infrastructure/Public/StripeRequest.cs`
- API requestor: `src/Stripe.net/Infrastructure/Public/LiveApiRequestor.cs`
- Version: `src/Stripe.net/Constants/Version.cs`
- Tests: `src/StripeTests/`

## Generated Code

- Files containing `File generated from our OpenAPI spec` at the top are generated; do not edit. Similarly, any code block starting with `The beginning of the section generated from our OpenAPI spec` is generated and should not be edited directly.
  - If something in a generated file/range needs to be updated, add a summary of the change to your report but don't attempt to edit it directly.
- The `Infrastructure/` directory is NOT generated.

## Conventions

- Uses .NET `System.Net.Http.HttpClient`
- Multi-target framework (net461+, net6.0+, etc.)
- Solution file: `src/Stripe.net.sln`
- .NET version managed via mise
- All code must run on all supported .NET versions (full list in the test section of @.github/workflows/ci.yml)
- Work is not complete until `just test`, `just format` complete successfully.

### Comments

- Comments MUST only be used to:
  1. Document a function
  2. Explain the WHY of a piece of code
  3. Explain a particularly complicated piece of code
- Comments NEVER should be used to:
  1. Say what used to be there. That's no longer relevant!
  2. Explain the WHAT of a piece of code (unless it's very non-obvious)

It's ok not to put comments on/in a function if their addition wouldn't meaningfully clarify anything.
