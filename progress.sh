#!/bin/bash

echo "Building Progress Tracker..."
dotnet build ProgressTracker/ProgressTracker.csproj

if [ $? -eq 0 ]; then
    echo ""
    echo "Running Progress Tracker..."
    echo ""
    dotnet run --project ProgressTracker/ProgressTracker.csproj -- "$@"
else
    echo ""
    echo "Build failed. Please check for errors."
fi