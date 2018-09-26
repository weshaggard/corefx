#!/usr/bin/env bash

source="${BASH_SOURCE[0]}"

# resolve $source until the file is no longer a symlink
while [[ -h "$source" ]]; do
  scriptroot="$( cd -P "$( dirname "$source" )" && pwd )"
  source="$(readlink "$source")"
  # if $source was a relative symlink, we need to resolve it relative to the path where the
  # symlink file was located
  [[ $source != /* ]] && source="$scriptroot/$source"
done
scriptroot="$( cd -P "$( dirname "$source" )" && pwd )"

arguments=''
extraargs=''

while (($# > 0)); do
  lowerI="$(echo $1 | awk '{print tolower($0)}')"
  case $lowerI in
     -buildArch)
      arguments="$arguments /p:ArchGroup=$2"
      shift 2
      ;;
     -release)
      arguments="$arguments /p:ConfigurationGroup=Release"
      shift 1
      ;;
     -debug)
      arguments="$arguments /p:ConfigurationGroup=Debug"
      shift 1
      ;;
     -Outerloop)
      arguments="$arguments /p:OuterLoop=true"
      shift 1
      ;;
     -SkipTests)
      arguments="$arguments /p:SkipTests=true"
      shift 1
      ;;
      --)
      shift 1
      ;;
      *)
      extraargs="$extraargs $1"
      shift 1
      ;;
  esac
done

"$scriptroot/common/build.sh" $arguments $extraargs
exit $?