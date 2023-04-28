FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Behavioural/ChainOfResponsibility/ChainOfResponsibility.csproj", "src/Behavioural/ChainOfResponsibility/"]
RUN dotnet restore "src/Behavioural/ChainOfResponsibility/ChainOfResponsibility.csproj"
COPY . .
WORKDIR "/src/src/Behavioural/ChainOfResponsibility"
RUN dotnet build "ChainOfResponsibility.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ChainOfResponsibility.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ChainOfResponsibility.dll"]
