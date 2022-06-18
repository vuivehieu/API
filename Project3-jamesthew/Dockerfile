#syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet-sdk:6.0 as build
COPY *.sln .
COPY Project3-jamesthew/*.csproj ./Project3-jamesthew/
RUN ["dotnet","restore"]

COPY Project3-jamesthew/. ./Project3-jamesthew/
WORKDIR /source/Project3-jamesthew
RUN ["dotnet","publish -c release -o /app -r linux-64 --no-restore"]

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT["dotnet","Project3-jamesthew.dll"]