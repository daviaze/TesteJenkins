pipeline {
    agent any
    stages {
        stage('Build and Test') {
            agent any
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
