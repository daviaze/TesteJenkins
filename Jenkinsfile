pipeline {
  agent {
    docker {
      image 'mcr.microsoft.com/dotnet/sdk:6.0' // Use a imagem Docker do .NET SDK
      args '-v C:\\ProgramData\\Jenkins\\workspace\\teste-jenkins:/workspace' // Mapeia o volume
    }
  }
  stages {
    stage('Test') {
      steps {
        dir('workspace') {
          bat 'dotnet --version'
        }
      }
    }
  }
}
