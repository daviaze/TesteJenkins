pipeline { 
    agent { 
        docker { 
            image 'node:20.18.0-alpine3.20' // Use a imagem Docker do Node.js 
            args '-v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/app' // Montar o soquete Docker e o diretório atual
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
