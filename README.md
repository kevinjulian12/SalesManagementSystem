Sales Management System

Aplicación de escritorio desarrollada en C# y .NET Windows Forms, orientada a la gestión de usuarios y operaciones relacionadas con un sistema de ventas.

El proyecto fue desarrollado como una aplicación práctica para implementar conceptos de programación orientada a objetos, arquitectura por capas, acceso a datos, autenticación y persistencia en SQL Server.

🚀 Tecnologías utilizadas
C#
.NET / .NET Framework
Windows Forms
SQL Server
ADO.NET / Entity Framework
LINQ
MVC / arquitectura por capas
Git / GitHub
🔐 Autenticación

El sistema cuenta con un módulo de inicio de sesión para controlar el acceso a la aplicación.

Entre las funcionalidades se incluyen:

Login de usuarios
Validación de credenciales
Control de acceso
Manejo de sesiones
Validaciones de datos
Gestión de errores
📦 Funcionalidades
Gestión de usuarios
Autenticación
Gestión de clientes
Gestión de productos
Gestión de ventas
Persistencia de información
Consultas a base de datos
Validación de información
Manejo de excepciones
Operaciones CRUD
🏗️ Arquitectura

El proyecto está organizado buscando mantener una separación clara de responsabilidades entre las diferentes capas de la aplicación.

SalesManagementSystem
│
├── Presentation
│   └── Windows Forms
│
├── Business
│   └── Reglas de negocio
│
├── Data
│   └── Acceso a datos
│
├── Entities
│   └── Modelos
│
└── Database
    └── Scripts SQL

Esta separación permite facilitar el mantenimiento, testing y evolución de la aplicación.

🗄️ Base de datos

El sistema utiliza SQL Server para la persistencia de información.

La comunicación con la base de datos se realiza mediante una capa de acceso a datos, evitando mezclar directamente la lógica de persistencia con la interfaz gráfica.

Entre las operaciones implementadas se encuentran:

INSERT
UPDATE
DELETE
SELECT
Consultas parametrizadas
Procedimientos almacenados
🧩 Principales conceptos aplicados

Durante el desarrollo se trabajó con diferentes conceptos utilizados habitualmente en aplicaciones empresariales:

Programación Orientada a Objetos
Encapsulamiento
Separación de responsabilidades
Arquitectura por capas
Repository Pattern
Data Access Layer
Validaciones
Manejo de excepciones
Acceso a datos
CRUD
Consultas SQL
Autenticación de usuarios
▶️ Instalación
1. Clonar el repositorio
git clone https://github.com/kevinjulian12/WindowsForms-Login-ServicioDeVentas.git
2. Abrir el proyecto

Abrir la solución utilizando Visual Studio.

3. Configurar la base de datos

Ejecutar los scripts SQL incluidos en el proyecto para crear la estructura necesaria.

Luego configurar la cadena de conexión correspondiente al entorno local.

Ejemplo:

Server=localhost;
Database=SalesManagement;
Trusted_Connection=True;
4. Ejecutar

Compilar la solución y ejecutar el proyecto desde Visual Studio.

📸 Capturas
Login

Agregar aquí una captura de pantalla del formulario de inicio de sesión.

Gestión de ventas

Agregar aquí una captura de la pantalla principal o módulo de ventas.

Gestión de usuarios

Agregar aquí una captura del módulo de usuarios.

🎯 Objetivo del proyecto

El objetivo principal es demostrar la implementación de una aplicación de escritorio utilizando tecnologías del ecosistema Microsoft .NET, aplicando buenas prácticas de desarrollo, separación de responsabilidades y acceso estructurado a datos.

El proyecto también sirve como base para continuar incorporando nuevas funcionalidades y evolucionar progresivamente hacia arquitecturas más modernas.

🔮 Próximas mejoras

Implementar roles y permisos

Mejorar el sistema de autenticación

Incorporar logging

Agregar pruebas unitarias

Implementar Dependency Injection

Mejorar la interfaz de usuario

Incorporar reportes

Migrar progresivamente hacia una API REST

Incorporar una aplicación web utilizando ASP.NET Core

👨‍💻 Autor

Kevin Julián Gaitano

Desarrollador .NET | Backend | Full Stack
