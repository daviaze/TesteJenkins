pipeline {
    agent any
    stages {
        stage('Run Tests in Docker') {
            steps {
                script {
                    // Inicia o contêiner em segundo plano sem definir o diretório de trabalho
                    def containerId = bat(script: 'docker run -d -i mcr.microsoft.com/dotnet/sdk:6.0', returnStdout: true).trim()

                    // Executa o comando 'dotnet --version' dentro do contêiner
                    bat "docker exec ${containerId} dotnet --version"

                    // Executa o comando 'dotnet build' dentro do contêiner
                    bat "docker exec ${containerId} dotnet build"

                    // Executa o comando 'dotnet test' dentro do contêiner
                    bat "docker exec ${containerId} dotnet test"

                    // Finaliza o contêiner
                    bat "docker stop ${containerId}"

                    // Remove o contêiner
                    bat "docker rm ${containerId}"
                }
            }
        }
    }
}
