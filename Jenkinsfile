pipeline {
    agent { dockerfile true }
    stages {
        stage('Build') {
            steps {
                script {
                    echo 'Building and testing the application...'
                    echo 'dotnet restore'
                    echo 'dotnet --version' // Confirmação do ambiente
                    echo 'dotnet build'     // Construção do projeto
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
