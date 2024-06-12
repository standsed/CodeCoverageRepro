Reproduces issue when in certain scenarios [codecoverage](https://github.com/microsoft/codecoverage) collector produces **cobertura** format output which later will produce duplicate line and branch coverage reports by [ReportGenerator](https://github.com/danielpalme/ReportGenerator)

```
rm -rf Repro.Tests/TestResults/
dotnet test Repro.Tests/Repro.Tests.csproj -c Release --collect "Code Coverage;Format=cobertura"
dotnet ~/.nuget/packages/reportgenerator/5.3.6/tools/net8.0/ReportGenerator.dll "-reports:./*/TestResults/*/*.cobertura.xml" "-targetdir:./coverage-report" "-reportTypes:Html"
```

![image](https://github.com/standsed/CodeCoverageRepro/assets/37961304/fe465c5c-a54e-4b90-a846-960f0680c0db)


```
rm -rf Repro.Tests/TestResults/
dotnet test Repro.Tests/Repro.Tests.csproj -c Release --collect "XPlat Code Coverage"
dotnet ~/.nuget/packages/reportgenerator/5.3.6/tools/net8.0/ReportGenerator.dll "-reports:./*/TestResults/*/*.cobertura.xml" "-targetdir:./coverage-report" "-reportTypes:Html"
```

![image](https://github.com/standsed/CodeCoverageRepro/assets/37961304/c01dbdba-1e66-4c7e-b1bf-423aace996e5)
