require 'albacore'

VERSION = "3.0.2"

task :default => [:build35, :build40, :output35, :output40]

assemblyinfo :assemblyinfo do |asm|
    asm.version = VERSION
    asm.company_name = "Jayme Davis"
    asm.product_name = "Stripe.net"
    asm.title = "Stripe.net"
    asm.description = "A .net client api for http://stripe.com"
    asm.copyright = "Copyright (C) Jayme Davis 2015"
    asm.output_file = "src/SharedAssemblyInfo.cs"
end

desc "Build 3.5"
msbuild :build35 => :assemblyinfo do |msb|
    msb.properties :configuration => :Release35
    msb.targets :Build
    msb.solution = "src/Stripe.sln"
    puts 'Solution 3.5 built'
end

desc "Build 4.0"
msbuild :build40 => :assemblyinfo do |msb|
    msb.properties :configuration => :Release
    msb.targets :Build
    msb.solution = "src/Stripe.sln"
    puts 'Solution 4.0 built'
end

desc "Output 3.5"
output :output35 do |out|
    out.from '.'
    out.to 'working35'
    out.file 'src\Stripe\bin\release 3.5\Stripe.net.dll', :as=>'Stripe.net.dll'
    puts 'Output 3.5 folder created'
end

desc "Output 4.0"
output :output40 do |out|
    out.from '.'
    out.to 'working40'
    out.file 'src\Stripe\bin\release\Stripe.net.dll', :as=>'Stripe.net.dll'
    puts 'Output 4.0 folder created'
end