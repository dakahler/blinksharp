@echo off

for /d %%a in (
  "packages\NuGet.CommandLine.*"
) do set "nugetPath=%%~fa\tools\nuget.exe"

echo Using nuget.exe at %nugetPath%
mkdir bin\nuget 2>NUL
%nugetPath% pack BlinkSharp.csproj -IncludeReferencedProjects -Prop Configuration=Release -OutputDirectory bin\nuget