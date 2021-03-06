#!/usr/bin/env bash
# Copyright (c) Microsoft. All rights reserved.
# Licensed under the MIT license. See LICENSE file in the project root for full license information.

if [ "$1" == "-?" -o "$1" == "-h" -o "$1" == "-help" -o "$1" == "--help" ]; then
	powershell -command "Get-Help .\build.ps1"
	exit;
fi

powershell -command ".\build.ps1 -nolegacy "$@"; exit $LASTEXITCODE"
exit $?
