pipeline {
  agent any
  stages {
    stage('Pull Image') {
      steps {
        script {
          sh 'docker pull node:20.18.0-alpine3.20'
        }
      }
    }
    stage('Test') {
      agent {
        docker { image 'node:20.18.0-alpine3.20' }
      }
      steps {
        sh 'node --version'
      }
    }
  }
}
