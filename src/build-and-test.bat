cd Stripe.net
dotnet restore
dotnet build
dotnet pack

cd ..\Stripe.net.Tests
dotnet test

cd ..\Stripe.Tests.xUnit
dotnet test

cd ..
