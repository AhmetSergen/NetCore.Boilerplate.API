# NetCore.Boilerplate.API
.Net Core Boilerplate API for windows

# Codes Used When Creating The Project

## Install .Net 8 SDK

### Windows (winget)
    winget install Microsoft.DotNet.SDK.8
### Ubuntu/Debian
    sudo apt-get update
    sudo apt-get install -y dotnet-sdk-8.0
### Verify 
    dotnet --info

## Create a solution & Web API project
*The template already includes WeatherForecast + Swagger + HTTPS dev cert usage.*
    dotnet new sln -n NetCore.Boilerplate.API 

### Controller-based Web API template with OpenAPI (Swagger)
    dotnet new webapi -n MyApi -f net8.0 --use-controllers
    dotnet sln add MyApi/MyApi.csproj

## Trust HTTPS dev cert (first time only)
    dotnet dev-certs https --trust

## Run API
    cd MyApi
    dotnet run