FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Structural/Flyweight/Flyweight.csproj", "src/Structural/Flyweight/"]
RUN dotnet restore "src/Structural/Flyweight/Flyweight.csproj"
COPY . .
WORKDIR "/src/src/Structural/Flyweight"
RUN dotnet build "Flyweight.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Flyweight.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Flyweight.dll"]
