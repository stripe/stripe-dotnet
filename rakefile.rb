require 'albacore'

VERSION = "1.6.2"

task :default => [:build, :output, :package]

assemblyinfo :assemblyinfo do |asm|
	asm.version = VERSION
	asm.company_name = "Jayme Davis"
	asm.product_name = "Stripe.net"
	asm.title = "Stripe.net"
	asm.description = "A .net client api for http://stripe.com"
	asm.copyright = "Copyright (C) Jayme Davis 2013"
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

desc "Package"
zip :package do |zip|
	zip.directories_to_zip "working"
	zip.output_file = "Stripe.net #{VERSION}.zip"
	zip.output_path = File.join(File.dirname(__FILE__), 'build')
	puts 'Packing complete'
end