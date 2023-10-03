# API-Rest-ASP.NET-SQLServer

Esta es una de las API de "CANDATA CUN" desarrollada en C#, ASP.NET y SQL Server que proporciona un servicio para GUARDAR la respuesta del Bot encargado de revisar la documentación de los candidatos (estudiantes) a Grado.

## Endpoints

- POST: https://localhost:7092/response/GuardarRespuestaBot
- GET: https://localhost:7092/response/GuardarRespuestaBot/candidatos
- GET: https://localhost:7092/response/GuardarRespuestaBot/1


## Ejecución del API

1. Clona el repositorio:
   ```bash
   git clone https://github.com/Alexis-Chavarria/API-Rest-ASP.NET-SQLServer.git

2. Navega al directorio del proyecto:
   ```bash
   cd ApiCandataCUN

4. Compila el proyecto
    ```bash
   dotnet build

6. ejecuta el proyecto
    ```bash
   dotnet run

## Tecnologías
- C#
- ASP.NET
- SQL Server
- Entity Framework Core
- LINQ
- Swagger
- Postman
- Git
- NuGet

## Principios y Características
- Principio de Separación de responsabilidades: cada componente tiene una unica responsabilidad
- Patrón MVC: Controllers - Models - Services - Data
- Inyeccion de dependencias
- Patron Repository
- Metodos: crearCandidato - obtenerCandidatoPorId - obtenerCandidatos
- Conexion Base de datos con Entity Framework Core
- Versionado con GIT


