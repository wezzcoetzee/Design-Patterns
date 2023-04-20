FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Behavioural/Strategy/Strategy.csproj", "src/Behavioural/Strategy/"]
RUN dotnet restore "src/Behavioural/Strategy/Strategy.csproj"
COPY . .
WORKDIR "/src/src/Behavioural/Strategy"
RUN dotnet build "Strategy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Strategy.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Strategy.dll"]
