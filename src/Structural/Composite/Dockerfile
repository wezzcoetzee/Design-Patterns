FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Structural/Composite/Composite.csproj", "src/Structural/Composite/"]
RUN dotnet restore "src/Structural/Composite/Composite.csproj"
COPY . .
WORKDIR "/src/src/Structural/Composite"
RUN dotnet build "Composite.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Composite.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Composite.dll"]
