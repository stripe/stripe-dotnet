require 'albacore'

VERSION = "1.1.6"

task :default => [:build, :merge, :output, :package, :nuget]

assemblyinfo :assemblyinfo do |asm|
	asm.version = VERSION
	asm.company_name = "Jayme Davis"
	asm.product_name = "Stripe.net"
	asm.title = "Stripe.net"
	asm.description = "A .net client api for http://stripe.com"
	asm.copyright = "Copyright (C) Jayme Davis 2012"
	asm.output_file = "src/SharedAssemblyInfo.cs"
end

desc "Build"
msbuild :build => :assemblyinfo do |msb|
	msb.properties :configuration => :Release
	msb.targets :Clean, :Build
	msb.solution = "src/Stripe.sln"
	puts 'Solution built'
end

desc "Merge"
exec :merge do |cmd|
	cmd.command = 'tools\ilmerge\ilmerge.exe'
	cmd.parameters ='/out:src\Stripe\bin\release\Stripe.net.dll /targetplatform:v4,"C:\Windows\Microsoft.NET\Framework\v4.0.30319" src\Stripe\bin\release\Stripe.dll src\Stripe\bin\release\Newtonsoft.Json.dll /closed /internalize'
	puts 'Merging complete'
end

desc "Output"
output :output do |out|
	out.from '.'
	out.to 'working'
	out.file 'src\Stripe\bin\release\Stripe.net.dll', :as=>'Stripe.net.dll'
	puts 'Output folder created'
end

desc "Package"
zip :package do |zip|
	zip.directories_to_zip "working"
	zip.output_file = "Stripe.net #{VERSION}.zip"
	zip.output_path = File.join(File.dirname(__FILE__), 'build')
	puts 'Packing complete'
end

desc 'NuGet'
exec :nuget do |cmd|	
	cmd.command = "tools\nuget\nuget.exe" 
	cmd.parameters = "pack Stripe.net.nuspec -o build"
	puts "NuGet packing complete"
end