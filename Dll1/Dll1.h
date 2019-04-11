#pragma once

//#include "stdafx.h"

class __declspec(dllexport) testDllBase
{
private:
	int a;
	int b;
	char c;
public:
	void SetC(char c) { this->c = c; }
	char GetC() { return c; }
	void SetA(int a) { this->a = a; }
	void SetB(int b) { this->b = b; }
	int Add();
	int Sub();
};