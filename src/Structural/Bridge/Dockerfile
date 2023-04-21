FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Structural/Bridge/Bridge.csproj", "src/Structural/Bridge/"]
RUN dotnet restore "src/Structural/Bridge/Bridge.csproj"
COPY . .
WORKDIR "/src/src/Structural/Bridge"
RUN dotnet build "Bridge.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Bridge.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bridge.dll"]
