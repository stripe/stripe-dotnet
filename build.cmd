rd .\working40 /S /Q
md .\working40

call %WINDIR%\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe src/Stripe.sln /p:Configuration=Release
copy .\src\Stripe\bin\Release\Stripe.net.dll .\working40\