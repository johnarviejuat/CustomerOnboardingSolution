========================================================================
CUSTOMER ONBOARDING & REGISTRATION SYSTEM - RUN MANUAL
========================================================================

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

------------------------------------------------------------------------
2.RUNNING THE FRONTEND (REACT UI)
------------------------------------------------------------------------

System Requirements:
- Node.js (v18+ recommended)
- npm package manager

Execution Steps:
1. Open a command prompt or terminal window.
2. Navigate directly to the frontend folder directory:
   cd frontend
3. Install the application dependencies:
   npm install
4. Start the local Vite development web server:
   npm run dev
5. Open the browser to the local address provided in the console 
   (typically http://localhost:5173).

CRITICAL: Environment Variable Match (.env)
The frontend relies on an environment configuration file to locate your 
backend service without using browser local storage.

1. Open the file named '.env' inside the root of your 'frontend' folder.
2. Make sure the 'VITE_API_BASE_URL' port matches your running Visual 
   Studio HTTPS port number exactly:
   VITE_API_BASE_URL=https://localhost:[YOUR_BACKEND_PORT_NUMBER]

The backend API project must be kept running in the background for the 
frontend onboarding form to submit data and load the customer directory successfully.
========================================================================
