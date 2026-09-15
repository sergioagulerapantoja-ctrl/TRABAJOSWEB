# TRABAJOSWEB

Solución de Microsoft Visual Studio con una aplicación ASP.NET Core Razor Pages para administrar héroes y superpoderes.

## Requisitos

- Visual Studio compatible con .NET 10 y la carga de trabajo **ASP.NET y desarrollo web**.
- .NET SDK 10.
- SQL Server disponible como `SERGIO`.
- Base de datos `HeroesDb` accesible mediante autenticación de Windows.

## Ejecutar en Visual Studio

1. Abra `TRABAJOSWEB.sln`.
2. Establezca `HeroesWeb` como proyecto de inicio si Visual Studio no lo selecciona automáticamente.
3. Seleccione el perfil `https`.
4. Presione **F5** para depurar o **Ctrl+F5** para ejecutar sin depuración.
5. Use el menú **Héroes** o **Superpoderes**.

La aplicación usa esta conexión:

```text
Server=SERGIO;Database=HeroesDb;Trusted_Connection=True;TrustServerCertificate=True;
```

## Arquitectura de datos

El proyecto usa Entity Framework Core 10 con enfoque **Database First**. `HeroesContext` y los modelos de `Models` se generaron mediante ingeniería inversa. No utiliza migraciones ni Code First.

Para volver a generar el contexto y los modelos después de un cambio en la base de datos, ejecute desde `HeroesWeb`:

```powershell
dotnet ef dbcontext scaffold "Server=SERGIO;Database=HeroesDb;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer --context HeroesContext --context-dir Data --output-dir Models --no-onconfiguring --no-pluralize --data-annotations --force
```

## Compilar la solución

```powershell
dotnet restore TRABAJOSWEB.sln
dotnet build TRABAJOSWEB.sln
```
