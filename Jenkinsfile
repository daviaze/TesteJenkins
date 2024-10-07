pipeline {
  agent any
  stages {
    stage('Build Docker Image') {
      steps {
        script {
          // Use o Dockerfile para construir a imagem
          echo 'build'
        }
      }
    }
    stage('Run Tests') {
      steps {
        script {
          // Execute o container como um container irmão
          echo 'testes'
        }
      }
    }
  }
}
