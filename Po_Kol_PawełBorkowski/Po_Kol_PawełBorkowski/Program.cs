using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po_Kol_PawełBorkowski
{
    class Program
    {
        static void Main(string[] args)
        {
            PC pc1 = new PC();
            UsbC usbc = new UsbC(640, 600);
            UsbA usba = new UsbA(60, 30);
            Laptop laptop1 = new Laptop();
            laptop1.DodajDoSlownika(1, usbc);
            laptop1.DodajDoSlownika(2, usba);
            pc1.DodajDoSlownika(1,usbc);
            pc1.DodajDoSlownika(2,usba);
            pc1.PobierzPrzezUsb(usba);
            laptop1.PobierzPrzezUsb(usbc);
            pc1.WyslijPrzezUsb(usba);
            laptop1.WyslijPrzezUsb(usbc);
            Console.ReadLine();
        }

        interface IUsb
        {
            void PobierzDane();
            void WyslijDane();
        }


        abstract class Usb : IUsb
        {
            public double maxPredkoscPobierania;
            public double maxPredkoscWysylania;

            public Usb(double maxPredkoscPobierania, double maxPredkoscWysylania)
            {
                this.maxPredkoscPobierania = maxPredkoscPobierania;
                this.maxPredkoscWysylania = maxPredkoscWysylania;
            }
            public void PobierzDane()
            {
                Console.WriteLine("Odbieram dane z prędkością " + maxPredkoscPobierania + "MB/s");
            }
            public void WyslijDane()
            {
                Console.WriteLine("Wysyłam dane z prędkością " + maxPredkoscWysylania + "MB/s");
            }

        }

        class UsbC : Usb
        {
            public UsbC(double maxPredkoscPobierania, double maxPredkoscWysylania) : base(maxPredkoscPobierania, maxPredkoscWysylania)
            {

            }

        }

        class UsbA : Usb
        {
            public UsbA(double maxPredkoscPobierania, double maxPredkoscWysylania) : base(maxPredkoscPobierania, maxPredkoscWysylania)
            {

            }

        }

        class Laptop
        {
            UsbA usbLaptop1 = new UsbA(60, 30);
            Dictionary<int, Usb> usbL = new Dictionary<int, Usb>();
            public void DodajDoSlownika(int n, Usb u)
            {
                usbL.Add(n, u);
            }
            public void PobierzPrzezUsb(Usb u)
            {
                u.PobierzDane();
            }
            public void WyslijPrzezUsb(Usb u)
            {
                u.WyslijDane();
            }
        }

        class Smartfon
        {
            UsbC usbSmartfon1 = new UsbC(640, 600);
            Dictionary<int, Usb> usbS = new Dictionary<int, Usb>();
            public void DodajDoSlownika(int n, Usb u)
            {
                usbS.Add(n, u);
            }
            public void PobierzPrzezUsb(Usb u)
            {
                u.PobierzDane();
            }

            public void WyslijPrzezUsb(Usb u)
            {
                u.WyslijDane();
            }
        }

        class Tablet
        {
            UsbC usbTablet = new UsbC(640, 600);
            Dictionary<int, Usb> usbT = new Dictionary<int, Usb>();
            public void DodajDoSlownika(int n, Usb u)
            {
                usbT.Add(n, u);
            }
            public void PobierzPrzezUsb(Usb u)
            {
                u.PobierzDane();
            }
            public void WyslijPrzezUsb(Usb u)
            {
                u.WyslijDane();
            }
        }

        class PC
        {
            UsbC usbCPC = new UsbC(640, 600);
            Dictionary<int, Usb> usbPC = new Dictionary<int, Usb>();
            public void DodajDoSlownika(int n, Usb u)
            {
                usbPC.Add(n, u);
            }
            public void PobierzPrzezUsb(Usb u)
            {
                u.PobierzDane();
            }
            public void WyslijPrzezUsb(Usb u)
            {
                u.WyslijDane();
            }
        }



    }
}
