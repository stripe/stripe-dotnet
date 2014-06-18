require 'albacore'

VERSION = "2.2.4"

task :default => [:build, :output]

assemblyinfo :assemblyinfo do |asm|
	asm.version = VERSION
	asm.company_name = "Jayme Davis"
	asm.product_name = "Stripe.net"
	asm.title = "Stripe.net"
	asm.description = "A .net client api for http://stripe.com"
	asm.copyright = "Copyright (C) Jayme Davis 2014"
	asm.output_file = "src/SharedAssemblyInfo.cs"
end

desc "Build"
msbuild :build => :assemblyinfo do |msb|
	msb.properties :configuration => :Release
	msb.targets :Clean, :Build
	msb.solution = "src/Stripe.sln"
	puts 'Solution built'
end

desc "Output"
output :output do |out|
	out.from '.'
	out.to 'working'
	out.file 'src\Stripe\bin\release\Stripe.net.dll', :as=>'Stripe.net.dll'
	puts 'Output folder created'
end