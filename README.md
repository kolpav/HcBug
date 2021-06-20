Bug: `The root type Query has already been registered.`

Repro: `docker-compose up --build`

Fix: `ASPNETCORE_ENVIRONMENT: Production` in `docker-compose.yml`
