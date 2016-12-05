$shouldPublish = $null

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
	$test_result = (dotnet test src\Stripe.net.Tests | Out-String) -split "\n"

	foreach($line in $test_result) {
		if (${line} -Match "Failures:") { $shouldPublish = $false }
	}

	if ($shouldPublish -eq $null) { $shouldPublish = $true }

	blankLines
	Write-Host $("Should we package? $shouldPublish") -ForegroundColor Cyan
	blankLines
}

function Invoke-Pack
{
	if ($shouldPublish -ne $true) { $host.SetShouldExit($LastExitCode) }

	dotnet pack -c Release src\Stripe.net

	Get-ChildItem Stripe*.nupkg -Recurse | % { Push-AppveyorArtifact $_.FullName -Filename $_.FullName }
}

function blankLines()
{
	Write-Host " "
	Write-Host " "
}

#function Invoke-NuGetCheck
#{
#	Write-Host " "
#	Write-Host "Starting NuGet check..."

#	$headers = @{
#	  "Authorization" = "Bearer $env:token"
#	  "Content-type" = "application/json"
#	}
 
#	$url = "https://ci.appveyor.com/api/projects/$env:APPVEYOR_ACCOUNT_NAME/$env:APPVEYOR_PROJECT_SLUG/history?recordsNumber=2"
 
#	$history = Invoke-RestMethod -Uri $url -Headers $headers  -Method Get
 
#	if ($history.builds.Length -lt 2) {throw "history is not long enough"}
 
#	write-host "previous version:"
#	$history.builds[1].version
#	write-host "current version:"
#	$env:APPVEYOR_BUILD_VERSION
 
#	$previousVersionSplit = $history.builds[1].version.Split(".")
#	if ($previousVersionSplit.Length -lt 3) {throw "previous build version has no enough parts"}
 
#	$currentVersionSplit = $env:APPVEYOR_BUILD_VERSION.Split(".")
#	if ($currentVersionSplit.Length -lt 3) {throw "current build version has no enough parts"}
 
#	$pushNuget = $false
#	for ($i = 0; $i -lt 3; $i++) {if ($previousVersionSplit[$i] -ne $currentVersionSplit[$i]) {write-host "at least one part changed, will push nuget"; $pushNuget = $true; break}}
 	
#	nuget pack $env:APPVEYOR_BUILD_FOLDER\build\Stripe.net.nuspec

#	if(!$pushNuget) {
#	write-host "all parts are the same, will not push Nuget"
#	# do "nuget pack" here
#	# do "appveyor PushArtifact <your-nugetpackage.nupkg>" accordig to https://www.appveyor.com/docs/nuget/
#	}

#	Write-Host " "
#}