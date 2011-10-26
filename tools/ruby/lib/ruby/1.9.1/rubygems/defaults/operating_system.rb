# :DK-BEG: missing DevKit/build tool convenience notice
Gem.pre_install do |gem_installer|
  unless gem_installer.spec.extensions.empty?
    have_tools = %w{gcc make sh}.all? do |t|
      system("#{t} --version > NUL 2>&1")
    end

    unless have_tools
      raise Gem::InstallError,<<-EOT
The '#{gem_installer.spec.name}' native gem requires installed build tools.

Please update your PATH to include build tools or download the DevKit
from 'http://rubyinstaller.org/downloads' and follow the instructions
at 'http://github.com/oneclick/rubyinstaller/wiki/Development-Kit'
EOT
    end
  end
end
# :DK-END:
