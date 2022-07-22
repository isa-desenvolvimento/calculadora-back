FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
 
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["calculadora-api.csproj", "calculadora-api/"]
RUN dotnet restore "calculadora-api/calculadora-api.csproj"
WORKDIR "/src/calculadora-api"
COPY . .
RUN dotnet build "calculadora-api.csproj" -c Release -o /app/build
 
FROM build AS publish
RUN dotnet publish "calculadora-api.csproj" -c Release -o /app/publish
 
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet calculadora-api.dll