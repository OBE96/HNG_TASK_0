# HNG_TASKZERO

Description
This is a simple ASP.NET Core Web API that returns a JSON response containing an email, the current datetime in UTC (ISO 8601 format), and a GitHub URL. The API is designed to handle GET requests and is configured to support Cross-Origin Resource Sharing (CORS) to allow requests from different origins.

Key Features

GET Endpoint: Returns a JSON response with the following structure:
![h1](https://github.com/user-attachments/assets/94655d5e-8c32-4365-9d17-ecb28c7a217e)

Dynamic Datetime: The current_datetime field is dynamically generated in ISO 8601 format (UTC).

CORS Support: The API is configured to allow requests from all origins by default. You can customize the CORS policy to restrict access to specific origins if needed.

Setup Instructions

Follow these steps to set up and run the project locally.

Prerequisites
.NET SDK (version 6.0 or later) installed on your machine.

Steps to Run the Project

Clone the Repository:
bash
Copy
git clone https://github.com/yourusername/your-repo.git
cd your-repo

Build the Project:
Run the following command to restore dependencies and build the project:
bash
Copy - dotnet build

Run the Application:
Start the API using the following command:

bash
Copy
dotnet run
Access the API:

The API will be available at http://localhost:5000/my (or https://localhost:5001/my if using HTTPS).

You can test the API using a browser, Postman, or any HTTP client.

API Documentation

Endpoint
[GET /my](https://localhost:7291/api/HNGTASKZERO)

Request
No request body or parameters are required.

Response
Status Code: 200 OK

Response Format:

json
Copy
{
  "email": "your-email@example.com",
  "current_datetime": "2025-01-30T09:30:00Z",
  "github_url": "https://github.com/yourusername/your-repo"
}
Example Usage
1. Send a GET request to http://localhost:5000/my.

2.You will receive the following response:

json
Copy
{
  "email": "your-email@example.com",
  "current_datetime": "2025-01-30T09:30:00Z",
  "github_url": "https://github.com/yourusername/your-repo"
}

BackLink
https://hng.tech/hire/csharp-developers
