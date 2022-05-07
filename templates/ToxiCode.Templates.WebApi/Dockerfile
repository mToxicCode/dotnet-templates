FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . ./
RUN dotnet restore "src/ToxiCode.Templates.WebApi/ToxiCode.Templates.WebApi.csproj"
RUN dotnet build "src/ToxiCode.Templates.WebApi/ToxiCode.Templates.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "src/ToxiCode.Templates.WebApi/ToxiCode.Templates.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ToxiCode.Templates.WebApi.dll"]
