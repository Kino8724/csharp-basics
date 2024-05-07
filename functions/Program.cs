// Functions can be public or private (main two)
// They can be static which means they dont need to be initialized to be used
// They need a return type, a name, and args if you need them
// [public || private] [static] <return type> <NameInPascalCase>([<arg type> <arg nameInCamelCase>])

static int AddTwoNums(int num1, int num2)
{
    return num1 + num2;
}

Console.WriteLine(AddTwoNums(1,2));