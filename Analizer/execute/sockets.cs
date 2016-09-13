using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Analizer.execute
{
    public class sockets
    {
        public void Authen(string annie)
        {
            Socket ARG = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ISP = new IPEndPoint(IPAddress.Parse(annie), 1234);

            try
            {
                string texto;        
                byte[] textoEnviar;


                ARG.Bind(ISP);
                ARG.Listen(100);
                ARG.Accept();
                Console.WriteLine("CONECTADO...");

                //Console.WriteLine("Ingrese el texto a enviar al servidor: ");
              
                //texto = Console.ReadLine();               
                //textoEnviar = Encoding.Default.GetBytes(texto);              
                //ARG.Send(textoEnviar, 0, textoEnviar.Length, 0);               
                //Console.WriteLine("Enviado exitosamente");              
                //ARG.Close();
            }
            catch (SocketException e)
            {
                Console.WriteLine("ERROR SOCKET: {0}", e.ToString());
            }
        }
    }
}
