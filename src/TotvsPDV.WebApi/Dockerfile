FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/TotvsPDV.WebApi/TotvsPDV.WebApi.csproj", "src/TotvsPDV.WebApi/"]
RUN dotnet restore "src/TotvsPDV.WebApi/TotvsPDV.WebApi.csproj"
COPY . .
WORKDIR "/src/src/TotvsPDV.WebApi"
RUN dotnet build "TotvsPDV.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TotvsPDV.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TotvsPDV.WebApi.dll"]