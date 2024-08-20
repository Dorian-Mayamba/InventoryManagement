@echo off
REM This script removes Entity Framework Core migrations in a loop
REM until no migrations are left or until a specific migration is reached.

REM Specify a target migration to stop at (optional)
set target_migration=

:loop
REM Get the latest migration name
for /f "tokens=*" %%i in ('dotnet ef migrations list ^| findstr /r /c:"\b[0-9]\{14\}\b"') do set "latest_migration=%%i"
set latest_migration=%latest_migration:~0,-1%

REM Check if a migration name was found
if "%latest_migration%"=="" (
    echo No more migrations to remove.
    goto end
)

echo Latest migration found: %latest_migration%

REM Check if we've reached the target migration
if not "%target_migration%"=="" (
    if "%latest_migration%"=="%target_migration%" (
        echo Reached the target migration: %target_migration%.
        goto end
    )
)

REM Remove the latest migration
echo Removing the latest migration: %latest_migration%...
dotnet ef migrations remove --force

REM Pause to allow for manual verification (optional)
REM pause

REM Loop again
goto loop

:end
echo All specified migrations have been removed.
pause
