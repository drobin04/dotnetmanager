// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

// App Start
int input;
displaystartmenu();







void wr(string x) {Console.WriteLine(x);}

// Display menu items - 
// Display whether a dotnet app is found in the current directory...

void displaystartmenu() {
    wr("1. Create new project in this directory");
    wr("2. Create new project in sub directory");
    wr("3. Open a project...");
    wr("4. Compile & Run Current Project");
    //wr("");
    wr("Make a selection:");
    try {
        input = Int32.Parse(Console.ReadLine());
        wr("Selection: " + input);

    }
    catch (Exception e)
    {
        displaystartmenu();
    }
}


