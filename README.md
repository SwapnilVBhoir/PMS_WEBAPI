# PMS_WEBAPI

A simple .NET 8 Web API sample project with an in-memory patient service.

## Features
- .NET 8 Web API
- PatientsController with GET and POST endpoints
- In-memory `PatientService`
- Swagger (Swashbuckle) enabled
- CORS enabled for `http://localhost:4200`
- GitHub Actions workflow to build and test on push

## Run locally

1. Ensure you have .NET 8 SDK installed: https://dotnet.microsoft.com/en/download
2. From the project root:
```bash
dotnet restore
dotnet build
dotnet run
```

By default the app will listen on the URLs shown in the console. Swagger UI (in Development) will be available at:
```
https://localhost:5001/swagger/index.html
```

## API Endpoints

- `GET /api/patients` - list patients
- `GET /api/patients/{id}` - get patient by id
- `POST /api/patients` - create a new patient (JSON body)

## Init Git and push to GitHub

```bash
git init
git add .
git commit -m "Initial commit - PMS_WEBAPI"
# create repo on GitHub and then:
git remote add origin https://github.com/<your-username>/PMS_WEBAPI.git
git branch -M main
git push -u origin main
```

## GitHub Actions

See `.github/workflows/dotnet.yml` in this repo for CI that runs `dotnet build` and `dotnet test`.
