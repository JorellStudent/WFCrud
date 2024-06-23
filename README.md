# Proyecto .NET: Gestión de Productos

Este proyecto consiste en el desarrollo de una aplicación de Windows Forms (winforms) utilizando ASP.NET Core 8 y Entity Framework Core. La aplicación se conectará a una base de datos para gestionar una tabla de "Productos".

## Contenido

- [Objetivos de la Unidad](#objetivos-de-la-unidad)
- [Instrucciones Generales](#instrucciones-generales)
- [Requisitos del Programa](#requisitos-del-programa)
- [Evaluación](#evaluación)
- [Nota](#nota)
- [Desarrollo del Proyecto](#desarrollo-del-proyecto)
  - [Paso 1: Sincronizar el Modelo de Datos](#paso-1-sincronizar-el-modelo-de-datos)
  - [Paso 2: Generar el Modelo de Datos](#paso-2-generar-el-modelo-de-datos)
  - [Paso 3: Crear el Proyecto ASP.NET Core 8](#paso-3-crear-el-proyecto-aspnet-core-8)
  - [Paso 4: Generar la Interfaz Gráfica](#paso-4-generar-la-interfaz-gráfica)
- [Creación de la Base de Datos](#creación-de-la-base-de-datos)

## Objetivos de la Unidad

Desarrollar un software con ASP.NET Core 8 y Windows Forms (winforms) que se conecte a la base de datos facilitada mediante Entity Framework Core.

## Instrucciones Generales

1. **Sincronización del Modelo de Datos**: Utilizar MySQL Workbench para sincronizar el modelo de datos.
2. **Generación del Modelo de Datos**: Generar el modelo de datos utilizando Entity Framework Core.
3. **Generación del Software**: Crear el software ASP.NET Core 8 con el comando `dotnet new winforms`.
4. **Interfaz Gráfica**: Utilizar SWD4CS para generar la interfaz gráfica en Visual Studio Code.

## Requisitos del Programa

La aplicación debe cumplir con los siguientes requerimientos:

1. **Listado de Productos** 
   - Listar todos los productos que actualmente tenga la base de datos.

2. **Agregar Nuevos Productos** 
   - Crear un formulario que permita agregar nuevos productos.
   - Los campos requeridos son: nombre, descripción y precio.
   - El campo `IdProducto` no es necesario ya que es auto incrementable.
   - Al guardar, la fecha de creación debe ser `DateTime.Now`.

3. **Editar Información de un Producto** 
   - Crear un formulario para editar la información de un producto utilizando el campo `idProducto`.
   - Los campos editables son: nombre, descripción y precio.
   - Al guardar, la información debe actualizarse en la base de datos y la fecha de creación debe ser `DateTime.Now`.

4. **Eliminar un Producto** 
   - Crear un formulario que permita eliminar un producto especificando el `idProducto`.
   - Incluir un botón que, al ser presionado, elimine el producto con el `idProducto` indicado.

## Evaluación

- **Asignatura**: Programación .NET 

## Nota

- Asegúrate de que todos los formularios funcionen correctamente y se conecten a la base de datos usando Entity Framework Core.
- La fecha de creación debe registrarse con el valor `DateTime.Now` en todos los casos de creación y edición de productos.

---

## Desarrollo del Proyecto

### Paso 1: Sincronizar el Modelo de Datos

Utiliza MySQL Workbench para sincronizar y visualizar la estructura de la tabla "Productos".

### Paso 2: Generar el Modelo de Datos

Utiliza Entity Framework Core para generar el modelo de datos a partir de la base de datos.

### Paso 3: Crear el Proyecto ASP.NET Core 8

Ejecuta el comando `dotnet new winforms` para crear un nuevo proyecto de Windows Forms.

### Paso 4: Generar la Interfaz Gráfica

Utiliza SWD4CS para generar la interfaz gráfica del proyecto en Visual Studio Code.

## Creación de la Base de Datos

![image](https://github.com/JorellStudent/WFCrud/assets/167504858/1697d040-8e82-4001-a590-7db2f799bcce)

Para crear la base de datos y la tabla `Productos`, utiliza las siguientes instrucciones SQL:

```sql
-- Crear la base de datos Inventario
CREATE DATABASE IF NOT EXISTS Inventario;

-- Usar la base de datos Inventario
USE Inventario;

-- Crear la tabla Productos con los campos IdProducto, Nombre, Descripcion y Precio
CREATE TABLE IF NOT EXISTS Productos (
    IdProducto INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(500) NOT NULL,
    Descripcion longtext,
    Precio INT NOT NULL,
    FechaCreacion DATETIME 
);
