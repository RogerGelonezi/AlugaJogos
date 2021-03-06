#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["AlugaJogos.Product.Api/AlugaJogos.Product.Api.csproj", "AlugaJogos.Product.Api/"]
COPY ["AlugaJogos.Product.Model/AlugaJogos.Product.Model.csproj", "AlugaJogos.Product.Model/"]
COPY ["AlugaJogos.Product.Dal/AlugaJogos.Product.Dal.csproj", "AlugaJogos.Product.Dal/"]
COPY ["AlugaJogos.Repository/AlugaJogos.Repository.csproj", "AlugaJogos.Repository/"]
RUN dotnet restore "AlugaJogos.Product.Api/AlugaJogos.Product.Api.csproj"
COPY . .
WORKDIR "/src/AlugaJogos.Product.Api"
RUN dotnet build "AlugaJogos.Product.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AlugaJogos.Product.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AlugaJogos.Product.Api.dll"]