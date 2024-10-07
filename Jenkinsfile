pipeline { 
    agent { 
        docker { 
            image 'desktop-jenkins-1' // O Jenkins está sendo executado dentro deste contêiner Docker 
            args '-v /var/run/docker.sock:/var/run/docker.sock' // Montar o soquete Docker 
        } 
    } 
    stages {
        stage('Test Node.js') {
            steps {
                script {
                    // Executa o comando para verificar a versão do Node.js
                    sh 'docker run --rm --name test-node-app -v /var/run/docker.sock:/var/run/docker.sock node:20.18.0-alpine3.20 node --version'
                }
            }
        }
    }
}
