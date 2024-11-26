pipeline {
    agent {
        docker {
            image 'mcr.microsoft.com/dotnet/nightly/sdk:6.0'
        }
    }
    stages {
        stage('Restore') {
            steps {
                sh 'mkdir -p /workspace/.dotnet'
                sh 'dotnet restore GerenciadorMatriculas/GerenciadorMatriculas.csproj'
            }
        }
        stage('Build') {
            steps {
                sh 'dotnet build GerenciadorMatriculas/GerenciadorMatriculas.csproj -c Release'
            }
        }
        stage('Test') {
            steps {
                sh 'dotnet test GerenciadorMatriculas/GerenciadorMatriculas.csproj -c Release'
            }
        }
    }
    post {
        always {
            echo 'Pipeline executado.'
        }
    }
}
