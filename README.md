Distance Calc
========================

To run, clone the repo locally and run:
`docker compose build`
followed by
`docker compose up api -d`
(you need docker installed first obvs)

This will start the service which you can browse to at `http://localhost:5075/swagger`.

You can run the integration tests with `docker compose up integration-tests`. This will run against the running service so you need that done first. 
You'll see a line in the output like:
`Passed!  - Failed:     0, Passed:     2, Skipped:     0, Total:     2, Duration: 196 ms - /app/Tests.Api.dll (net6.0)`
which means all 2(!) of the integration tests have run.

It's the same for the unit tests, except the command is `docker compose up unit-tests` and it's not necessary to have the service running for those.

This repo only allows pushes on branches that aren't the `main` branch and merges must have a PR.