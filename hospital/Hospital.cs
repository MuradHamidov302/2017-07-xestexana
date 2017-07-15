using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    class Hospital
    {
        public Hospital()
        {
          
           string parol = "123";
            tekrar1:
            Console.WriteLine("parolu daxil edin-[123]");
            Console.Write("parol:  ");
        
            if (parol == Console.ReadLine()) { Shobeler(); }
            else { Console.Clear(); goto tekrar1; }
        }


        public void Shobeler()
        {

            List<string> Shobe = new List<string>();
            Shobe.Add("cerrahiye");
            Shobe.Add("kordiolohiya");
            Shobe.Add("stamotologiya");

            tekrar2:
            Console.WriteLine("\n\n==> shobeler- ");

            int i;
            for (i = 0; i < Shobe.Count; i++)
            {

                Console.WriteLine(i + 1 + "-" + Shobe[i]);
            }

            
                Console.WriteLine("\n\nShobe sil-1\nShobe elave et-2\nShobe melumatlarini deyis-3\nHekim siyahisini goster-4");
                tekrar4:
               Console.Write("kecid-  ");
           
            var a = Console.ReadLine();
            if (a == "1")
            {
                tekrar3:
                Console.Write("shobe nomresin daxil edin: ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b <= i)
                {
                    Shobe.Remove(Shobe[b - 1]);
                    goto tekrar2;

                }
                else { goto tekrar3; }
            }
            else if (a == "2")
            {
                tekrar3:
                Console.Write("shobe adini daxil edin: ");
                string b = Console.ReadLine();
                Shobe.Add(b);
                goto tekrar2;

            }
            else if (a == "3")
            {
                tekrar3:
                Console.Write("shobe nomresin daxil edin: ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b <= i)
                {
                    Console.Write("yeni adi daxil edin: ");
                    string yeniad = Console.ReadLine();
                    Shobe[b - 1] = yeniad;
                    goto tekrar2;

                }
                else { goto tekrar3; }
            }
            else if (a == "4") { Console.Clear(); Hekim();  }
            else { goto tekrar4; }

         }

    
        
        
 
        public void Hekim()
        {
         

            List<string> hekim = new List<string>()
            {
                "Murad",
                "Rza",
                "Zaur"
            };

            tekrar2:
            Console.WriteLine("==>hekimler-");
            int i;
            
            for ( i = 0; i < hekim.Count; i++)
            {
                Console.WriteLine(i + 1 + "-" + hekim[i]);
            }
           
            Console.WriteLine("\n\nHekim sil-1\nHekim elave et-2\nHekim melumatlarini deyis-3\nShobeler siyahisini goster-4");
            tekrar4:
            Console.Write("kecid-  ");
            
            var a = Console.ReadLine();
            if (a == "1")
            {
                tekrar3:
                Console.Write("hekim nomresin daxil edin: ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b <= i)
                {
                    hekim.Remove(hekim[b - 1]);
                    goto tekrar2;

                }
                else { goto tekrar3; }
            }
            else if (a == "2")
            {
                tekrar3:
                Console.Write("hekim adini daxil edin: ");
                string b = Console.ReadLine();
                hekim.Add(b);
                goto tekrar2;

            }
            else if (a == "3")
            {
                tekrar3:
                Console.Write("hekim nomresin daxil edin: ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b <= i)
                {
                    Console.Write("yeni adi daxil edin: ");
                    string yeniad = Console.ReadLine();
                   hekim[b - 1] = yeniad;
                    goto tekrar2;

                }
                else { goto tekrar3; }
            }
            else if (a == "4") { Console.Clear(); Shobeler(); }
            else { goto tekrar4; }

        }
                               
      }

    

}
