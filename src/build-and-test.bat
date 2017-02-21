cd Stripe.net
dotnet restore
dotnet build
dotnet pack

cd ..\Stripe.net.Tests
dotnet test

cd ..\Stripe.Tests.Xunit
dotnet test

cd ..
