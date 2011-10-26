# -*- encoding: utf-8 -*-

Gem::Specification.new do |s|
  s.name = %q{albacore}
  s.version = "0.2.7"

  s.required_rubygems_version = Gem::Requirement.new(">= 0") if s.respond_to? :required_rubygems_version=
  s.authors = ["Derick Bailey", "etc"]
  s.date = %q{2011-07-10}
  s.description = %q{Easily build your .NET solutions with Ruby and Rake, using this suite of Rake tasks.}
  s.email = %q{albacorebuild@gmail.com}
  s.extra_rdoc_files = ["README.markdown"]
  s.files = [".autotest", ".bundle/config", ".rvmrc", "Gemfile", "README.markdown", "VERSION", "lib/albacore.rb", "lib/albacore/albacoretask.rb", "lib/albacore/aspnetcompiler.rb", "lib/albacore/assemblyinfo.rb", "lib/albacore/assemblyinfolanguages/cppcliengine.rb", "lib/albacore/assemblyinfolanguages/csharpengine.rb", "lib/albacore/assemblyinfolanguages/vbnetengine.rb", "lib/albacore/config/aspnetcompilerconfig.rb", "lib/albacore/config/assemblyinfoconfig.rb", "lib/albacore/config/config.rb", "lib/albacore/config/cscconfig.rb", "lib/albacore/config/docuconfig.rb", "lib/albacore/config/execconfig.rb", "lib/albacore/config/fluentmigratorrunnerconfig.rb", "lib/albacore/config/msbuildconfig.rb", "lib/albacore/config/mspectestrunnerconfig.rb", "lib/albacore/config/mstesttestrunnerconfig.rb", "lib/albacore/config/nantconfig.rb", "lib/albacore/config/nchurnconfig.rb", "lib/albacore/config/ncoverconsoleconfig.rb", "lib/albacore/config/ncoverreportconfig.rb", "lib/albacore/config/ndependconfig.rb", "lib/albacore/config/netversion.rb", "lib/albacore/config/nugetpackconfig.rb", "lib/albacore/config/nugetpublishconfig.rb", "lib/albacore/config/nugetpushconfig.rb", "lib/albacore/config/nunittestrunnerconfig.rb", "lib/albacore/config/specflowreportconfig.rb", "lib/albacore/config/sqlcmdconfig.rb", "lib/albacore/config/unzipconfig.rb", "lib/albacore/config/vssgetconfig.rb", "lib/albacore/config/xbuildconfig.rb", "lib/albacore/config/xunittestrunnerconfig.rb", "lib/albacore/config/zipdirectoryconfig.rb", "lib/albacore/csc.rb", "lib/albacore/docu.rb", "lib/albacore/exec.rb", "lib/albacore/fluentmigratorrunner.rb", "lib/albacore/msbuild.rb", "lib/albacore/mspectestrunner.rb", "lib/albacore/mstesttestrunner.rb", "lib/albacore/nant.rb", "lib/albacore/nchurn.rb", "lib/albacore/ncoverconsole.rb", "lib/albacore/ncoverreport.rb", "lib/albacore/ncoverreports/assemblyfilter.rb", "lib/albacore/ncoverreports/branchcoverage.rb", "lib/albacore/ncoverreports/classfilter.rb", "lib/albacore/ncoverreports/codecoveragebase.rb", "lib/albacore/ncoverreports/cyclomaticcomplexity.rb", "lib/albacore/ncoverreports/documentfilter.rb", "lib/albacore/ncoverreports/fullcoveragereport.rb", "lib/albacore/ncoverreports/methodcoverage.rb", "lib/albacore/ncoverreports/methodfilter.rb", "lib/albacore/ncoverreports/namespacefilter.rb", "lib/albacore/ncoverreports/reportfilterbase.rb", "lib/albacore/ncoverreports/summaryreport.rb", "lib/albacore/ncoverreports/symbolcoverage.rb", "lib/albacore/ndepend.rb", "lib/albacore/nugetpack.rb", "lib/albacore/nugetpublish.rb", "lib/albacore/nugetpush.rb", "lib/albacore/nunittestrunner.rb", "lib/albacore/nuspec.rb", "lib/albacore/output.rb", "lib/albacore/plink.rb", "lib/albacore/specflowreport.rb", "lib/albacore/sqlcmd.rb", "lib/albacore/support/attrmethods.rb", "lib/albacore/support/createtask.rb", "lib/albacore/support/failure.rb", "lib/albacore/support/logging.rb", "lib/albacore/support/openstruct.rb", "lib/albacore/support/runcommand.rb", "lib/albacore/support/supportlinux.rb", "lib/albacore/support/updateattributes.rb", "lib/albacore/support/yamlconfig.rb", "lib/albacore/unzip.rb", "lib/albacore/vssget.rb", "lib/albacore/xbuild.rb", "lib/albacore/xunittestrunner.rb", "lib/albacore/zipdirectory.rb", "rakefile.rb", "watchrtesting.rb", "yaml_autoconfig_test.yml"]
  s.homepage = %q{http://albacorebuild.net}
  s.require_paths = ["lib"]
  s.rubygems_version = %q{1.3.7}
  s.summary = %q{Dolphin-Safe Rake Tasks For .NET Systems}

  if s.respond_to? :specification_version then
    current_version = Gem::Specification::CURRENT_SPECIFICATION_VERSION
    s.specification_version = 3

    if Gem::Version.new(Gem::VERSION) >= Gem::Version.new('1.2.0') then
      s.add_runtime_dependency(%q<rubyzip>, ["~> 0.9"])
      s.add_development_dependency(%q<nokogiri>, ["~> 1.4"])
      s.add_development_dependency(%q<version_bumper>, ["~> 0.3"])
      s.add_development_dependency(%q<jeweler>, ["~> 1.6"])
      s.add_development_dependency(%q<rspec>, ["~> 1.2"])
      s.add_development_dependency(%q<jekyll>, ["~> 0.8"])
      s.add_development_dependency(%q<watchr>, ["~> 0.7"])
    else
      s.add_dependency(%q<rubyzip>, ["~> 0.9"])
      s.add_dependency(%q<nokogiri>, ["~> 1.4"])
      s.add_dependency(%q<version_bumper>, ["~> 0.3"])
      s.add_dependency(%q<jeweler>, ["~> 1.6"])
      s.add_dependency(%q<rspec>, ["~> 1.2"])
      s.add_dependency(%q<jekyll>, ["~> 0.8"])
      s.add_dependency(%q<watchr>, ["~> 0.7"])
    end
  else
    s.add_dependency(%q<rubyzip>, ["~> 0.9"])
    s.add_dependency(%q<nokogiri>, ["~> 1.4"])
    s.add_dependency(%q<version_bumper>, ["~> 0.3"])
    s.add_dependency(%q<jeweler>, ["~> 1.6"])
    s.add_dependency(%q<rspec>, ["~> 1.2"])
    s.add_dependency(%q<jekyll>, ["~> 0.8"])
    s.add_dependency(%q<watchr>, ["~> 0.7"])
  end
end
