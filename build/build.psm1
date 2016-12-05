function Invoke-Restore()
{
	dotnet restore
}

function Invoke-Build
{
	dotnet build -c Debug src\Stripe.net
	dotnet build -c Release src\Stripe.net

	dotnet build src\Stripe.net.Tests
	dotnet build src\Stripe.net.Tests.xUnit
}

function Invoke-Test
{
	dotnet test src\Stripe.net.Tests.xUnit
	dotnet test src\Stripe.net.Tests
}

function Invoke-Pack
{
	dotnet pack -c Release src\Stripe.net

	Get-ChildItem Stripe*.nupkg -Recurse | % { Push-AppveyorArtifact $_.FullName -Filename $_.FullName }
}
