pipeline {
    agent { docker {
        image 'mcr.microsoft.com/dotnet/sdk:6.0'
        args '-v $HOME/.m2:/root/.m2'
    } }
    environment {
       HOME = '/tmp'
    }
    stages {
        stage('Build') {
            steps {
                script {
                    echo 'Building and testing the application...'
                    sh 'dotnet --version'
                    sh 'dotnet restore GerenciadorMatriculas/GerenciadorMatriculas.csproj'
                    sh 'dotnet build GerenciadorMatriculas/GerenciadorMatriculas.csproj'     // Construção do projeto
                }
            }
        }
        stage('Test'){
            steps {
                script {
                    echo 'dotnet test'      // Testes
                }
            }
        }
    }
}
