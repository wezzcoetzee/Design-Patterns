FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Behavioural/Visitor/Visitor.csproj", "src/Behavioural/Visitor/"]
RUN dotnet restore "src/Behavioural/Visitor/Visitor.csproj"
COPY . .
WORKDIR "/src/src/Behavioural/Visitor"
RUN dotnet build "Visitor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Visitor.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Visitor.dll"]
