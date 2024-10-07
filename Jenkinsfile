pipeline { 
    agent any
    stages {
        stage('Build Docker Image') {
            steps {
                script {
                    // Construa a imagem Docker no host
                    sh 'docker build -t my-node-app .'
                }
            }
        }
        stage('Run Tests') {
            steps {
                script {
                    // Execute o container no host
                    sh 'docker run --rm --name test-node-app -v /var/run/docker.sock:/var/run/docker.sock my-node-app node --version'
                }
            }
        }
    }
}
