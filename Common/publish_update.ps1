##########################
# CONFIGURAZIONE
##########################

# Percorsi dei progetti
$foProjectPath = "C:\Users\fil\Desktop\Progetti\Crediti\FrontOffice"
$boProjectPath = "C:\Users\fil\Desktop\Progetti\Crediti\BackOffice"

# Exe Name
$foExeName = "FrontOffice.exe"
$boExeName = "BackOffice.exe"

# Icon Path
$foIconPath = "C:\Users\fil\Desktop\Progetti\Crediti\FrontOffice\crediti_icon.ico"
$boIconPath = "C:\Users\fil\Desktop\Progetti\Crediti\BackOffice\crediti_icon.ico"

# PackID
$foPackId = "FilBatta.Crediti.FrontOffice"
$boPackId = "FilBatta.Crediti.BackOffice"

# PackTitle
$foPackTitle = "FrontOffice"
$boPackTitle = "BackOffice"

# Token GitHub
$oauth = Get-Content -Path "C:\Users\fil\Desktop\github_token_velopack.txt" -TotalCount 1

# Repo
$foRepoUrl = "https://github.com/Fil0611/CreditiFO"
$boRepoUrl = "https://github.com/Fil0611/CreditiBO"

##########################
# INSERIMENTO VERSIONE
##########################

$json = Get-Content -Raw -Path ".\bin\Release\net8.0-windows\publish\win-x64\Releases\releases.win.json" | ConvertFrom-Json
$latestVersion = $json.Assets[0].Version

$version = Read-Host "Inserisci numero di versione (ultima ver. "$latestVersion")"

if (-not $version) {
    Write-Host "Versione non valida. Annullato."
    exit
}

#$version = "2.0.2"

##########################
# FUNZIONI
##########################

function Publish-App {
    param (
        [string]$repoUrl,
        [string]$projectPath,
        [string]$exeName,
        [string]$packId,
        [string]$packTitle,
        [string]$iconPath
    )

    $outputFolder = "$projectPath\bin\Release\net8.0-windows\publish\win-x64"

    Write-Host "`n=== DOTNET PUBLISH -> $packTitle ==="

    dotnet publish "$projectPath" `
        --framework net8.0-windows `
        --runtime win-x64 `
        --self-contained true `
        --output $outputFolder `
        --nologo

    if ($LASTEXITCODE -ne 0) {
        Write-Host "ERRORE durante la pubblicazione di $packTitle! Annullato."
        exit
    }

    Write-Host "`n=== VELOPACK PACK -> $packTitle ==="

    cd $outputFolder

    vpk pack `
        --packId $packId `
        --packVersion $version `
        --packDir . `
        --packAuthors "Filippo Battaglin" `
        --packTitle $packTitle `
        --mainExe $exeName `
        -i $iconPath `
        --exclude '(^|/|\\)(Releases|cs|de|es|fr|ja|ko|pl|pt-BR|ru|tr|zh-Hans|zh-Hant)(/|\\).*' `
        --noPortable

    Write-Host "`n=== VELOPACK UPLOAD -> $packTitle ==="

    vpk upload github `
        --repoUrl $repoUrl `
        --token $oauth `
        --publish

    cd $projectPath
}

##########################
# ESECUZIONE COMPLETA
##########################

# FrontOffice
Publish-App -repoUrl $foRepoUrl -projectPath $foProjectPath -packId $foPackId -packTitle $foPackTitle -exeName $foExeName -iconPath $foIconPath

# BackOffice
Publish-App -repoUrl $boRepoUrl -projectPath $boProjectPath -packId $boPackId -packTitle $boPackTitle -exeName $boExeName -iconPath $boIconPath

Write-Host "`n=========================================="
Write-Host " VERSIONE $version RILASCIATA PER FO + BO "
Write-Host "=========================================="