FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Creational/Prototype/Prototype.csproj", "src/Creational/Prototype/"]
RUN dotnet restore "src/Creational/Prototype/Prototype.csproj"
COPY . .
WORKDIR "/src/src/Creational/Prototype"
RUN dotnet build "Prototype.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Prototype.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Prototype.dll"]
