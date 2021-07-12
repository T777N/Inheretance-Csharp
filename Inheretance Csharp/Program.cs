using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretance_Csharp
{
    abstract class Storage
    {
        public string Media_name { get; set; }
        public string Model { get; set; }

        public abstract void Hecm();
        public abstract void Copy();
        public abstract void FreeMemory();
        public abstract void PrintDeviceInfo();


        public Storage(string media_name,string model)
        {
            Media_name = media_name;
            Model = model;
        }
    }

    class Flash : Storage
    {
        string USB_speed { get; set; }
        string Memory { get; set; }
        string OneHour_Enerjy { get; set; }
        public Flash(string media_name,string model,string usb_speed,string memory,string oneHour)
        :base(media_name,model){
            USB_speed = usb_speed;
            Memory = memory;
            OneHour_Enerjy = oneHour;
        }
        public override void Copy()
        {
            double a=int.Parse(OneHour_Enerjy);
            double b=int.Parse(Memory);
            double c = b / a;
            int d=(int)c;
            Console.WriteLine($" yaddasin bitmeyine Qalib {d} mb");
        }

        public override void FreeMemory()
        {
            double a = int.Parse(OneHour_Enerjy);
            double b = int.Parse(Memory);
            double c = b / a;
            int d = (int)c;
            Console.WriteLine($" Free Memory : {d} ");
        }

        public override void Hecm()
        {
            Console.WriteLine($" Memory : {Memory} ");
        }

        public override void PrintDeviceInfo()
        {
            Console.WriteLine();
            Console.WriteLine($" - - - - -  | Flash disc INFORMATIONS _ ");
            Console.WriteLine($" Media name : {Media_name} ");
            Console.WriteLine($" Model : {Model} ");
            Console.WriteLine($" USB speed : {USB_speed} ");
            Console.WriteLine($" Memory : {Memory} ");

        }
    }

    class SSD : Storage
    {
        string Write_speed { get; set; }
        string Type_ { get; set; }
        string Memory { get; set; }
        string OneHour_Enerjy { get; set; }
        public SSD(string media_name, string model,string write_speed,string type, string memory, string oneHour)
        : base(media_name, model)
        {
            Write_speed = write_speed;
            Type_ = type;
            Memory = memory;
            OneHour_Enerjy = oneHour;
        }
        public override void Copy()
        {
            double a = int.Parse(OneHour_Enerjy);
            double b = int.Parse(Memory);
            double c = b / a;
            int d = (int)c;
            Console.WriteLine($" yaddasin bitmeyine Qalib {d} mb");
        }

        public override void FreeMemory()
        {
            double a = int.Parse(OneHour_Enerjy);
            double b = int.Parse(Memory);
            double c = b / a;
            int d = (int)c;
            Console.WriteLine($" Free Memory : {d} ");
        }

        public override void Hecm()
        {
            Console.WriteLine($" Memory : {Memory} ");
        }

        public override void PrintDeviceInfo()
        {
            Console.WriteLine();
            Console.WriteLine($" - - - - -  | SSD disc INFORMATIONS _ ");
            Console.WriteLine($" Media name : {Media_name} ");
            Console.WriteLine($" Model : {Model} ");
            Console.WriteLine($" Write speed : {Write_speed} ");
            Console.WriteLine($" Type : {Type_} ");
            Console.WriteLine($" Memory : {Memory} ");

        }
    }

    class HDD : Storage
    {
        string USB_speed { get; set; }
        string All_size { get; set; }
        string Memory { get; set; }
        string OneHour_Enerjy { get; set; }
        public HDD(string media_name, string model,string usb_speed,string all_size,string memory,string OneHour)
        : base(media_name, model)
        {
            USB_speed = usb_speed;
            All_size = all_size;
            Memory = memory;
            OneHour_Enerjy = OneHour;
        }
        public override void Copy()
        {
            double a = int.Parse(OneHour_Enerjy);
            double b = int.Parse(Memory);
            double c = b / a;
            int d = (int)c;
            Console.WriteLine($" yaddasin bitmeyine Qalib {d} mb");
        }

        public override void FreeMemory()
        {
            double a = int.Parse(OneHour_Enerjy);
            double b = int.Parse(Memory);
            double c = b / a;
            int d = (int)c;
            Console.WriteLine($" Free Memory : {d} ");
        }

        public override void Hecm()
        {
            Console.WriteLine($" Memory : {Memory} ");
        }

        public override void PrintDeviceInfo()
        {
            Console.WriteLine();
            Console.WriteLine($" - - - - -  | SSD disc INFORMATIONS _ ");
            Console.WriteLine($" Media name : {Media_name} ");
            Console.WriteLine($" Model : {Model} ");
            Console.WriteLine($" USB speed : {USB_speed} ");
            Console.WriteLine($" All size : {All_size} ");
            Console.WriteLine($" Memory : {Memory} ");

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            
           

        }
    }
}
