pipeline {
    agent {
        docker {
            image 'mcr.microsoft.com/dotnet/sdk:6.0'
            args '-v /c/ProgramData/Jenkins/.jenkins/workspace:/workspace -w /workspace -e DOTNET_CLI_HOME=/workspace/.dotnet -e DOTNET_ROOT=/workspace/.dotnet'
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
