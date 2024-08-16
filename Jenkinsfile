pipeline {
  agent { dockerfile true }
  stages {
    stage('Test') {
      steps {
       def workspaceDir = env.WORKSPACE.replace('\\', '/').replace('C:', '/c')
          sh "cd ${workspaceDir} && dotnet --version"
      }
    }
  }
}
