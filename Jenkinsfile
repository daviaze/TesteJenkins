pipeline {
  agent {
        docker {
            image 'mcr.microsoft.com/dotnet/sdk:6.0'
        }
    }
    stages {
        stage('Build') {
            steps {
                script {
                    echo 'Building and testing the application...'
                    sh 'dotnet restore GerenciadorMatriculas/GerenciadorMatriculas.csproj'
                    sh 'dotnet --version' // Confirmação do ambiente
                    sh 'dotnet build'     // Construção do projeto
                }
            }
        }
        stage('Test'){
            steps {
                script {
                    sh 'dotnet test'      // Testes
                }
            }
        }
    }
}
