FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Project3-jamesthew/Project3-jamesthew.csproj", "Project3-jamesthew/"]
RUN dotnet restore "Project3-jamesthew/Project3-jamesthew.csproj"
COPY . .
WORKDIR "/src/WebApplication1"
RUN dotnet build "Project3-jamesthew.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Project3-jamesthew.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Project3-jamesthew.dll"]
