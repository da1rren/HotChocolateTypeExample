FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["HC.CustomerNumberScalar/HC.CustomerNumberScalar.csproj", "HC.CustomerNumberScalar/"]
RUN dotnet restore "HC.CustomerNumberScalar/HC.CustomerNumberScalar.csproj"
COPY . .
WORKDIR "/src/HC.CustomerNumberScalar"
RUN dotnet build "HC.CustomerNumberScalar.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HC.CustomerNumberScalar.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HC.CustomerNumberScalar.dll"]
