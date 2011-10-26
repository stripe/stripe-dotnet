
# This file was created by mkconfig.rb when ruby was built.  Any
# changes made to this file will be lost the next time ruby is built.

module RbConfig
  RUBY_VERSION == "1.9.2" or
    raise "ruby lib version (1.9.2) doesn't match executable version (#{RUBY_VERSION})"

  TOPDIR = File.dirname(__FILE__).chomp!("/lib/ruby/1.9.1/i386-mingw32")
  DESTDIR = TOPDIR && TOPDIR[/\A[a-z]:/i] || '' unless defined? DESTDIR
  CONFIG = {}
  CONFIG["DESTDIR"] = DESTDIR
  CONFIG["MAJOR"] = "1"
  CONFIG["MINOR"] = "9"
  CONFIG["TEENY"] = "1"
  CONFIG["PATCHLEVEL"] = "290"
  CONFIG["INSTALL"] = '/usr/bin/install -c'
  CONFIG["EXEEXT"] = ".exe"
  CONFIG["prefix"] = (TOPDIR || DESTDIR + "")
  CONFIG["ruby_install_name"] = "ruby"
  CONFIG["RUBY_INSTALL_NAME"] = "ruby"
  CONFIG["RUBY_SO_NAME"] = "msvcrt-ruby191"
  CONFIG["PACKAGE"] = "ruby"
  CONFIG["BUILTIN_TRANSSRCS"] = " newline.c"
  CONFIG["MANTYPE"] = "man"
  CONFIG["NROFF"] = "/bin/false"
  CONFIG["vendorhdrdir"] = "$(rubyhdrdir)/vendor_ruby"
  CONFIG["sitehdrdir"] = "$(rubyhdrdir)/site_ruby"
  CONFIG["rubyhdrdir"] = "$(includedir)/$(RUBY_BASE_NAME)-$(ruby_version)"
  CONFIG["UNIVERSAL_INTS"] = ""
  CONFIG["UNIVERSAL_ARCHNAMES"] = ""
  CONFIG["configure_args"] = " '--enable-shared' '--disable-install-doc' '--with-tcl-dir=C:/Users/Luis/Projects/oss/oneclick/rubyinstaller/sandbox/tcl' '--with-tk-dir=C:/Users/Luis/Projects/oss/oneclick/rubyinstaller/sandbox/tk' '--with-tklib=tk85-ri' '--with-tcllib=tcl85-ri' '--prefix=' 'LDFLAGS=-LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\tk\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\tcl\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\libyaml\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\pdcurses\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\openssl\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\zlib\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\iconv\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\gdbm\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\libffi\\\\lib '"
  CONFIG["vendordir"] = "$(rubylibprefix)/vendor_ruby"
  CONFIG["sitedir"] = "$(rubylibprefix)/site_ruby"
  CONFIG["ruby_version"] = "1.9.1"
  CONFIG["sitearch"] = "i386-msvcrt"
  CONFIG["arch"] = "i386-mingw32"
  CONFIG["RI_BASE_NAME"] = "ri"
  CONFIG["ridir"] = "$(datarootdir)/$(RI_BASE_NAME)"
  CONFIG["rubylibprefix"] = "$(libdir)/$(RUBY_BASE_NAME)"
  CONFIG["MAKEFILES"] = "Makefile GNUmakefile"
  CONFIG["THREAD_MODEL"] = "win32"
  CONFIG["EXPORT_PREFIX"] = " "
  CONFIG["COMMON_HEADERS"] = "winsock2.h windows.h"
  CONFIG["COMMON_MACROS"] = ""
  CONFIG["COMMON_LIBS"] = "m"
  CONFIG["MAINLIBS"] = ""
  CONFIG["ENABLE_SHARED"] = "yes"
  CONFIG["DLDLIBS"] = ""
  CONFIG["SOLIBS"] = "$(LIBS)"
  CONFIG["LIBRUBYARG_SHARED"] = "-l$(RUBY_SO_NAME)"
  CONFIG["LIBRUBYARG_STATIC"] = "-l$(RUBY_SO_NAME)-static"
  CONFIG["LIBRUBYARG"] = "$(LIBRUBYARG_SHARED)"
  CONFIG["LIBRUBY"] = "lib$(RUBY_SO_NAME).dll.a"
  CONFIG["LIBRUBY_ALIASES"] = ""
  CONFIG["LIBRUBY_SO"] = "$(RUBY_SO_NAME).dll"
  CONFIG["LIBRUBY_A"] = "lib$(RUBY_SO_NAME)-static.a"
  CONFIG["RUBYW_INSTALL_NAME"] = "$(RUBYW_BASE_NAME)"
  CONFIG["rubyw_install_name"] = "$(RUBYW_INSTALL_NAME)"
  CONFIG["LIBRUBY_DLDFLAGS"] = " -Wl,--enable-auto-image-base,--enable-auto-import -Wl,--out-implib=$(LIBRUBY) $(RUBYDEF)"
  CONFIG["LIBRUBY_LDSHARED"] = "$(CC) -shared $(if $(filter-out -g -g0,$(debugflags)),,-s)"
  CONFIG["warnflags"] = "-Wextra -Wno-unused-parameter -Wno-parentheses -Wpointer-arith -Wwrite-strings -Wno-missing-field-initializers -Wno-long-long"
  CONFIG["debugflags"] = "-g"
  CONFIG["optflags"] = "-O3"
  CONFIG["cxxflags"] = " $(optflags) $(debugflags) $(warnflags)"
  CONFIG["cflags"] = " $(optflags) $(debugflags) $(warnflags)"
  CONFIG["cppflags"] = ""
  CONFIG["INSTALLDOC"] = "nodoc"
  CONFIG["RDOCTARGET"] = "nodoc"
  CONFIG["EXECUTABLE_EXTS"] = ".exe .com .cmd .bat"
  CONFIG["ARCHFILE"] = ""
  CONFIG["EXTOUT"] = ".ext"
  CONFIG["PREP"] = "miniruby$(EXEEXT)"
  CONFIG["TEST_RUNNABLE"] = "yes"
  CONFIG["setup"] = "Setup"
  CONFIG["EXTSTATIC"] = ""
  CONFIG["STRIP"] = "strip"
  CONFIG["TRY_LINK"] = ""
  CONFIG["LIBPATHENV"] = ""
  CONFIG["RPATHFLAG"] = ""
  CONFIG["LIBPATHFLAG"] = " -L%s"
  CONFIG["LINK_SO"] = ""
  CONFIG["LIBEXT"] = "a"
  CONFIG["DLEXT2"] = ""
  CONFIG["DLEXT"] = "so"
  CONFIG["LDSHAREDXX"] = "$(CXX) -shared $(if $(filter-out -g -g0,$(debugflags)),,-s)"
  CONFIG["LDSHARED"] = "$(CC) -shared $(if $(filter-out -g -g0,$(debugflags)),,-s)"
  CONFIG["CCDLFLAGS"] = ""
  CONFIG["STATIC"] = ""
  CONFIG["ARCH_FLAG"] = ""
  CONFIG["DLDFLAGS"] = " -Wl,--enable-auto-image-base,--enable-auto-import $(DEFFILE)"
  CONFIG["ALLOCA"] = ""
  CONFIG["CHDIR"] = "cd"
  CONFIG["RMALL"] = "rm -fr"
  CONFIG["RMDIRS"] = "$(top_srcdir)/tool/rmdirs"
  CONFIG["CP"] = "cp"
  CONFIG["RM"] = "rm -f"
  CONFIG["CAPITARGET"] = "nodoc"
  CONFIG["DOXYGEN"] = ""
  CONFIG["DOT"] = ""
  CONFIG["MAKEDIRS"] = "/usr/bin/mkdir -p"
  CONFIG["MKDIR_P"] = "/usr/bin/mkdir -p"
  CONFIG["INSTALL_DATA"] = "$(INSTALL) -m 644"
  CONFIG["INSTALL_SCRIPT"] = "$(INSTALL)"
  CONFIG["INSTALL_PROGRAM"] = "$(INSTALL)"
  CONFIG["SET_MAKE"] = ""
  CONFIG["LN_S"] = "cp -p"
  CONFIG["DLLWRAP"] = "dllwrap"
  CONFIG["WINDRES"] = "windres"
  CONFIG["NM"] = "nm"
  CONFIG["OBJCOPY"] = ":"
  CONFIG["OBJDUMP"] = "objdump"
  CONFIG["ASFLAGS"] = ""
  CONFIG["AS"] = "as"
  CONFIG["AR"] = "ar"
  CONFIG["RANLIB"] = "ranlib"
  CONFIG["try_header"] = ""
  CONFIG["COUTFLAG"] = "-o "
  CONFIG["OUTFLAG"] = "-o "
  CONFIG["CPPOUTFILE"] = "-o conftest.i"
  CONFIG["GNU_LD"] = "yes"
  CONFIG["GCC"] = "yes"
  CONFIG["EGREP"] = "/usr/bin/grep -E"
  CONFIG["GREP"] = "/usr/bin/grep"
  CONFIG["CPP"] = "$(CC) -E"
  CONFIG["CXXFLAGS"] = "$(cxxflags)"
  CONFIG["CXX"] = "g++"
  CONFIG["OBJEXT"] = "o"
  CONFIG["CPPFLAGS"] = " $(DEFS) $(cppflags)"
  CONFIG["LDFLAGS"] = "-L. -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\tk\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\tcl\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\libyaml\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\pdcurses\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\openssl\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\zlib\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\iconv\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\gdbm\\\\lib -LC:\\\\Users\\\\Luis\\\\Projects\\\\oss\\\\oneclick\\\\rubyinstaller\\\\sandbox\\\\libffi\\\\lib "
  CONFIG["CFLAGS"] = "$(cflags)"
  CONFIG["CC"] = "gcc"
  CONFIG["target_os"] = "mingw32"
  CONFIG["target_vendor"] = "pc"
  CONFIG["target_cpu"] = "i386"
  CONFIG["target"] = "i386-pc-mingw32"
  CONFIG["host_os"] = "mingw32"
  CONFIG["host_vendor"] = "pc"
  CONFIG["host_cpu"] = "i686"
  CONFIG["host"] = "i686-pc-mingw32"
  CONFIG["build_os"] = "mingw32"
  CONFIG["build_vendor"] = "pc"
  CONFIG["build_cpu"] = "i686"
  CONFIG["build"] = "i686-pc-mingw32"
  CONFIG["RUBYW_BASE_NAME"] = "rubyw"
  CONFIG["RUBY_BASE_NAME"] = "ruby"
  CONFIG["RUBY_RELEASE_DATE"] = "2011-07-09"
  CONFIG["RUBY_PROGRAM_VERSION"] = "1.9.2"
  CONFIG["BASERUBY"] = "ruby"
  CONFIG["target_alias"] = ""
  CONFIG["host_alias"] = ""
  CONFIG["build_alias"] = ""
  CONFIG["LIBS"] = "-lshell32 -lws2_32 "
  CONFIG["ECHO_T"] = ""
  CONFIG["ECHO_N"] = "-n"
  CONFIG["ECHO_C"] = ""
  CONFIG["DEFS"] = ""
  CONFIG["mandir"] = "$(datarootdir)/man"
  CONFIG["localedir"] = "$(datarootdir)/locale"
  CONFIG["libdir"] = "$(exec_prefix)/lib"
  CONFIG["psdir"] = "$(docdir)"
  CONFIG["pdfdir"] = "$(docdir)"
  CONFIG["dvidir"] = "$(docdir)"
  CONFIG["htmldir"] = "$(docdir)"
  CONFIG["infodir"] = "$(datarootdir)/info"
  CONFIG["docdir"] = "$(datarootdir)/doc/$(PACKAGE)"
  CONFIG["oldincludedir"] = "/usr/include"
  CONFIG["includedir"] = "$(prefix)/include"
  CONFIG["localstatedir"] = "$(prefix)/var"
  CONFIG["sharedstatedir"] = "$(prefix)/com"
  CONFIG["sysconfdir"] = "$(prefix)/etc"
  CONFIG["datadir"] = "$(datarootdir)"
  CONFIG["datarootdir"] = "$(prefix)/share"
  CONFIG["libexecdir"] = "$(exec_prefix)/libexec"
  CONFIG["sbindir"] = "$(exec_prefix)/sbin"
  CONFIG["bindir"] = "$(exec_prefix)/bin"
  CONFIG["exec_prefix"] = "$(prefix)"
  CONFIG["PACKAGE_URL"] = ""
  CONFIG["PACKAGE_BUGREPORT"] = ""
  CONFIG["PACKAGE_STRING"] = ""
  CONFIG["PACKAGE_VERSION"] = ""
  CONFIG["PACKAGE_TARNAME"] = ""
  CONFIG["PACKAGE_NAME"] = ""
  CONFIG["PATH_SEPARATOR"] = ":"
  CONFIG["SHELL"] = "/bin/sh"
  CONFIG["rubylibdir"] = "$(rubylibprefix)/$(ruby_version)"
  CONFIG["archdir"] = "$(rubylibdir)/$(arch)"
  CONFIG["sitelibdir"] = "$(sitedir)/$(ruby_version)"
  CONFIG["sitearchdir"] = "$(sitelibdir)/$(sitearch)"
  CONFIG["vendorlibdir"] = "$(vendordir)/$(ruby_version)"
  CONFIG["vendorarchdir"] = "$(vendorlibdir)/$(sitearch)"
  CONFIG["topdir"] = File.dirname(__FILE__)
  MAKEFILE_CONFIG = {}
  CONFIG.each{|k,v| MAKEFILE_CONFIG[k] = v.dup}
  def RbConfig::expand(val, config = CONFIG)
    newval = val.gsub(/\$\$|\$\(([^()]+)\)|\$\{([^{}]+)\}/) {
      var = $&
      if !(v = $1 || $2)
	'$'
      elsif key = config[v = v[/\A[^:]+(?=(?::(.*?)=(.*))?\z)/]]
	pat, sub = $1, $2
	config[v] = false
	config[v] = RbConfig::expand(key, config)
	key = key.gsub(/#{Regexp.quote(pat)}(?=\s|\z)/n) {sub} if pat
	key
      else
	var
      end
    }
    val.replace(newval) unless newval == val
    val
  end
  CONFIG.each_value do |val|
    RbConfig::expand(val)
  end

  # returns the absolute pathname of the ruby command.
  def RbConfig.ruby
    File.join(
      RbConfig::CONFIG["bindir"],
      RbConfig::CONFIG["ruby_install_name"] + RbConfig::CONFIG["EXEEXT"]
    )
  end
end
Config = RbConfig # compatibility for ruby-1.8.4 and older.
CROSS_COMPILING = nil unless defined? CROSS_COMPILING
