pipeline {
    agent {     
        dockerfile {
            // Especifica o uso do Dockerfile no diretório raiz
            filename 'Dockerfile'
            // Opcional: argumentos adicionais para o docker
            args '-v /c/ProgramData/Jenkins/.jenkins/workspace/teste-jenkins:/src -w /src'
        }}
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
