using System;
using System.Linq;
namespace EntityFrameworkImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (lcttrainingdbEntities lctTrainingentity = new lcttrainingdbEntities())
                {
                    var findSuzan = lctTrainingentity
                        .TrainingTables.Where(x => x.TrainingProvider.Equals("Suzan")).FirstOrDefault();

                    Console.WriteLine("Id: {0}; Training Name: {1}; Training Provider: {2};",findSuzan.Id,
                        findSuzan.TrainingName,
                        findSuzan.TrainingProvider);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
