#include <iostream>
#include <inttypes.h>
#define macro()

enum class TestEnum
{
	ENUM_A,
	ENUM_B,
	ENUM_C
};

struct TestStruct
{
	int a;
	int b;
	uint16_t c;
};

template <typename T>
class GenericClass
{
	T var;
};

class TestClass
{
public:
	int intVar;
	static int intStatic;

	static int staticAdd(int a, int b)
	{
		int result = a + b;
		return result;
	}

    int add(int a, int b)
	{
		int result = a + b;
		intVar = a;
		return result;
	}

	TestClass() 
	{ 
		intVar = 0; 
		intStatic = 100;
	}

private:
};

int main()
{
	//Test Comment
	/*
	 */
	for (int i = 0; i < 100; i++)
	{

	}

	macro();

	TestStruct ts;
	ts.a = 1;
	ts.b = (int)TestEnum::ENUM_C;

	TestClass::intStatic = 10000;
	TestClass tc;
	tc.add(1, ts.a);
	tc.staticAdd(ts.b, 1);

	TestClass* tch = new TestClass();

	tch->add(22321, 114);
	tch->staticAdd(TestClass::intStatic, 771);

	delete tch;

	GenericClass<int> gc;


	std::cout << "Hello World!" << std::endl;

	system("PAUSE");
	return 0;
}