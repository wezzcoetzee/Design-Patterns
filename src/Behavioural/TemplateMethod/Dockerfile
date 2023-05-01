FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Behavioural/TemplateMethod/TemplateMethod.csproj", "src/Behavioural/TemplateMethod/"]
RUN dotnet restore "src/Behavioural/TemplateMethod/TemplateMethod.csproj"
COPY . .
WORKDIR "/src/src/Behavioural/TemplateMethod"
RUN dotnet build "TemplateMethod.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TemplateMethod.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TemplateMethod.dll"]
