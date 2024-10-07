pipeline { 
    agent { 
        docker { 
            image 'docker:latest' // O Jenkins está sendo executado dentro deste contêiner Docker 
            args '-v /var/run/docker.sock:/var/run/docker.sock' // Montar o soquete Docker 
        } 
    }  
    steps { 
        stage('Checkout Code') { 
            steps { 
                git 'https://github.com/your-repo/your-python-project.git' // Obter o código Python do repositório 
            } 
        } 
        stage('Executar testes Python') { 
            steps { 
                script { 
                    // Criar um contêiner Docker usando o daemon Docker do host 
                    docker.image('python:3.8').inside { 
                        sh 'pip install -r requirements.txt' // Instalar dependências 
                        sh 'pytest' // Executar os testes usando pytest 
                    } 
                } 
            }     } 
        } }
