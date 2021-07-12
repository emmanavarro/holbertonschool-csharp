#!/usr/bin/env bash
# Script that initializes and builds a new C# project inside a folder titled 1-new_project

mkdir -p 1-new_project
cd 1-new_project
dotnet new console
dotnet build
