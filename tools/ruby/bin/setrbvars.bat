@ECHO OFF
REM Determine where is RUBY_BIN (where this script is)
PUSHD %~dp0.
SET RUBY_BIN=%CD%
POPD

REM Add RUBY_BIN to the PATH
REM RUBY_BIN takes higher priority to avoid other tools
REM conflict with our own (mainly the DevKit)
SET PATH=%RUBY_BIN%;%PATH%
SET RUBY_BIN=

REM Display Ruby version
ruby.exe -v
