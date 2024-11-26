pipeline {
    agent { dockerfile true }
    stages {
        stage('Build') {
            steps {
                script {
                    echo 'Building and testing the application...'
                    sh 'dotnet --version'
                    sh 'dotnet build GerenciadorMatriculas.csproj'     // Construção do projeto
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
