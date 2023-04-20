FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Command/Command.csproj", "Command/"]
RUN dotnet restore "Command/Command.csproj"
COPY . .
WORKDIR "/src/Command"
RUN dotnet build "Command.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Command.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Command.dll"]
