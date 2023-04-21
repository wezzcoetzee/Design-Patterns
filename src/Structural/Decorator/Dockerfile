FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Structural/Decorator/Decorator.csproj", "src/Structural/Decorator/"]
RUN dotnet restore "src/Structural/Decorator/Decorator.csproj"
COPY . .
WORKDIR "/src/src/Structural/Decorator"
RUN dotnet build "Decorator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Decorator.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Decorator.dll"]
