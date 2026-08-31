#pragma once

#if defined(_WIN32) || defined(_WIN64)
#  define QUICKMATH_API __declspec(dllexport)
#else
#  define QUICKMATH_API __attribute__((visibility("default")))
#endif

#ifdef __cplusplus
extern "C" {
#endif

QUICKMATH_API int add(int a, int b);
QUICKMATH_API int subtract(int a, int b);
QUICKMATH_API int multiply(int a, int b);

#ifdef __cplusplus
}
#endif
