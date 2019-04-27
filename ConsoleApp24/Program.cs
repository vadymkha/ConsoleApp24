using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
               
                UdpClient uClient = new UdpClient(1024);
                IPEndPoint ipEnd = null;
               
                byte[] responce = uClient.Receive(ref ipEnd);
                MemoryStream ms = new MemoryStream(responce);
                Image im = Image.FromStream(ms);
                im.Save("test" + DateTime.Now.Second.ToString() + ".jpg", ImageFormat.Jpeg);
                uClient.Close();
            }
        }
    }
}
