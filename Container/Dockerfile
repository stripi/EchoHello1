# 1. Set base image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

# 2. Set working directory to /App
WORKDIR /App

# 3. copy source code and restore dependencies
COPY . ./
RUN dotnet restore

# 4. build and publish the app
RUN dotnet publish -c Release -o out

# 5. Set the working directory to the output folder 
WORKDIR /App/out

# 6. Run the application via the .dll file 
ENTRYPOINT ["dotnet", "Container.dll"]

EXPOSE 8080

ENV ASPNETCORE_URLS=http://+8080