@ECHO off

ECHO What test would you like to run?
ECHO 1 - All
ECHO 2 - Regression only
SET /p choice= "Enter a number from the options above here: " 

IF %choice%==1 (
	.\..\packages\NUnit.ConsoleRunner.3.9.0\tools\nunit3-console.exe  .\bin\Debug\SpecflowCmdUnitTestProject.dll --work=.\..\TestResults\
) else (
	.\..\packages\NUnit.ConsoleRunner.3.9.0\tools\nunit3-console.exe  .\bin\Debug\SpecflowCmdUnitTestProject.dll --where=cat==regression --work=.\..\TestResults\
)

PAUSE 