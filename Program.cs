using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 在 C# 9.0 版本中，引入了顶级语句（Top-Level Statements）的概念。
 * 顶级语句具有如下特点：
 * ·无需类或方法：顶级语句允许你直接在文件的顶层编写代码，无需定义类或方法。
 * ·文件作为入口点：包含顶级语句的文件被视为程序的入口点，类似于 C# 之前的 Main 方法。
 * ·自动 Main 方法：编译器会自动生成一个 Main 方法，并将顶级语句作为 Main 方法的主体。
 * ·支持局部函数：尽管不需要定义类，但顶级语句的文件中仍然可以定义局部函数。
 * ·更好的可读性：对于简单的脚本或工具，顶级语句提供了更好的可读性和简洁性。
 * ·适用于小型项目：顶级语句非常适合小型项目或脚本，可以快速编写和运行代码。
 * ·与现有代码兼容：顶级语句可以与现有的 C# 代码库一起使用，不会影响现有代码。
 * 
 * 顶级语句注意事项：
 * ·文件限制：顶级语句只能在一个源文件中使用。如果在一个项目中有多个使用顶级语句的文件，会导致编译错误。
 * ·程序入口：如果使用顶级语句，则该文件会隐式地包含 Main 方法，并且该文件将成为程序的入口点。
 * ·作用域限制：顶级语句中的代码共享一个全局作用域，这意味着可以在顶级语句中定义的变量和方法可以在整个文件中访问。*/
namespace ConsoleApp_Grammar // 1、命名空间声明
{
    class Program // 2、类声明（类中包含了class属性和class方法）（与Java 不同的是，文件名可以不同于类的名称）
    {
        static void Main(string[] args) // 4、一个Main方法
        {
            /* 我的第一个 C# 程序 */
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
