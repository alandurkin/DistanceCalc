FROM mcr.microsoft.com/dotnet/runtime:6.0-focal AS base
WORKDIR /app

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["Tests.Api/Tests.Api.csproj", "Tests.Api/"]
RUN dotnet restore "Tests.Api/Tests.Api.csproj"
COPY . .
WORKDIR "/src/Tests.Api"
RUN dotnet build "Tests.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Tests.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM build AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "test", "Tests.Api.dll"]
