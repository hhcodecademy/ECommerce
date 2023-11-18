#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ECommerce.WebUI/ECommerce.WebUI.csproj", "ECommerce.WebUI/"]
RUN dotnet restore "ECommerce.WebUI/ECommerce.WebUI.csproj"
COPY . .
WORKDIR "/src/ECommerce.WebUI"
RUN dotnet build "ECommerce.WebUI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ECommerce.WebUI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ECommerce.WebUI.dll"]