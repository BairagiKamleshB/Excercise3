pipeline{
    agent any 
    environment{
        DOTNET_CLI_HOME="C:\\Program Files\\dotnet"
    }
    stages{
        stage("Checkout"){
            steps{
                checkout scm
            }
        }
        stage("Restore"){
            steps{
                bat "dotnet restore Excercise3.sln"
            }
        }
        stage('Build') {
            steps {
                bat "dotnet build Excercise3.sln --congiguration Release"
            }
        }

        stage('Test') {
            steps {
                echo 'Running tests'
            }
        }

        stage('Deploy') {
            steps {
                echo 'Deploying application'
            }
        }
    }
}