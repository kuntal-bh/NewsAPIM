FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 54009
EXPOSE 44329

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY NewsAPIM/NewsAPIM.csproj NewsAPIM/
RUN dotnet restore NewsAPIM/NewsAPIM.csproj
COPY . .
WORKDIR /src/NewsAPIM
RUN dotnet build NewsAPIM.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish NewsAPIM.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "NewsAPIM.dll"]
