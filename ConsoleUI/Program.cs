using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

ProgramManager programManager = new ProgramManager(new EfProgramDal());

foreach (var program in programManager.GetAll())
{
    Console.WriteLine(program.Name);
}