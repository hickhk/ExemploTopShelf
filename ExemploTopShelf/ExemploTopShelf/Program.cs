using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace ExemploTopShelf
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run( s => 
            {
                s.Service<ClsExemploTopShelf>(m =>
                {
                    m.ConstructUsing(st => new ClsExemploTopShelf());
                    m.WhenStarted(st => st.Start());
                    m.WhenStopped(st => st.Stop());
                });

                s.RunAsLocalService();

                s.SetDescription("Exemplo de serviço utilizando o topshelf.");
                s.SetDisplayName("Exemplo TopShelf");
                s.SetServiceName("ExemploTopShelf");
            });
        }
    }
}
