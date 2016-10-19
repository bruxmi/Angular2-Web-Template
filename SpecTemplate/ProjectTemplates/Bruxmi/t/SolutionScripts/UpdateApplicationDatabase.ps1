# Use the Update-SolutionScripts cmdlet after changes
function global:Update-Application-Database() {
	Write-Host "Updating Application Database."		
	Update-Database -ConnectionStringName AppSettingContext -ProjectName Data.ApplicationSettingsContext -StartUp Presentation.Web
}