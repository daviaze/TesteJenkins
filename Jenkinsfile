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
                    sh 'node --version'
                }
            }
        }
    }
}
