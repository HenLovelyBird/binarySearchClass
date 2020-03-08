using System;
namespace StriveEasierAlgorithms
{
    public class ShellCommands
    {
        public ShellCommands()
        {
            Console.WriteLine("Shows all the content of the current working directory");
        }
    }
}

//The shell can execute this commands:
//- dir => Shows all the content of the current working directory
//- ls => Same as dir
//- pwd => print working dir
//- cd .. => goes up in the folder hierarchy
//- cd FolderName => goes in the folder FolderName
//- del FileName => delete a specific file called FileName
//- mv FileName path => move the file FileName to Path
//- exit => exit the program
//​
//[EXTRA]:
//Using Arrow Up / Arrow Down, the user can select a previously used command from the history.

//- All the commands have the same features and therefore they could all derive from the same class
//  (Command).
//- Being all the commands implementing the same parent class, the history could be managed as array of
//  Command(Command[])
//- This is just a hint if you want to try messing up with Inheritance and Polymorphism.If it sounds too
//  weird, please just ignore it.