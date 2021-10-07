

Pasos
---
<br>

> Coger un archivo desde un input html de tipo file

> Recoger el archivo desde un metodo de Asp.net core Rest Api

> Vendra como stream del front, en el metodo de la api rest de asp.net core, ¿lo guardamos como archivo en una carpeta y utilizamos un fileSystemWatcher? Asi parece que soltaremos el proceso http y una vez guardado en una carpeta, un procesos en segundo plano bajo el asp.net core lo detectara y lo procesara (fileSytemWatcher) Comunicamos desde el proceso back en segundo plano al front(javascript) con signalR

> Creamos un worker o background  escuchando la carpeta con el filesystemWatcher y se dispara un evento diciendonos el archivo que se ha creado en la carpeta

> Tendremos un metodo desde el worker o tarea en segundo plano, donde recogeremos los datos de un archivo y dicho archivo excel lo importaremos, lo pasaremos a una lista desde el worker o background (Tarea en segundo plano, bajo demanada o reactivo con el filesystemwatcher, nada de cada minuto lanzando algo para comprobar como el hangfire, eso no, ineficiente, si lo hacemos, como ultimo recurso)

> Para comunicar cambios del back al front utilizar una libreria llamada SinalIr de Asp.net core.


<br>
Cosas a buscar
---
- [x] Subir un archivo desde React a Asp.net Core Web Api
- [x] Recoger un archivo desde un Asp.net Core Web Api
- [ ] Manejar Eventos personalizados (no necesario)
- [x] Grabar un archivo desde un Asp.net Core Web Api
- [ ] Manejar procesos con task parallel (tal vez no necesario)
- [ ] Importar un archivo excel desde un Asp.net Core web api
- [x] Worker,Background en Asp.net Core
- [x] File-Watcher en .net core C#
- [ ] Analizar como sube archivos AdA
- [ ] Agregar signalR
- [ ] Gestion de posibles errores




# *Creacion de una We api net core*

### - Creación de una API web con ASP.NET Core

https://docs.microsoft.com/es-es/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio-code


# *Manejar Eventos personalizados*
### - Reactive Extensions (Rx) - Part 2 - Wrapping C# Events

https://rehansaeed.com/reactive-extensions-part2-wrapping-events/

### - C# Event Example: EventHandler

https://thedeveloperblog.com/event

___
# *Importar datos de Excel*

### - How to Import data from Excel File to Database Table in ASP.NET Core

https://www.youtube.com/watch?v=5KNIpKcTIVs

### - Import Excel data in Sql server database in ASP.NET Core MVC using OleDb

https://qawithexperts.com/article/asp-net/import-excel-data-in-sql-server-database-in-aspnet-core-mvc/299

### - Read Excel File in WEB API using C#
https://www.c-sharpcorner.com/article/read-excel-file-in-web-api-using-c-sharp/

<pre>
Paquete nuget ExcelDataReader.DataSet
</pre>
### - Read and Write Excel file in C# .NET Core using NPOI

https://www.thecodebuzz.com/read-and-write-excel-file-in-net-core-using-npoi/
___
# *Subir Archivos con ASP.NET core con Web Api*

### - Upload/ Download Files In ASP.NET Core 2.0

https://www.c-sharpcorner.com/article/upload-download-files-in-asp-net-core-2-0/

### - How to Upload Files in .NET core Web API and React

https://sankhadip.medium.com/how-to-upload-files-in-net-core-web-api-and-react-36a8fbf5c9e8


___

# *Procesos en segundo plano (BackGround,Worker)*
### - Parallel Foreach async in C#
https://scatteredcode.net/parallel-foreach-async-in-c/
<pre>
Paralelizar operaciones para aprovechar varios procesadores de una lista de objetos numerosa
</pre>



### - Tareas en segundo plano con servicios hospedados en ASP.NET Core

https://docs.microsoft.com/es-es/aspnet/core/fundamentals/host/hosted-services?view=aspnetcore-5.0&tabs=visual-studio



### - Access Background Services From ASP.NET Core
https://khalidabuhakmeh.com/access-background-services-from-aspnet-core
<pre>
Como llamar a un metodo del worker asincronicamente desde http desde la rest api
Interesante porque aparte de ser procesos en segundo planto de les puede hacer una llamada desde ajax a traves de un metodo controller en http.
</pre>

<br>



### - Using FileSystemWatcher with NET Core 3.0

https://www.c-sharpcorner.com/blogs/using-filesystemwatcher-with-net-core-30

___
# *Libreria Estandar FileSystemWatcher*

### - FileSystemWatcher in an AspNetCore 2.1 BackgroundService\IHostedService

https://stackoverflow.com/questions/53637364/filesystemwatcher-in-an-aspnetcore-2-1-backgroundservice-ihostedservice

### - Working with the FileSystemWatcher in .NET

https://www.codeguru.com/csharp/.net/net_general/working-with-the-filesystemwatcher-in-.net.html

### - SignalR y SqlDependency - Notificando cambios de SQL Server a tus usuarios | ASP.NET Core 2.1

https://www.youtube.com/watch?v=JBhVpfb1LhU

___
# *Libreria SignalR (WebSocket)*
### - Transporte en SignalR: Long Polling - Server-Sent Events - Websockets | ASP.NET Core 2.1

https://www.youtube.com/watch?v=YkR0FE3sVfw

# Configuracion sonar cube

sonar-scanner.bat -D"sonar.projectKey=andrespallares_prueba33" -D"sonar.sources=." -D"sonar.host.url=http://localhost:9000" -D"sonar.login=6dfff1b7bf707c0850519935a1513522084badf0"




