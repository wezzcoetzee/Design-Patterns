FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Behavioural/State/State.csproj", "src/Behavioural/State/"]
RUN dotnet restore "src/Behavioural/State/State.csproj"
COPY . .
WORKDIR "/src/src/Behavioural/State"
RUN dotnet build "State.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "State.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "State.dll"]
