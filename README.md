
 

Etchart.JuanPablo.PrimerParcial

![Alt text](src/diagramaPrincipal.png)
![Alt text](src/diagramaCompleto.png)


Clases:
Las clases en este proyecto consisten en 4 partes principales. La primera es la Clase Deportista, la cual hereda a 3 clases: Atletismo, Voley y Escalada. Estas representan a los jugadores que pueden registrarse en la aplicación. La segunda parte consiste en los Usuarios, los cuales sirven para administrar quién accede a la aplicación y, según su jerarquía, podrán realizar distintas funciones. La tercera parte está basada en la clase Clasificación, la cual se encarga de agrupar a cada una de las clases de deportistas, ordenándolos y comparando sus valores para distribuirlos y mostrarlos. La última parte se encarga de traer y enviar los datos a través de una base de datos SQL Server, por ejemplo, los datos de usuarios y los datos de los deportistas.

Aplicación de Windows Form para Clasificación de Deportistas
Esta aplicación de Windows Form escrita en C# permite a los usuarios ingresar y clasificar deportistas en tres categorías: escalada, atletismo y vóley. La aplicación ofrece operaciones de Crear, Leer, Actualizar y Eliminar (CRUD) para gestionar la información de los deportistas.

Características
Agregar Deportistas: Los usuarios pueden ingresar información detallada sobre los deportistas, incluyendo nombre, apellido, edad, género, estado médico y si están federados. Además, se pueden proporcionar detalles específicos según el deporte.

Clasificar Deportistas: La aplicación clasifica automáticamente a los deportistas en una de las tres categorías según su deporte.

Visualizar Deportistas: Los usuarios pueden consultar una lista de deportistas clasificados por categoría.

Modificar Deportistas: Se proporciona la capacidad de editar la información de un deportista existente.

Eliminar Deportistas: Los usuarios pueden eliminar deportistas de la lista.

Requisitos del Sistema:
Sistema operativo Windows.
Entorno de desarrollo Microsoft Visual Studio con soporte para aplicaciones C#.
Servidor SQL Server.
Instrucciones de Uso:
Descarga o clona el repositorio desde GitHub y guárdalo en tu máquina local.
Abre el proyecto en Microsoft Visual Studio.
Ejecuta el script deportistas.sql en tu servidor SQL Server para crear la base de datos y las tablas necesarias.
Configura la cadena de conexión a la base de datos en las propiedades de la aplicación.
Compila y ejecuta la aplicación.
Sigue las instrucciones en la interfaz de Windows Form para agregar, clasificar, visualizar, modificar o eliminar deportistas.
Ahora, la aplicación utiliza una base de datos SQL Server en lugar de archivos para almacenar la información de los deportistas.