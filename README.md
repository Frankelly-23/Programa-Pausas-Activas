# Programa de Pausas Activas

Software ergonomico de escritorio desarrollado en Windows Forms (.NET) como proyecto academico de la asignatura **Ergonomia y Factores Humanos** en la **Universidad Central del Este (UCE)**.

## Descripcion

Este programa tiene como objetivo promover habitos saludables en personas que trabajan largas horas frente a una computadora. La aplicacion ofrece cuatro modulos independientes que abordan distintos aspectos de la salud ocupacional:

- **Temporizadores y Alertas**: Permite configurar recordatorios periodicos para tomar pausas activas durante la jornada laboral. El usuario puede ajustar intervalos y recibir notificaciones visuales y sonoras.

- **Prevencion Osteomuscular**: Presenta ejercicios de estiramiento guiados con imagenes paso a paso, organizados por zona del cuerpo (cuello, espalda y muneca). Incluye notificaciones sonoras al cambiar de ejercicio.

- **Salud Mental**: Ofrece tres tipos de ejercicios de bienestar cognitivo: relajacion, enfoque y recuperacion. Cada uno incluye guias de respiracion con animaciones visuales y sonidos ambientales opcionales (campanas, lluvia, naturaleza).

- **Anti-Sedentarismo**: Modulo de hidratacion y movimiento activo. Permite llevar un registro de vasos de agua consumidos con una meta diaria configurable, y configurar alertas de inactividad para recordar al usuario levantarse y moverse.

El menu principal muestra estadisticas de uso por modulo (cantidad de sesiones, modulo mas utilizado, ultimo acceso) y permite abrir varios modulos simultaneamente.

Todos los modulos guardan su estado en archivos JSON locales, de modo que al cerrar y reabrir la aplicacion se restaura el progreso del usuario.

## Tecnologias

- C# / .NET 10
- Windows Forms
- Guna UI2 (componentes visuales)
- NAudio (reproduccion de audio)
- System.Text.Json (persistencia de datos)

## Equipo de desarrollo

Este proyecto fue desarrollado por 9 estudiantes, divididos en equipos por modulo:

| Modulo | Integrantes | GitHub |
|--------|------------|--------|
| Temporizadores y Alertas | Adelin, Lusiany | [@adelinvm07](https://github.com/adelinvm07), [@Lusi0027](https://github.com/Lusi0027) |
| Prevencion Osteomuscular | Angel, Carlos | [@angelHG1](https://github.com/angelHG1), [@CarlosMC-code](https://github.com/CarlosMC-code) |
| Salud Mental | Katherine, Robert | [@Katherine-Ramirez-beep](https://github.com/Katherine-Ramirez-beep) |
| Anti-Sedentarismo | Joleyby, Winnifer | [@joleyby](https://github.com/joleyby) |
| Menu principal, estadisticas e integracion | Frankelly | [@Frankelly-23](https://github.com/Frankelly-23) |

Todos los integrantes son estudiantes de Ingenieria de Software, excepto Winnifer que estudia Ingenieria Industrial y estuvo a cargo del diseno visual de la aplicacion.

## Como ejecutar

### Opcion 1: Ejecutable directo

Descargar `Programa-Pausas-Activas.exe` desde la seccion de Releases. No requiere instalacion ni dependencias, funciona en cualquier PC con Windows 10/11.

### Opcion 2: Desde el codigo fuente

```bash
dotnet run
```

### Opcion 3: Generar el ejecutable

```bash
dotnet publish -c Release
```

El archivo se genera en `bin\Release\net10.0-windows\win-x64\publish\Programa-Pausas-Activas.exe`.

## Estructura del proyecto

```
Programa-Pausas-Activas/
  MainForm.cs                    -- Menu principal y estadisticas
  MainForm.Designer.cs           -- Diseno del menu principal
  Program.cs                     -- Punto de entrada
  forms.csproj                   -- Configuracion del proyecto
  images/                        -- Logo UCE
  Data/                          -- Datos de persistencia (JSON)
  modulos/
    TemorizadoresForm.cs         -- Modulo de temporizadores
    OsteoForm.cs                 -- Modulo osteomuscular
    SaludMentalForm.cs           -- Modulo de salud mental
    SedentarismoForm.cs          -- Modulo anti-sedentarismo
    SaludMental/                 -- Subformularios de salud mental
    ImagenesOsteo/               -- Imagenes de ejercicios
    Sedentarismo/                -- Recursos del modulo sedentarismo
    Sonidos/                     -- Archivos de audio
```

## Licencia

Proyecto academico - Universidad Central del Este (UCE), 2025.
