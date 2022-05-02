#Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./src/FinancialMarketsApp.sln" --disable-parallel
RUN dotnet publish "./src/FinancialMarketsApp.sln" -c release -o /app --no-restore
#Serve stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from=build /app ./
EXPOSE 80

ENTRYPOINT ["dotnet","FinancialMarketsApp.MVC.dll"]
