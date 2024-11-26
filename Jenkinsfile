pipeline {
    agent any
    stages {
        stage('Build and Test') {
            agent any
            steps {
                script {
                    echo 'Building and testing the application...'
                    bat 'dotnet restore'
                    bat 'dotnet --version' // Confirmação do ambiente
                    bat 'dotnet build'     // Construção do projeto
                    bat 'dotnet test'      // Testes
                }
            }
        }
    }
}
