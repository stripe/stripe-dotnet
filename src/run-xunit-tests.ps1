cd Stripe.net
dotnet restore
dotnet build
dotnet test
dotnet pack
cd ..\Stripe.net.Tests.xUnit
dotnet test
cd ..