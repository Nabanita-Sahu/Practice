properties([
    parameters([
        string(name: 'BRANCH_NAME', defaultValue: 'main', description: 'Enter the branch to build')
    ])
])

pipeline {
    agent any

    environment {
        PROJECT_NAME = "Practice"
    }

    stages {
        stage('Clone') {
            steps {
                echo "🔁 Cloning repository from branch: ${params.BRANCH_NAME}"
                git branch: "${params.BRANCH_NAME}", url: 'https://github.com/Nabanita-Sahu/Practice.git'
            }
        }

        stage('Build') {
            steps {
                echo "🔧 Running build script..."
                sh './build.sh'
            }
        }

        stage('Test') {
            steps {
                echo "🧪 Running tests..."
                // Add test commands here if required
            }
        }

        stage('Deploy') {
            steps {
                echo "🚀 Deploying the application..."
                // Add deployment steps here
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
