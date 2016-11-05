using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_bases
{
    struct ProductInformation
    {
        public string productName;
        public string receiptDate;
        public string storageLife;
        public string provider;
        public int weight;
        public int value;

        //Структура не может иметь конструктора по умолчанию (т.е. без параметров), ко всему этому так же надо знать,
        //что при написании ЛЮБОГО конструктора, необходимо инициализировать ВСЕ поля структуры в его теле.
        public ProductInformation
            (string productName, string receiptDate, string storageLife, string provider, int weight, int value)
        {
            this.productName = productName;
            this.provider = provider;
            this.receiptDate = receiptDate;
            this.storageLife = storageLife;
            this.value = value;
            this.weight = weight;
        }

        public void ShowInfo()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", productName, receiptDate, storageLife, provider, weight, value);
        }
    }
}
