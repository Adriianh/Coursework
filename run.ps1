Write-Host "--- UniversityProjects Runner (Windows) ---" -ForegroundColor Cyan

$projects = Get-ChildItem -Filter *.csproj -Recurse

if ($projects.Count -eq 0) {
    Write-Host "❌ No se encontraron proyectos de C#." -ForegroundColor Red
    return
}

for ($i = 0; $i -lt $projects.Count; $i++) {
    Write-Host ("[" + ($i + 1) + "] " + $projects[$i].FullName.Replace($(Get-Location).Path, ""))
}

$choice = Read-Host "Selecciona el número de la actividad"

if ($choice -gt 0 -and $choice -le $projects.Count) {
    $selectedProject = $projects[$choice - 1].FullName
    Write-Host "Ejecutando: $selectedProject..." -ForegroundColor Green
    dotnet run --project $selectedProject
} else {
    Write-Host "Opción inválida." -ForegroundColor Red
}
