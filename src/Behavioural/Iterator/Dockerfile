FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Behavioural/Iterator/Iterator.csproj", "src/Behavioural/Iterator/"]
RUN dotnet restore "src/Behavioural/Iterator/Iterator.csproj"
COPY . .
WORKDIR "/src/src/Behavioural/Iterator"
RUN dotnet build "Iterator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Iterator.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Iterator.dll"]
