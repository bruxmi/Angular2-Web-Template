# Use the Update-SolutionScripts cmdlet after changes
function global:Add-Application-Migration() {
	Param(
		[Parameter(Mandatory=$True)]
		[string]$Name
	)
		
	Write-Host "Adding Application Migration."		
	Add-Migration $Name -ConnectionStringName AppSettingContext -ProjectName Data.ApplicationSettingsContext -StartUp Presentation.Web
}