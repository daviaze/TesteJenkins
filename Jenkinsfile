pipeline {
  agent any
  stages {
    stage('Build Docker Image') {
      steps {
        script {
          sh 'docker build -t my-dotnet-app .'
        }
      }
    }
    stage('Test') {
      steps {
        script {
          // Iniciar o container a partir da imagem criada com o Dockerfile
          MY_CONTAINER = sh(script: 'docker run -d -i my-dotnet-app', returnStdout: true).trim()
          echo "mycontainer_id is ${MY_CONTAINER}"
          // Executar o comando dentro do container
          sh "docker exec ${MY_CONTAINER} dotnet --version"
          // Remover o container
          sh "docker rm -f ${MY_CONTAINER}"
        }
      }
    }
  }
}
