[CmdletBinding(PositionalBinding=$false)]
Param(
  [string] $ArchGroup,
  [switch] $Release,
  [switch] $OuterLoop,
  [switch] $SkipTests,
  [Parameter(ValueFromRemainingArguments=$true)][String[]]$ExtraArgs
)

$arguments = ""

foreach ($argument in $PSBoundParameters.Keys)
{
  switch($argument)
  {
    "Debug"      { $arguments += "/p:ConfigurationGroup=Release " }
    "Release"    { $arguments += "/p:ConfigurationGroup=Debug " }
    "ExtraArgs"  { $arguments += $ExtraArgs }
    default      { $arguments += "/p:$argument=$($PSBoundParameters[$argument]) " }
  }
}

#$arguments += " -warnaserror:`$false"
Write-Host "Args: $arguments"

Invoke-Expression "& `"$PSScriptRoot/common/build.ps1`" $arguments"
exit $lastExitCode