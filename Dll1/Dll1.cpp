// Dll1.cpp : 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include "Dll1.h"

int testDllBase::Add()
{
	return a + b;
}

int testDllBase::Sub()
{
	return a - b;
}
