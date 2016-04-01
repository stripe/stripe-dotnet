.\build\nuget restore .\src\Stripe.sln

copy .\src\Stripe\bin\Release\Stripe.net.dll .\build\net45\Stripe.net.dll /Y
copy .\src\Stripe\bin\Release\Stripe.net.dll .\build\net45\Stripe.net.pdb /Y
copy .\src\Stripe.Portable\bin\Release\Stripe.net.dll .\build\portable\Stripe.net.dll /Y
copy .\src\Stripe.Portable\bin\Release\Stripe.net.pdb .\build\portable\Stripe.net.pdb /Y

cd build
nuget pack Stripe.net.nuspec

pause