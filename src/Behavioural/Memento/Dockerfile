FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Behavioural/Memento/Memento.csproj", "src/Behavioural/Memento/"]
RUN dotnet restore "src/Behavioural/Memento/Memento.csproj"
COPY . .
WORKDIR "/src/src/Behavioural/Memento"
RUN dotnet build "Memento.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Memento.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Memento.dll"]
