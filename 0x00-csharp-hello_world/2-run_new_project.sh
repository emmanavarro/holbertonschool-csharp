#!/usr/bin/env bash
# Script that initializes, builds, and runs a new C# project from a folder titled 2-new_project

mkdir -p 2-new_project
cd 2-new_project
dotnet new console
dotnet build
dotnet run
