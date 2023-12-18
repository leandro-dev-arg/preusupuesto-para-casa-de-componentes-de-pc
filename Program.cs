using System;

namespace U4_programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int proce,ram,hdd,precio,final;
            precio=0;
            Console.WriteLine("buenos dias, indica una de las opciones que quieres de procesador intel i5(opcion1), intel i7(opcion 2),intel i9(opcion3)");
            proce=int.Parse(Console.ReadLine());
            Console.WriteLine("indica una de las opciones que quieres de ram 8GB(opcion1), 16GB(opcion 2),32gb(opcion3)");
            ram=int.Parse(Console.ReadLine());
            Console.WriteLine("Podemos apliar el almacenamiento hasta 1 TB(opcion1), o disco duros standart de 500GB(opcion 0)");
            hdd=int.Parse(Console.ReadLine());

            switch (proce)
            {
                case 1:
                    if (ram==1)
                    {
                        precio=800;
                    }   else if(ram==2){
                            precio=900;
                        }   else if (ram==3){
                            precio=1000;
                        }
                break;
                case 2:
                    if (ram==1)
                    {
                        precio=900;
                    }   else if(ram==2){
                            precio=1000;
                        }   else if (ram==3){
                            precio=1400;
                        }
                break;
                case 3:
                    if (ram==1)
                        {
                            precio=1200;
                        }   else if(ram==2){
                                precio=1400;
                            }   else if (ram==3){
                                precio=2000;
                            }
                break;
            }
                if (hdd==1){
                final=precio+300;
                Console.WriteLine("El importe final de su compra es "+final);
            }else   if(hdd==0){
                        final=precio;
                        Console.WriteLine("El importe final de su compra es "+final);
                        }



        }
    }
}
