#!/bin/bash

echo "--- UniversityProjects Runner (Unix) ---"

projects=($(find . -name "*.csproj"))

if [ ${#projects[@]} -eq 0 ]; then
    echo "❌ No se encontraron proyectos de C#."
    exit 1
fi

echo "Selecciona la actividad que deseas ejecutar:"
select opt in "${projects[@]}" "Salir"; do
    case $opt in
        "Salir")
            break
            ;;
        *)
            if [ -n "$opt" ]; then
                echo "Ejecutando: $opt..."
                dotnet run --project "$opt"
                break
            else
                echo "Opción inválida."
            fi
            ;;
    esac
done
