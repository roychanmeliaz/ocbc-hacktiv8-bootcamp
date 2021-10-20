FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 48719
EXPOSE 27017
EXPOSE 5000
EXPOSE 5001


FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY . .


RUN dotnet restore 
RUN dotnet build --no-restore -c Release -o /app

FROM build AS publish
RUN dotnet publish --no-restore -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet CoreWebAPI.dll

# FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal AS base
# WORKDIR /app
# EXPOSE 5000

# ENV ASPNETCORE_URLS=http://*:5000

# # Creates a non-root user with an explicit UID and adds permission to access the /app folder
# # For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
# RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
# USER appuser

# FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
# WORKDIR /src
# COPY ["CoreWebAPI.csproj", "./"]
# RUN dotnet restore "CoreWebAPI.csproj"
# COPY . .
# WORKDIR "/src/."
# RUN dotnet build "CoreWebAPI.csproj" -c Release -o /app/build

# FROM build AS publish
# RUN dotnet publish "CoreWebAPI.csproj" -c Release -o /app/publish

# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "CoreWebAPI.dll"]
