properties([
    parameters([
        string(name: 'BRANCH_NAME', defaultValue: 'BranchA', description: 'Enter the branch to build')
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
                // Replace below with Windows batch command equivalent if build.sh doesn't exist or isn't usable
                bat 'echo Simulating build process...'
            }
        }

        stage('Test') {
            steps {
                echo "🧪 Running tests..."
                bat 'echo Simulating tests...'
            }
        }

        stage('Deploy') {
            steps {
                echo "🚀 Deploying the application..."
                bat 'echo Simulating deployment...'
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
