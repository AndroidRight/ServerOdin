using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;

namespace Analizer.execute
{
    public class network
    {   
        public void button1_Click()
        {
            string strHostName = string.Empty;
            strHostName = Dns.GetHostName();
            IPAddress[] hostIPs = Dns.GetHostAddresses(strHostName);
            for (int i = 0; i < hostIPs.Length; i++)
            {
                Console.WriteLine("Direccion IP:" +hostIPs[i].ToString());
            }
            Console.WriteLine("Nombre de la computadora:" + strHostName);
        }
    }
}
