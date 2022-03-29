#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Udea.Chaos.Owner.Api/Udea.Chaos.Owner.Api.csproj", "Udea.Chaos.Owner.Api/"]
COPY ["Udea.Chaos.Owner.Application/Udea.Chaos.Owner.Application.csproj", "Udea.Chaos.Owner.Application/"]
COPY ["Udea.Chaos.Owner.Domain/Udea.Chaos.Owner.Domain.csproj", "Udea.Chaos.Owner.Domain/"]
COPY ["Udea.Chaos.Owner.Infrastructure/Udea.Chaos.Owner.Infrastructure.csproj", "Udea.Chaos.Owner.Infrastructure/"]
RUN dotnet restore "Udea.Chaos.Owner.Api/Udea.Chaos.Owner.Api.csproj"
COPY . .
WORKDIR "/src/Udea.Chaos.Owner.Api"
RUN dotnet build "Udea.Chaos.Owner.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Udea.Chaos.Owner.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Udea.Chaos.Owner.Api.dll"]