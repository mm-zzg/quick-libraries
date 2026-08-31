# quick-libraries

Native C libraries built for C# P/Invoke, targeting Linux, Windows, and macOS via GitHub Actions.

## Libraries

### quickmath

Simple arithmetic operations exposed as a shared library.

| Function | Signature |
|---|---|
| `add` | `int add(int a, int b)` |
| `subtract` | `int subtract(int a, int b)` |
| `multiply` | `int multiply(int a, int b)` |

## Building locally

Prerequisites: CMake 3.15+, a C compiler (GCC, Clang, or MSVC).

```bash
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build --config Release
```

The shared library will be placed in the `build/` directory.

## C# P/Invoke usage

Place the built shared library alongside your executable (or in a `runtimes/<rid>/native/` folder for NuGet packages), then use `DllImport`:

```csharp
using System.Runtime.InteropServices;

[DllImport("quickmath", CallingConvention = CallingConvention.Cdecl)]
public static extern int add(int a, int b);
```

See [`examples/csharp/Program.cs`](examples/csharp/Program.cs) for a complete example.

## CI

The GitHub Actions workflow (`.github/workflows/build.yml`) builds the libraries on every push/pull request and uploads platform-specific artifacts:

| Runtime ID | Platform |
|---|---|
| `linux-x64` | Ubuntu |
| `win-x64` | Windows |
| `osx-x64` | macOS |
