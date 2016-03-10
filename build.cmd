.\build\nuget restore .\src\Stripe.sln

call %WINDIR%\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe .\src\Stripe.sln /p:Configuration=Release
copy .\src\Stripe\bin\Release\Stripe.net.dll .\build\net45\Stripe.net.dll /Y
copy .\src\Stripe.Portable\bin\Release\Stripe.net.Portable.dll .\build\portable\Stripe.net.dll /Y

cd build
nuget pack Stripe.net.nuspec
