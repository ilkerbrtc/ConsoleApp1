using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class IhtıyacKrediManager : IkrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
