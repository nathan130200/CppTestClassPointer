#include "stdafx.h"

MyClass* MyClass_Initialize() 
{
	return new MyClass();
}

void MyClass_Shutdown(MyClass* pInstance) 
{
	pInstance->~MyClass();
	pInstance = nullptr;		 
}

int MyClass_GetNumber(MyClass* pInstance) 
{
	return pInstance->GetNumber();
}

void MyClass_SetNumber(MyClass* pInstance, int number)
{
	pInstance->SetNumber(number);
}

char* MyClass_GetName(MyClass* pInstance)
{
	return pInstance->GetName();
}