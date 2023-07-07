using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace basicprgm1
{
    internal class Files
    {
       
            public void display()
            {


                FileInfo fi = new FileInfo("C:\\Users\\kbrka\\OneDrive\\Desktop\\practical training\\C#\\Sample.txt");

                using StreamWriter str = fi.CreateText();

                Console.WriteLine("File has been created");
            
                str.WriteLine("Hello");
             
                
            }

            public void copyfile()
            {

                FileInfo fi = new FileInfo("C:\\Users\\kbrka\\OneDrive\\Desktop\\practical training\\C#\\Sample.txt");
                
                //fi.CopyTo("C:\\Users\\kbrka\\OneDrive\\Desktop\\practical training\\C#\\temp\\"+"Sample.txt");

                fi.MoveTo("C:\\Users\\kbrka\\OneDrive\\Desktop\\practical training" + "sample.txt");
             
                
            }
        
    }
}
