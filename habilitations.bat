cd /d SonarScanner.MSBuild.exe end /d:sonar.token="sqp_5a2450d49e98bd0837e2189d5bb7cde3dd701456"
SonarScanner.MSBuild.exe begin /k:"habilitations2024" /d:sonar.host.url="http://localhost:9000" /d:sonar.token="sqp_5a2450d49e98bd0837e2189d5bb7cde3dd701456"
MsBuild.exe /t:Rebuild
SonarScanner.MSBuild.exe end /d:sonar.token="sqp_5a2450d49e98bd0837e2189d5bb7cde3dd701456"