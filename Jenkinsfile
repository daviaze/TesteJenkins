pipeline {
  agent { docker { image 'mcr.microsoft.com/dotnet/sdk:8.0' } }
  stages {
    stage('Test') {
      steps {
          sh "dotnet --version"
      }
    }
  }
}
