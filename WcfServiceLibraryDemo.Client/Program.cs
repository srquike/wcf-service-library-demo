using System;
using System.Threading.Tasks;
using WcfServiceLibraryDemo.Client.ServiceReference1;

namespace WcfServiceLibraryDemo.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new UserServiceClient();

            var user = new UserModel()
            {
                Name = "Test 2"
            };

            var result = await client.CreateAsync(user);

            if (result)
            {
                Console.WriteLine("-- Usuario creado con exito --");
            }
            else
            {
                Console.WriteLine("-- Error al interntar crear usuario --");
            }


            Console.ReadKey();
        }
    }
}
