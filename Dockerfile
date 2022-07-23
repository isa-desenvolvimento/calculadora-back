FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app
EXPOSE 80

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o dist
CMD ASPNETCORE_URLS=http://*:$PORT dotnet dist/calculadora-api.dll