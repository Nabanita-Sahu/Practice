pipeline {
    agent any

    environment {
        PROJECT_NAME = "Practice"
    }

    stages {
        stage('Clone') {
            steps {
                echo "Cloning repository..."
                git 'https://github.com/Nabanita-Sahu/Practice.git'
            }
        }

        stage('Build') {
            steps {
                echo "Running build script..."
                sh './build.sh'
            }
        }

        stage('Test') {
            steps {
                echo "Running tests..."
                // Add test command here if needed, e.g.
                // sh 'npm test' or sh './gradlew test'
            }
        }

        stage('Deploy') {
            steps {
                echo "Deploying the application..."
                // Add your deploy script here, e.g.
                // sh './deploy.sh'
            }
        }
    }

    post {
        success {
            echo "✅ Build completed successfully for ${env.PROJECT_NAME}"
        }
        failure {
            echo "❌ Build failed for ${env.PROJECT_NAME}"
        }
        
    }
}
