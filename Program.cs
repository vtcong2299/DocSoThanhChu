using System;
using System.Text;


namespace DocSoThanhChu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            int num;
            while(true)
            {
            Console.Write("Nhập vào số < 1000 cần đổi thành chữ: ");
            while(true)
            {
            
                if(Int32.TryParse(Console.ReadLine(), out num))
                {
                    if(num>=100)
                    {
                        Console.Write("Hãy nhập số < 1000: ");
                    }
                    break;
                }
                else
                {
                    Console.Write("Bạn hay nhập vào 1 số < 1000: ");
                }
            }
            Console.Write("Số đó đổi thành chữ là: ");
            
            if(num>=0&&num<10)
            {
                switch(num)
                {
                    case 0:
                    Console.WriteLine("Không");
                    break;
                    case 1:
                    Console.WriteLine("Một");
                    break;
                    case 2:
                    Console.WriteLine("Hai");
                    break;
                    case 3:
                    Console.WriteLine("Ba");
                    break;
                    case 4:
                    Console.WriteLine("Bốn");
                    break;
                    case 5:
                    Console.WriteLine("Năm");
                    break;
                    case 6:
                    Console.WriteLine("Sáu");
                    break;
                    case 7:
                    Console.WriteLine("Bảy");
                    break;
                    case 8:
                    Console.WriteLine("Tám");
                    break;
                    case 9:
                    Console.WriteLine("Chín");
                    break;
                    
                }
                

            }
            else if(num>10&&num<=20)
            {
                switch(num%10)
                {
                    case 0:
                    Console.WriteLine("Mười");
                    break;
                    case 1:
                    Console.WriteLine("Mười Một");
                    break;
                    case 2:
                    Console.WriteLine("Mười Hai");
                    break;
                    case 3:
                    Console.WriteLine("Mười Ba");
                    break;
                    case 4:
                    Console.WriteLine("Mười Bốn");
                    break;
                    case 5:
                    Console.WriteLine("Mười Năm");
                    break;
                    case 6:
                    Console.WriteLine("Mười Sáu");
                    break;
                    case 7:
                    Console.WriteLine("Mười Bảy");
                    break;
                    case 8:
                    Console.WriteLine("Mười Tám");
                    break;
                    case 9:
                    Console.WriteLine("Mười Chín");
                    break;
                    
                }
            }
            else if(num>=20&&num<100)
            {
                switch(num/10)
                {
                    case 2:
                    Console.Write("Hai Mươi ");
                    break;
                    case 3:
                    Console.Write("Ba Mươi ");
                    break;
                    case 4:
                    Console.Write("Bốn Mươi ");
                    break;
                    case 5:
                    Console.Write("Năm Mươi ");
                    break;
                    case 6:
                    Console.Write("Sáu Mươi ");
                    break;
                    case 7:
                    Console.Write("Bảy Mươi ");
                    break;
                    case 8:
                    Console.Write("Tám Mươi ");
                    break;
                    case 9:
                    Console.Write("Chín Mươi ");
                    break;
                }
                switch(num%10)
                {
                    case 0:
                    Console.WriteLine("");
                    break;
                    case 1:
                    Console.WriteLine("Mốt");
                    break;
                    case 2:
                    Console.WriteLine("Hai");
                    break;
                    case 3:
                    Console.WriteLine("Ba");
                    break;
                    case 4:
                    Console.WriteLine("Tư");
                    break;
                    case 5:
                    Console.WriteLine("Lăm");
                    break;
                    case 6:
                    Console.WriteLine("Sáu");
                    break;
                    case 7:
                    Console.WriteLine("Bảy");
                    break;
                    case 8:
                    Console.WriteLine("Tám");
                    break;
                    case 9:
                    Console.WriteLine("Chín");
                    break;
                    
                }
            }
            else if(num>=100&&num<1000)
            {
                switch(num/100)
                {
                    case 1:
                    Console.Write("Một Trăm ");
                    break;
                    case 2:
                    Console.Write("Hai Trăm ");
                    break;
                    case 3:
                    Console.Write("Ba Trăm ");
                    break;
                    case 4:
                    Console.Write("Bốn Trăm ");
                    break;
                    case 5:
                    Console.Write("Năm Trăm ");
                    break;
                    case 6:
                    Console.Write("Sáu Trăm ");
                    break;
                    case 7:
                    Console.Write("Bảy Trăm ");
                    break;
                    case 8:
                    Console.Write("Tám Trăm ");
                    break;
                    case 9:
                    Console.Write("Chín Trăm ");
                    break;
                }
                switch((num%100)/10)
                {
                    case 0:
                    Console.Write("Linh ");
                    break;
                    case 1:
                    Console.Write("Mười ");
                    break;
                    case 2:
                    Console.Write("Hai Mươi ");
                    break;
                    case 3:
                    Console.Write("Ba Mươi ");
                    break;
                    case 4:
                    Console.Write("Bốn Mươi ");
                    break;
                    case 5:
                    Console.Write("Năm Mươi ");
                    break;
                    case 6:
                    Console.Write("Sáu Mươi ");
                    break;
                    case 7:
                    Console.Write("Bảy Mươi ");
                    break;
                    case 8:
                    Console.Write("Tám Mươi ");
                    break;
                    case 9:
                    Console.Write("Chín Mươi ");
                    break;
                }
                switch((num%100)%10)
                {
                    case 0:
                    Console.WriteLine("");
                    break;
                    case 1:
                    Console.WriteLine("Một");
                    break;
                    case 2:
                    Console.WriteLine("Hai");
                    break;
                    case 3:
                    Console.WriteLine("Ba");
                    break;
                    case 4:
                    Console.WriteLine("Tư");
                    break;
                    case 5:
                    Console.WriteLine("Lăm");
                    break;
                    case 6:
                    Console.WriteLine("Sáu");
                    break;
                    case 7:
                    Console.WriteLine("Bảy");
                    break;
                    case 8:
                    Console.WriteLine("Tám");
                    break;
                    case 9:
                    Console.WriteLine("Chín");
                    break;
                    
                }
            }

            Console.WriteLine("\nNhấn [Ký tự bất kỳ] để tiếp tục đổi hoặc nhập [END] để kết thúc chương trình:");
            string exit=Console.ReadLine();
        
          
            if (exit=="end"||exit=="END")
            {
                goto EndOfStreamException;
            }
            
        
            }
            EndOfStreamException:;
        }
    }
}