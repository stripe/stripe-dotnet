dotnet pack -c Release src\Stripe.net

copy .\src\Stripe.net\bin\Release\Stripe.net.*.nupkg .\build\

pause
