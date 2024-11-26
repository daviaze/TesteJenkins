pipeline {
    agent any
    stages {
        stage('Build') {
            agent any
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
            agent any
            steps {
                scripts {
                    bat 'dotnet test'      // Testes
                }
            }
        }
    }
}
