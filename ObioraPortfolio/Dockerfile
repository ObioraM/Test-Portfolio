
# NuGet restore
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY *.sln .
COPY ObioraPortfolio/*.csproj ObioraPortfolio/
RUN dotnet restore
COPY . .


# publish
FROM build AS publish
WORKDIR /src/ObioraPortfolio
RUN dotnet publish -c Release -o /src/publish


FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=publish /src/publish .
#ENTRYPOINT ["dotnet", "Portfolio.UI.dll"]
# heroku uses the following
CMD ASPNETCORE_URLS=http://*:$PORT dotnet ObioraPortfolio.dll
