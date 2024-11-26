pipeline {
    agent { dockerfile true }
    stages {
        stage('Build') {
            agent { dockerfile true }
            steps {
                script {
                    echo 'Building and testing the application...'
                    bat 'dotnet restore'
                    bat 'dotnet --version' // Confirmação do ambiente
                    bat 'dotnet build'     // Construção do projeto
                }
            }
        }
        stage('Test'){
            agent { dockerfile true }
            steps {
                script {
                    bat 'dotnet test'      // Testes
                }
            }
        }
    }
}
