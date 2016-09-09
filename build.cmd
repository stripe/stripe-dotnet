copy .\src\Stripe\bin\Release\Stripe.net.dll .\build\net45\Stripe.net.dll /Y
copy .\src\Stripe\bin\Release\Stripe.net.xml .\build\net45\Stripe.net.xml /Y
copy .\src\Stripe.Portable\bin\Release\Stripe.net.dll .\build\portable\Stripe.net.dll /Y
copy .\src\Stripe.Portable\bin\Release\Stripe.net.xml .\build\portable\Stripe.net.xml /Y

cd build
del *.nupkg
nuget pack Stripe.net.nuspec

pause