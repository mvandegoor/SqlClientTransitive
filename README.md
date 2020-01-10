# SqlClient Transitive Reference Example

A Small Repro to validate transitive loading of Microsoft.Data.SqlClient.dll and SNI.dll from Library project to Consumer project.

Pre-Requisites:
- NuGet.exe v5.0+
- Microsoft.Data.SqlClient v1.0.19269.1+
- C++ Runtime

Steps:
1. Clone and build the project in VS 2019.
2. Run the Consumer app and validate connectivity to target SQL Server.
