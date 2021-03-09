using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ExemploTopShelf
{
    class ClsExemploTopShelf
    {
        private Timer timer;

        public ClsExemploTopShelf()
        {
            timer = new Timer(10000);

            timer.Elapsed += Timer_Elipsed;

        }

        private void Timer_Elipsed(object sender, ElapsedEventArgs e)
        {
            string mensagem = $"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} teste";

            Console.WriteLine(mensagem);

            using (StreamWriter arquivo = new StreamWriter(@"D:\Projetos\TopShelf c#\ExemploTopShelf\teste.txt",true))
            {
                arquivo.WriteLine(mensagem);
                arquivo.Close();
            }

        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
