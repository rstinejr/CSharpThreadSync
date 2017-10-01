# CSharpThreadSync

Demo of use of ManualResetEvent to synchornize between worker threads and main
thread in a .NET Core app.

The project can be built and tested from the command line, but there is also a Visual Studio solution file for it.

Created with dotnet 2.0.

Built on 64-bit Windows 10, with .NET Core, dotnet 2.0, VisualStudio 15.3.

To download .NET Core, see https://dot.net


# Build and run

To build and run from the command line:

1. ```pushd ThreadSync```
2. ```dotnet restore```
3. ```dotnet build```
4. ```dotnet run```
5. ```popd```

Expected output from ```dotnet run``` is:

```
Demo of use of ManualResetEvent to synchronize with threads
withOUT wait, main thread accessed worker thread before it was ready.
WITH wait, no problem with accessing thread before appropriate.
Done.
```

To build tests and run them from the command line

1. ```pushd test```
2. ```dotnet restore```
3. ```dotnet build```
4. ```dotnet test```
5. ```popd```

All tests should pass:

```
Total tests: 2. Passed: 2. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 1.1611 Seconds
```

As an alternative to command line build and execution, if on Windows, you may
use the Visual Studio solution file to build the project and run the test.
