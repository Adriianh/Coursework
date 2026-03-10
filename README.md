# University Coursework - C# Projects

This repository contains all my programming assignments and laboratory activities developed in **C#** using the **.NET SDK**.

Este repositorio contiene todas mis tareas de programación y actividades de laboratorio desarrolladas en **C#** utilizando el **SDK de .NET**.

---

## Project Structure / Estructura del Proyecto

The repository is organized as a **Monorepo**, where each activity is an independent project within the same solution.

El repositorio está organizado como un **Monorepo**, donde cada actividad es un proyecto independiente dentro de la misma solución.

| Activity / Actividad | Description / Descripción | Status / Estado |
| :--- | :--- | :--- |
| **Actividad10** | Description of task 10 / Descripción de la tarea 10 | ✅ Done |
| **Actividad11** | Description of task 11 / Descripción de la tarea 11 | ✅ Done |

---

## How to Run / ¿Cómo Ejecutar?

I have included cross-platform scripts to easily run any activity without typing long commands.

He incluido scripts multiplataforma para ejecutar fácilmente cualquier actividad sin escribir comandos largos.

### Linux & macOS
1. Give execution permissions / Dar permisos: `chmod +x run.sh`
2. Run the script / Ejecutar: `./run.sh`

### Windows
1. Right-click on `run.ps1` / Clic derecho en `run.ps1`.
2. Select **"Run with PowerShell"** / Seleccionar **"Ejecutar con PowerShell"**.

---

## How to Add a New Activity / ¿Cómo Añadir una Nueva Actividad?

1. Navigate to the root of the repository.
2. Create a new project using the .NET CLI:
    - `dotnet new console -o ActividadXX`
    - Replace `ActividadXX` with the activity name/number.
3. Add the new project to the solution:
    - `dotnet sln add ActividadXX/ActividadXX.csproj`
4. Update the table above with the new activity, its description, and status.
5. Implement your code in the new project folder.
6. Commit your changes with a descriptive message.

---

1. Ve a la raíz del repositorio.
2. Crea un nuevo proyecto con el CLI de .NET:
    - `dotnet new console -o ActividadXX`
    - Reemplaza `ActividadXX` por el nombre/número de la actividad.
3. Agrega el nuevo proyecto a la solución:
    - `dotnet sln add ActividadXX/ActividadXX.csproj`
4. Actualiza la tabla de arriba con la nueva actividad, su descripción y estado.
5. Implementa tu código en la nueva carpeta del proyecto.
6. Haz commit de tus cambios con un mensaje descriptivo.