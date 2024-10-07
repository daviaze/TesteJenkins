pipeline {
  agent any
  stages {
    stage('Build and Publish') {
      steps {
        script {
          docker.image('mcr.microsoft.com/dotnet/sdk:6.0').inside {
            sh 'dotnet restore GerenciadorMatriculas/GerenciadorMatriculas.csproj'
            sh 'dotnet build GerenciadorMatriculas/GerenciadorMatriculas.csproj -c Release -o /app/build'
            sh 'dotnet publish GerenciadorMatriculas/GerenciadorMatriculas.csproj -c Release -o /app/publish /p:UseAppHost=false'
          }
        }
      }
    }
  }
}
