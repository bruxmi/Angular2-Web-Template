# Use the Update-SolutionScripts cmdlet after changes
function global:Update-Databases() {
	Update-Application-Database
	Write-Host "Update-Databases done."	
}