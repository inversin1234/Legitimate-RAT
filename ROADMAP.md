# Hoja de ruta de Legitimate RAT

## Web API
Una API web (por ejemplo de estilo REST) permite interactuar con los clientes de forma más flexible y puede usarse para crear una interfaz web para Legitimate RAT.

## Transparent communication protocol
Para abrir la puerta a clientes de Legitimate RAT en distintos lenguajes de programación, el protocolo de comunicación debe estar claramente especificado y documentado.

## Cross-platform support
A long-term goal is to support operating systems such as MacOS and Linux. The new .NET Core framework will help achieve this goal.

## Command line (CLI) version of the server
It should be possible to use the server as a simple CLI tool to accept and forward (proxy) connections to other servers.

## GUI overhaul
The GUI needs to be reworked in a more modern way, such as WPF or a web-based interface. WPF as GUI framework would drastically improve rendering performance of the remote desktop with the hardware accelerated rendering, similar to a web-based GUI depending on the used browser.

## Allow different types of clients (permissioned clients)
Allow clients with higher privileges (i.e. ability to administrate other lower privileged clients) connect to the server. This change would allow administrators to manage clients from their own computers with a lightweight client without having to run the server.

## Allow client installation as Windows service
Actualmente el cliente se instala por usuario, lo cual dificulta administrar la máquina de forma remota cuando el usuario no ha iniciado sesión. También requiere instalar el cliente para cada cuenta que utiliza el equipo. Los equipos usados por varios usuarios se beneficiarían enormemente si Legitimate RAT pudiera ejecutarse como un servicio de Windows.

## Basic client GUI
Add a basic GUI to the client to allow the user at any time to check the status if a specific feature is active. Additionally it can show a notification when the client gets installed or when someone requests permission to use remote desktop (similar to teamviewer).
