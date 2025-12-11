$json = Get-Content -Raw -Path ".\bin\Release\net8.0-windows\publish\win-x64\Releases\releases.win.json" | ConvertFrom-Json
$latestVersion = $json.Assets[0].Version

$outputFolder = '.\bin\release\net8.0-windows\publish\win-x64'
$version = Read-Host "Inserisci numero di versione (ultima ver. "$latestVersion")"
$oauth = Get-Content -Path "C:\Users\fil\Desktop\github_token_velopack.txt" -TotalCount 1

# Pubblico il progetto Crediti
"=== PUBBLICAZIONE ==="
dotnet publish `
    --framework net8.0-windows `
    --nologo `
    --output $outputFolder `
    --self-contained true `
    --runtime win-x64

"`r`n"

# Cambio la workdir
cd $outputFolder

# Eseguo il pack della release con Velopack
"=== PACKING ==="
vpk pack `
    --packId FilBatta.Crediti `
    --packVersion $version `
    --packDir . `
    --packAuthors "Filippo Battaglin" `
    --packTitle Crediti `
    -i C:\Users\fil\Desktop\Progetti\Crediti\crediti_icon.ico `
    --mainExe Crediti.exe `
    --exclude '(^|/|\\)(Releases|cs|de|es|fr|ja|ko|pl|pt-BR|ru|tr|zh-Hans|zh-Hant)(/|\\).*' `
    --noPortable

"`r`n"

# Eseguo l'upload dell'aggiornamento su GitHub Releases con Velopack
"=== UPLOAD ==="
vpk upload github `
    --repoUrl https://github.com/Fil0611/Crediti `
    --token $oauth `
    --publish

#$cinghi = Read-Host 'Inserisci nome'
#Write-Host $cinghi

Write-Host "=== VERSIONE" $version "RILASCIATA ==="