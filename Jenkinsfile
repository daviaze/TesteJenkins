pipeline {
  agent { dockerfile true }
  stages {
    stage('Test') {
          environment {
                  HOME="."
              }
      steps {
          sh "dotnet --version"
      }
    }
  }
}
