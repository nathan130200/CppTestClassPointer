#ifndef MYCLASS_H
#define MYCLASS_H

using namespace std;

#pragma once
class MyClass
{
private:
	int number;

public:
	MyClass();
	~MyClass();
	int GetNumber();
	void SetNumber(int);
	char* GetName();
};

#endif // MYCLASS_H