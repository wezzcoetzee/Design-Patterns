FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Behavioural/Observer/Observer.csproj", "src/Behavioural/Observer/"]
RUN dotnet restore "src/Behavioural/Observer/Observer.csproj"
COPY . .
WORKDIR "/src/src/Behavioural/Observer"
RUN dotnet build "Observer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Observer.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Observer.dll"]
