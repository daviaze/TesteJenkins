pipeline {
  agent {         docker {
            image 'mcr.microsoft.com/dotnet/sdk:6.0'
            args '-v /c/ProgramData/Jenkins/.jenkins/workspace/teste-jenkins:/app -w /app'
        }}
  stages {
    stage('Test') {
      steps {
          sh "dotnet --version"
      }
    }
  }
}
