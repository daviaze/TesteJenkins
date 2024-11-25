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
                    sh 'dotnet --version' // Confirmação do ambiente
                    sh 'dotnet build'     // Construção do projeto
                    sh 'dotnet test'      // Testes
                }
            }
        }
    }
}
