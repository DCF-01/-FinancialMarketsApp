#Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./src/FinancialMarketsApp/FinancialMarketsApp.MVC.csproj" --disable-parallel
RUN dotnet publish "./src/FinancialMarketsApp/FinancialMarketsApp.MVC.csproj" -c release -o /app --no-restore
#Serve stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from=build /app ./
EXPOSE 5000

ENTRYPOINT ["dotnet","FinancialMarketsApp.MVC.dll"]
