CUSTOMER ONBOARDING & REGISTRATION SYSTEM - RUN MANUAL

This system is built using Clean Architecture principles with a C# .NET 
backend and a React frontend. The application features automatic SQLite 
database configuration, input validation, an HTML canvas electronic 
signature pad, and interactive API documentation via Scalar.

------------------------------------------------------------------------
1.RUNNING THE BACKEND (.NET API)
------------------------------------------------------------------------

System Requirements:
- Visual Studio 2022
- .NET 9.0.0 SDK
- Database: Embedded SQLite (Zero setup required)

Execution Steps:
1. Open File Explorer, navigate to 'CustomerOnboardingSolution' and open 
   the solution file (.sln) in Visual Studio 2022.
2. In the Solution Explorer, right-click 'CustomerOnboarding.Api' and 
   select 'Set as Startup Project'.
3. Press F5 (or click the Debug/Play button) to run the API.
4. Ensure the application launches securely using the HTTPS protocol.
   (Example port target: https://localhost:7190)

Database Provisioning Note:
The database file (customers.db) is created automatically on the first 
run. No external engine installations, scripts, or migrations are required.

Interactive API Documentation (Scalar):
Once the backend is active, you can test endpoints and inspect the 
database directly in your web browser by navigating to:
https://localhost:[YOUR_PORT_NUMBER]/scalar/v1
(e.g., https://localhost:7190/scalar/v1)

