# Usar a imagem base do .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Definir o diretório de trabalho
WORKDIR /app

# Instalar dependências, como o .NET, se necessário (mas o SDK já estará instalado na imagem)

# Você pode adicionar outros comandos de configuração, se necessário

# Não é necessário fazer build ou restore aqui, apenas preparando o ambiente
# Finalizamos o Dockerfile com a configuração necessária
