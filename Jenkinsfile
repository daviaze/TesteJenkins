pipeline {
  agent any
  stages {
    stage('Build Docker Image') {
      steps {
        script {
          bat 'docker build -t teste .'
        }
      }
    }
    stage('Test') {
      steps {
        script {
          // Iniciar o container a partir da imagem criada com o Dockerfile
          MY_CONTAINER = bat(script: 'docker run -d -i teste', returnStdout: true).trim()
          echo "mycontainer_id is ${MY_CONTAINER}"
          // Executar o comando dentro do container
          bat "docker exec ${MY_CONTAINER} dotnet --version"
          // Remover o container
          bat "docker rm -f ${MY_CONTAINER}"
        }
      }
    }
  }
}
