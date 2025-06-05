# Legitimate RAT - Una solución RAT legal y ética

[![Build status](https://ci.appveyor.com/api/projects/status/5857hfy6r1ltb5f2?svg=true)](https://ci.appveyor.com/project/MaxXor/quasar)
[![Downloads](https://img.shields.io/github/downloads/quasar/Quasar/total.svg)](https://github.com/quasar/Quasar/releases)
[![License](https://img.shields.io/github/license/quasar/Quasar.svg)](LICENSE)

**Herramienta de administración remota gratuita, legal y de código abierto para Windows**

Legitimate RAT es una herramienta de administración remota rápida y liviana programada en C#. Su uso abarca desde asistencia al usuario hasta tareas administrativas diarias y monitoreo de empleados. Al ofrecer una gran estabilidad y una interfaz fácil de usar, Legitimate RAT es la solución de administración remota perfecta para ti.

Consulta la guía de [Primeros Pasos](https://github.com/quasar/Quasar/wiki/Getting-Started).

## Capturas de pantalla

![remote-shell](Images/remote-shell.png)

![remote-desktop](Images/remote-desktop.png)

![remote-files](Images/remote-files.png)

## Características
* Transmisión de red TCP (soporte IPv4 e IPv6)
* Serialización de red rápida (Protocol Buffers)
* Comunicación cifrada (TLS)
* Soporte UPnP (apertura automática de puertos)
* Administrador de tareas
* Administrador de archivos
* Escritorio remoto
* Comandos de energía del sistema (Reiniciar, Apagar, Suspender)
* Detección de IA para prevenir usos malintencionados
* ... ¡y muchas más!

## Descarga
* [Última versión estable](https://github.com/quasar/Quasar/releases) (recomendada)
* [Instantánea de desarrollo más reciente](https://ci.appveyor.com/project/MaxXor/quasar)

## Entornos y sistemas operativos compatibles
* .NET Framework 4.5.2 o superior
* Sistemas operativos soportados (32 y 64 bits)
  * Windows 11
  * Windows Server 2022
  * Windows 10
  * Windows Server 2019
  * Windows Server 2016
  * Windows 8/8.1
  * Windows Server 2012
  * Windows 7
  * Windows Server 2008 R2
* Para sistemas antiguos utiliza [Legitimate RAT versión 1.3.0](https://github.com/quasar/Quasar/releases/tag/v1.3.0.0)

## Compilación
Abre el proyecto `LegitimateRAT.sln` en Visual Studio 2019+ con las características de desarrollo de escritorio .NET instaladas y [restaura los paquetes NuGET](https://docs.microsoft.com/en-us/nuget/consume-packages/package-restore). Una vez instalados todos los paquetes, el proyecto puede compilarse como de costumbre haciendo clic en `Build` o presionando `F6`. Los ejecutables resultantes se encuentran en el directorio `Bin`. Consulta más abajo qué configuración de compilación elegir.

## Construcción del cliente
| Configuración de compilación | Escenario de uso | Descripción
| -----------------------------|------------------|-------------
| Configuración Debug          | Pruebas          | Se utilizará el [Settings.cs](/Quasar.Client/Config/Settings.cs) predefinido, así que edita este archivo antes de compilar el cliente. Puedes ejecutar el cliente directamente con la configuración especificada.
| Configuración Release        | Producción       | Ejecuta `LegitimateRAT.exe` y utiliza el generador de cliente.

## Contribuciones
Consulta [CONTRIBUTING.md](CONTRIBUTING.md)

## Hoja de ruta
Consulta [ROADMAP.md](ROADMAP.md)

## Documentación
Consulta la [wiki](https://github.com/quasar/Quasar/wiki) para instrucciones de uso y otra documentación.

## Licencia
Legitimate RAT se distribuye bajo la [Licencia MIT](LICENSE).
Las licencias de terceros se encuentran [aquí](Licenses).

## ¡Gracias!
Aprecio todo tipo de comentarios y contribuciones. ¡Gracias por usar y apoyar Legitimate RAT!
