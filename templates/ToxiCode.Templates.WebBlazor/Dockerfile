FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ToxiCode.Templates.WebBlazor/ToxiCode.Templates.WebBlazor.csproj", "ToxiCode.Templates.WebBlazor/"]
RUN dotnet restore "ToxiCode.Templates.WebBlazor/ToxiCode.Templates.WebBlazor.csproj"
COPY . .
WORKDIR "/src/ToxiCode.Templates.WebBlazor"
RUN dotnet build "ToxiCode.Templates.WebBlazor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ToxiCode.Templates.WebBlazor.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ToxiCode.Templates.WebBlazor.dll"]
