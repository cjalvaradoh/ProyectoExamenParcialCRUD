# Proyecto CRUD - Evaluación Parcial

## Objetivo  
Este proyecto consiste en una aplicación de escritorio desarrollada en **C# con Windows Forms**, que permite realizar operaciones **CRUD (Crear, Leer, Modificar, Eliminar)** sobre la entidad `Producto`.  
Se aplica el patrón de diseño **Clean Architecture**, asegurando una separación clara entre las capas de presentación, lógica de negocio e infraestructura, lo cual facilita el mantenimiento y escalabilidad del software.

## Integrantes del equipo
- **Cesia**  
- **Maria**  
- **Alesandro**  

## Estructura del proyecto  
El proyecto está organizado siguiendo los principios de Clean Architecture, distribuyendo las responsabilidades en distintas capas:

- **Domain**: contiene la clase `Producto`, que representa la lógica del dominio.
- **Application**: incluye los casos de uso para la gestión de ventas y productos.
- **FormulariosVista**: contiene los formularios gráficos como `FrmProducto` y `MenuPrincipal`, que conforman la interfaz de usuario.

## Funciones del formulario de productos  
El formulario permite realizar operaciones básicas sobre productos, incluyendo:

- Crear un nuevo producto  
- Mostrar productos en una tabla  
- Modificar un producto seleccionado  
- Eliminar un producto  
- Limpiar los campos del formulario  

Todas estas funciones están conectadas con una lista de productos mantenida en memoria.

## Tecnología utilizada  
- **Lenguaje**: C# (.NET 8)  
- **Interfaz**: Windows Forms (WinForms)  
- **Arquitectura**: Clean Architecture  
- **IDE**: Visual Studio 2022  

## Instrucciones de uso  
1. Clonar el repositorio o descargar el código fuente.  
2. Abrir el archivo `.sln` con **Visual Studio**.  
3. Ejecutar el proyecto presionando `F5` o desde el menú `Depurar > Iniciar depuración`.  
4. Desde el menú principal, seleccionar la opción **Productos**.  
5. Usar los botones para **crear**, **modificar**, **eliminar** o **limpiar** productos.

## Estado del proyecto  
El formulario de productos se encuentra **completo y funcional**, con las operaciones CRUD correctamente implementadas.  
El diseño visual ha sido mejorado con una interfaz amigable, los eventos están correctamente enlazados, y la arquitectura del proyecto garantiza una buena separación de responsabilidades.

## Licencia  
Este es un proyecto académico desarrollado para la evaluación parcial del curso de **Ingeniería de Software**.  
Uso exclusivo para fines educativos.
