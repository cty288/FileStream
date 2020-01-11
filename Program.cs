using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream=new FileStream("Testtxt.txt",FileMode.Open);
            byte[] data=new byte[1024];
            //1byte=1字节  1024byte=1kb
           
            while (true) {
                int length = stream.Read(data, 0, data.Length);
                if (length == 0) {
                    break;
                }

                for (int i = 0; i < length; i++) {
                    Console.Write(data[i]+" ");
                }
            }


            FileStream readStream=new FileStream("3.LINQ.png",FileMode.Open);
            FileStream writeStream=new FileStream("copy.png",FileMode.Append);
            
            byte[] dataStream=new byte[1024];
            
            while (true) {
                int length= readStream.Read(dataStream, 0, dataStream.Length);
                if (length == 0) {
                    break;
                }
                else {
                    writeStream.Write(dataStream,0,length);
                }
                
            }
            writeStream.Close();
            readStream.Close();
            Console.ReadKey();
        }
    }
}
