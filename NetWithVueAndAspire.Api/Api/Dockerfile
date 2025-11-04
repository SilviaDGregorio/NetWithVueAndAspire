# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy full repo (build context is repo root in docker-compose)
COPY . .

# Restore and publish the Api project
RUN dotnet restore .
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false .

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Serve HTTP on port 80 to avoid HTTPS cert complexity inside container
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "NetWithVueAndAspire.Api.dll"]