# Base image for runtime
FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

# Build image with SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy the project file(s) and restore as distinct layers
COPY ["GerenciadorMatriculas/GerenciadorMatriculas.csproj", "GerenciadorMatriculas/"]
RUN dotnet restore "GerenciadorMatriculas/GerenciadorMatriculas.csproj"

# Copy everything else and build
COPY . .
WORKDIR "/src/GerenciadorMatriculas"
RUN dotnet build "GerenciadorMatriculas.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish the project
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "GerenciadorMatriculas.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final stage/image to run the app
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GerenciadorMatriculas.dll"]
