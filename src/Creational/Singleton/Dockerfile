FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Creational/Singleton/Singleton.csproj", "src/Creational/Singleton/"]
RUN dotnet restore "src/Creational/Singleton/Singleton.csproj"
COPY . .
WORKDIR "/src/src/Creational/Singleton"
RUN dotnet build "Singleton.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Singleton.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Singleton.dll"]
