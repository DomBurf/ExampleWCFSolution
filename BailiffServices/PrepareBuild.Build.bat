@echo off
"%BUILD_TOOLS%\nant\nant.exe" -buildfile:Preparebuild.Build.xml -D:verbose=true PrepareBuild > PrepareBuild.Build.log
start notepad PrepareBuild.Build.log