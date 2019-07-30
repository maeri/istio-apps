FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY istio-test/istio-test.csproj istio-test/
RUN dotnet restore istio-test/istio-test.csproj
COPY . .
WORKDIR /src/istio-test
RUN dotnet build istio-test.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish istio-test.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "istio-test.dll"]
