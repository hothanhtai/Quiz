using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_QUIZ_A
{
    class Program
    {
        static void nhap(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuat(int[] a, int n)
        {
            Console.Write("Hien thi mang:");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }


        static void Main(string[] args)
        {
            /*Bài tập 1.Viết chương trình nhập vào Thông tin của một sinh viên(Họ tên, ngày
            sinh...) in ra Thông tin và tuổi của nhân viên đó.Nếu trùng ngày hiện tại thì hiển thị “
            Chúc mừng sinh nhật”.*/
            //Câu 1
            Console.WriteLine("/------------ Cau 1 ----------/");
            Console.Write("Nhap ho va ten: ");
            string name = Console.ReadLine();
            Console.Write("Ngay sinh: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Thang sinh: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nam sinh: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Dia chi: ");
            string address = Console.ReadLine();
            Console.Write("SDT: ");
            string phone = Console.ReadLine();

            Console.WriteLine("\n---------- Thong tin sinh vien da nhap-------------");

            Console.WriteLine("Ho va ten: {0}",name);
            Console.WriteLine("Ngay thang nam sinh: {0}/{1}/{2}", d,m,y);
            Console.WriteLine("Dia chi: {0}", address);
            Console.WriteLine("So dien thoai: {0}", phone);


            DateTime now = DateTime.Now;
            Console.WriteLine("So tuoi hien tai la: {0} tuoi",now.Year-y);
            if(d==now.Day && m == now.Month)
            {
                Console.WriteLine("CHUC MUNG SINH NHAT <3 ");
            }
            Console.WriteLine("\n");


            /*Viết chương trình nhập vào thông tin số nguyên n có 3 chữ số. Tính và xuất
            ra tổng và tích chữ số đầu tiên và chữ số cuối cùng của số đó.Ví dụ số đó là 345 thì
            chữ số đầu tiên là 3 và chữ số cuối là 5*/
            //Câu 2
            Console.WriteLine("/------------ Cau 2 ----------/");
         
            Console.WriteLine("nhap so nguyen n co 3 chu so: ");
            int n = int.Parse(Console.ReadLine());
            int p = n % 10;
            while (n >= 10)
            {
                n = n / 10;
            }
            Console.WriteLine("tong cua so dau va so cuoi la: " + (n + p));
            Console.WriteLine("tich cua so dau va so cuoi la: " + (n * p));

            Console.WriteLine("\n");



            //Viết chương trình nhập vào 3 số, kiểm tra xem 3 số đó có phải là cạnh của 1 tam giác hay không. Nếu có kiểm tra đó là tam giác gì(Lưu ý chỉ xét tam giác đều, vuông, cân)
            //Cau3
            Console.WriteLine("/------------ Cau 3 ----------/");
            Console.Write("Nhap vao 3 canh cua tam giac!");
            Console.Write("Nhap canh thu 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh thu 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh thu 3: ");
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && b + c > a && c + a > b)
            {

                    decimal epsilon = 0.0001m;

                    if (a == b && b == c)
                    {
                        Console.WriteLine("Tam giác đều");

                    };
                    if (a == b || b == c || c == a)
                    {
                        Console.WriteLine("Tam giac can");
                    };
                    if (Math.Abs(a * a + b * b - c * c) <= epsilon
                            || Math.Abs(b * b + c * c - a * a) <= epsilon
                            || Math.Abs(c * c + a * a - b * b) <= epsilon)
                    {
                        Console.WriteLine("Tam giác vuông");
                    };

            }else
            {
                Console.WriteLine("Không phải tam giác");
            }
            Console.WriteLine("\n");




            //Viết chương trình giải phương trình bậc 2
            //cau 4
            Console.WriteLine("/------------ Cau 4 ----------/");
          
            int a1, b1, c1;
     
            double x1, x2, delta;
   
            Console.Write("\n Nhap vao so a: ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so b: ");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so c: ");
            c1 = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine("\n Chuong trinh ban vua nhap la {0}x^2 + {1}x + {2} = 0.", a1, b1, c1);
    
            if (a1 == 0)
            {
                if (b1 == 0)
                {
           
                    if (c1 == 0)
                    {
                        Console.WriteLine("\n Phuong trinh co vo so nghiem.");
                    }
                    else
                    {
                        Console.WriteLine("\n Phuong trinh vo nghiem.");
                    }
                }
                else
                {
                    x1 = (double)-c1 / b1;
                    Console.WriteLine("\n Phuong trinh co nghiem duy nhat x = {0}", Math.Round(x1, 2));
                }
            }
            else
            {
          
                delta = Math.Pow(b1, 2) - 4 * a1 * c1;
                if (delta < 0)
                {
                    Console.WriteLine("\n Phuong trinh vo nghiem.");
                }

                else if (delta == 0)
                {
                    x1 = x2 = -b1 / (2 * a1);
                    Console.WriteLine("\n Phuong trinh co nghiem kep x1 = x2 = {0}", x1);
                }
 
                else
                {
                    x1 = (-b1 + Math.Sqrt(delta)) / (2 * a1);
                    x2 = (-b1 - Math.Sqrt(delta)) / (2 * a1);
                    Console.WriteLine("\n Phuong trinh hai nghiem phan biet:\n X1 = {0}\n X2 = {1}", x1, x2);
                }
            }
            //cau 5(Array)
            Console.WriteLine("/------------ Cau 5 ----------/");
            Console.Write("Nhap so ptu cua mang: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[100];
            nhap(A, N);
            xuat(A, N);

            Console.ReadKey();

















            Console.ReadLine();
        }
    }
}
