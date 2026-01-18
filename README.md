# GymClassManager

Aplicación de escritorio desarrollada en **C# (.NET – Windows Forms)** para la gestión administrativa de un gimnasio.  
El sistema está pensado para un **usuario administrador único**, en un entorno interno y controlado, y permite administrar **clases, horarios, inscriptos y profesores** aplicando reglas de negocio claras.

---

##  Contexto y objetivo

GymClassManager fue diseñado como un sistema administrativo realista, enfocado en:
- claridad de dominio
- separación de responsabilidades
- reglas de negocio explícitas
- mantenibilidad del código

No es una aplicación orientada al usuario final, sino a la **gestión interna** del gimnasio.

---

##  Arquitectura

El proyecto está organizado en una **arquitectura en capas**, separando responsabilidades de forma explícita:

- **Entity** → Modelos del dominio  
- **Data** → Acceso a datos (SQL Server)  
- **Business** → Reglas de negocio  
- **Mapper** → Mapeo entre Data y Entity  
- **UI** → Windows Forms (presentación)

Esta separación permite:
- aislar la lógica de negocio
- facilitar mantenimiento y refactor
- evitar dependencias innecesarias entre capas

---

##  Modelo de dominio (resumen)

- **Clase**
  - Disciplina
  - Cupo máximo
  - Cuota mensual
  - Relación con inscriptos
- **Detalle de Clase**
  - Día
  - Horario de inicio y fin
  - Profesor asignado
- **Inscripto**
  - Datos personales
  - Asociación a una única clase
- **Profesor**
  - Disciplina
  - Sueldo

Una clase puede tener **múltiples detalles** (por ejemplo, distintos días y horarios), lo que evita simplificaciones incorrectas del dominio.

---

##  Funcionalidades principales

### Gestión de Inscriptos
- Alta, baja y modificación
- Asignación y reasignación de clase
- Listado completo
- Listado por clase
- Listado de inscriptos sin clase

### Gestión de Clases
- Alta, baja y modificación
- Control de cupo máximo
- Visualización de cantidad de inscriptos
- Filtro por disciplina
- Detalle de clase con horarios y profesores

### Gestión de Profesores
- Alta, baja y modificación
- Asociación a una disciplina
- Filtro por actividad

---

##  Autenticación y roles

La aplicación **no implementa login ni roles**.

Esto es una **decisión de diseño consciente**, ya que el sistema está pensado para:
- uso interno
- un único usuario administrador
- ejecución en un entorno físico controlado

La arquitectura permite incorporar autenticación en el futuro si el contexto lo requiere.

---

##  Persistencia de datos

- Base de datos: **SQL Server**
- Script de creación incluido: `GimnasioBD.sql`
- Acceso a datos encapsulado en la capa `Data`
- Uso de mappers para desacoplar entidades del modelo de datos

---

##  Ejecución del proyecto

1. Crear la base de datos en SQL Server utilizando `GimnasioBD.sql`
2. Configurar la cadena de conexión en `App.config`
3. Abrir la solución `TPFinal.sln`
4. Ejecutar el proyecto `TPFinal`

---

##  Estado del proyecto

El sistema es **funcional y estable**.  
Este repositorio representa una versión **curada para portfolio**, enfocada en mostrar:
- diseño
- arquitectura
- lógica de negocio

---

##  Documentación

Se incluye un **Manual de Usuario** en formato PDF con una descripción funcional del sistema y sus pantallas principales.

---

##  Tecnologías utilizadas

- C#
- .NET Framework
- Windows Forms
- SQL Server
- Git / GitHub

---

##  Autor

Proyecto desarrollado como parte de formación académica y adaptado posteriormente como proyecto de portfolio personal.
