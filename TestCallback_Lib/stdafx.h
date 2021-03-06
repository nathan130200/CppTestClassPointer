#pragma once
#include "targetver.h"
#include "MyClass.h"
#define WIN32_LEAN_AND_MEAN

#ifndef EXPORT
#define EXPORT __declspec(dllexport)
#endif //EXPORT

#ifdef __cplusplus 
extern "C" {
#endif

EXPORT MyClass* MyClass_Initialize();
EXPORT void MyClass_Shutdown(MyClass* pInstance);
EXPORT int MyClass_GetNumber(MyClass* pInstance);
EXPORT void MyClass_SetNumber(MyClass* pInstance, int number);
EXPORT char* MyClass_GetName(MyClass* pInstance);

#ifdef __cplusplus 
}
#endif
