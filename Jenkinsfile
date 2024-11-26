pipeline {
    agent any
    stages {
        stage('Build and Test') {
            agent {
                docker {
                    image 'mcr.microsoft.com/dotnet/sdk:6.0' // Imagem do .NET SDK
                }
            }
            steps {
                script {
                    echo 'Building and testing the application...'
                    bat 'dotnet --version' // Confirmação do ambiente
                    bat 'dotnet build'     // Construção do projeto
                    bat 'dotnet test'      // Testes
                }
            }
        }
    }
}
