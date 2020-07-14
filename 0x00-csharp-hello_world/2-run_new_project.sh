#!/usr/bin/env bash

mkdir 2-new_project
dotnet new console -o 2-new_project
dotnet build 2-new_project
dotnet run --project ./2-new_project/2-new_project.csproj
