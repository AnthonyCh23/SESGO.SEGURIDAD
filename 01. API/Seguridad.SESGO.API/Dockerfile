#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["01. API/Seguridad.SESGO.API/Seguridad.SESGO.API.csproj", "01. API/Seguridad.SESGO.API/"]
COPY ["02. Services/Seguridad.Service.EventHandlers/Seguridad.Service.EventHandlers.csproj", "02. Services/Seguridad.Service.EventHandlers/"]
COPY ["03. Persistence/Seguridad.Persistence.Database/Seguridad.Persistence.Database.csproj", "03. Persistence/Seguridad.Persistence.Database/"]
COPY ["04. Models/Seguridad.Domain/Seguridad.Domain.csproj", "04. Models/Seguridad.Domain/"]
COPY ["02. Services/Seguridad.Service.Queries/Seguridad.Service.Queries.csproj", "02. Services/Seguridad.Service.Queries/"]
RUN dotnet restore "01. API/Seguridad.SESGO.API/Seguridad.SESGO.API.csproj"
COPY . .
WORKDIR "/src/01. API/Seguridad.SESGO.API"
RUN dotnet build "Seguridad.SESGO.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Seguridad.SESGO.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Seguridad.SESGO.API.dll"]