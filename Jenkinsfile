pipeline {
  agent { docker { image 'mcr.microsoft.com/dotnet/sdk:8.0' } }
  stages {
    stage('Test') {
      steps {
                   MY_CONTAINER = bat(script: '@docker run -d -i mcr.microsoft.com/dotnet/sdk:8.0', returnStdout: true).trim()
                   echo "mycontainer_id is ${MY_CONTAINER}"
                   /* python --version gets executed inside the Container */
                   bat "docker exec ${MY_CONTAINER} python --version "
                   /* the Container gets removed */
                   bat "docker rm -f ${MY_CONTAINER}"
      }
    }
  }
}
