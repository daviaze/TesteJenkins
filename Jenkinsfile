pipeline {
    agent {
        label 'docker-agent'  // Define o nome do agente no nível do pipeline
    }
    stages {
        stage('Build') {
            agent {
                docker {
                    image 'gradle:8.2.0-jdk17-alpine'
                    reuseNode true
                }
            }
            steps {
                sh 'gradle --version'
            }
        }
    }
}
