pipeline {
  agent any
  stages {
    stage('Build Docker Image') {
      steps {
        script {
          // Use o Dockerfile para construir a imagem
          sh 'docker build -t my-dotnet-app -f Dockerfile .'
        }
      }
    }
    stage('Run Tests') {
      steps {
        script {
          // Execute o container como um container irmão
          sh 'docker run --rm --name my-dotnet-app-container my-dotnet-app dotnet --version'
        }
      }
    }
  }
}
