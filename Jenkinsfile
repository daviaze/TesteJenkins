pipeline {
    agent { dockerfile true }
    stages {
        stage('Restore') {
            steps {
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
