#include "stdafx.h"
#include "MyClass.h"
#include <string>

MyClass::MyClass()
{
	this->number = 0;
}


MyClass::~MyClass()
{
	delete &this->number;
}

int MyClass::GetNumber()
{
	return this->number;
}

void MyClass::SetNumber(int number)
{
	this->number = number;
}

char* MyClass::GetName()
{
	return const_cast<char*>("I'm a test class.");
}