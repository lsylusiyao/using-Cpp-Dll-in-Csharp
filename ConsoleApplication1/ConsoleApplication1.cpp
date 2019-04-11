#include "stdafx.h"
#include "../Dll1/Dll1.h"
#pragma comment(lib, "../Debug/Dll1.lib")
using namespace System;

namespace ManageCppDll
{
	public ref class testDll
	{
	public:
		testDll() :p(new testDllBase()) {};
		~testDll() { delete p; }
		void SetC(char c) { p->SetC(c); }
		char GetC() { return p->GetC(); }
		void SetA(int a) { p->SetA(a); }
		void SetB(int b) { p->SetB(b); }
		int Add() { return p->Add(); }
		int Sub() { return p->Sub(); }
	private:
		testDllBase* p;
	};
}

