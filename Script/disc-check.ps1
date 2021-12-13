param([string]$Drive = "", [int]$MinLevel = 20) # limite de stockage d’alerte en GB

try {
	if ($Drive -eq "" ) { $Drive = read-host "Entrer le disque a verifier" } #demande a l'utilsateur lequel des disques il veut tester

	$DriveDetails = (get-psdrive $Drive)
	[int]$Free = (($DriveDetails.Free / 1024) / 1024) / 1024 # calcul de l'espace libre
	[int]$Used = (($DriveDetails.Used / 1024) / 1024) / 1024 # Calcul de l'espace Utilisé
	[int]$Total = ($Used + $Free) #calcul de l'espace total

	if ($Free -lt $MinLevel) {
        	write-warning "le Disque $Drive a seulement $Free GB libre! ($Used sur $Total GB espace utilisé, le minimum est fixé a $MinLevel GB)"
		
	} # condition qui verifie si l'espace libre est infèrieur a la limite fixé d'alerte 


} catch {
	"⚠️ Error: $($Error[0]) ($($MyInvocation.MyCommand.Name):$($_.InvocationInfo.ScriptLineNumber))" #commande d'erreur dans le cas ou on ne rentre pas un attribut de disque valide
	
} 
