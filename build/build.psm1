function Invoke-Restore()
{	
	blankLines
	Write-Host $("RESTORING EVERYTHING...") -BackgroundColor DarkCyan
	blankLines
	
	dotnet restore
}

function Invoke-Build
{
	blankLines
	Write-Host $("BUILDING STRIPE.NET...") -BackgroundColor DarkCyan
	blankLines

	dotnet build -c Debug src\Stripe.net
	dotnet build -c Release src\Stripe.net

	blankLines
	Write-Host $("BUILDING THE TESTS...") -BackgroundColor DarkCyan
	blankLines

	dotnet build src\Stripe.net.Tests
	dotnet build src\Stripe.Tests.Xunit
}

function Invoke-Test
{
	blankLines
	Write-Host $("RUNNING THE XUNIT TESTS...") -BackgroundColor DarkCyan
	blankLines

	dotnet test src\Stripe.Tests.Xunit

	blankLines
	Write-Host $("RUNNING THE MSPEC TESTS...") -BackgroundColor DarkCyan
	blankLines

	dotnet test src\Stripe.net.Tests
}

function Invoke-Pack
{
	blankLines
	Write-Host $("PACKING UP...") -BackgroundColor DarkCyan
	blankLines

	dotnet pack -c Release src\Stripe.net

	Get-ChildItem Stripe*.nupkg -Recurse | % { Push-AppveyorArtifact $_.FullName -Filename $_.FullName }
}

function blankLines()
{
	Write-Host " "
	Write-Host " "
}
