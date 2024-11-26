pipeline {
    agent { 
        dockerfile true
        args '-v C:\\ProgramData\\Jenkins\\.jenkins\\workspace\\teste-jenkins:C:\\ProgramData\\Jenkins\\.jenkins\\workspace\\teste-jenkins'
          }
    stages {
        stage('Build') {
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
            steps {
                script {
                    bat 'dotnet test'      // Testes
                }
            }
        }
    }
}
