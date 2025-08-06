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
                script {
                    // Sanitize branch name to remove leading "*/" if present
                    def safeBranch = params.BRANCH_NAME.replaceFirst(/\*\//, '')
                    echo "🔁 Cloning repository from branch: ${safeBranch}"
                    git branch: "${safeBranch}", url: 'https://github.com/Nabanita-Sahu/Practice.git'
                }
            }
        }

        stage('Build') {
            steps {
                echo "🔧 Running build script..."
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
