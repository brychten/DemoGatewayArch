﻿FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["DemoGatewayArch/DemoGatewayArch.csproj", "DemoGatewayArch/"]
RUN dotnet restore "DemoGatewayArch/DemoGatewayArch.csproj"
COPY . .
WORKDIR "/src/DemoGatewayArch"
RUN dotnet build "DemoGatewayArch.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DemoGatewayArch.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoGatewayArch.dll"]
