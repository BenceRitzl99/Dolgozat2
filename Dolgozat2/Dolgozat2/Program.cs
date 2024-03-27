using System.Runtime.InteropServices;

DogaContext _Context = new DogaContext();

if(!_Context.Class.Any())
{
    var sorok = File.ReadAllLines(@"c:\asztaliadat\13.csv").Skip(1);

    foreach (var line in sorok)
    {
        _Context.Class.Add(new Class(sor));
    }
    _Context.SaveChanges();
}