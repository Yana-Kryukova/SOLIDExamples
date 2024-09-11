using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPExamples.Example2.Machine.Bad
{
    class Item { }
    interface IMachine
    {
        public bool print(List<Item> item);
        public bool staple(List<Item> item);
        public bool fax(List<Item> item);
        public bool scan(List<Item> item);
        public bool photoCopy(List<Item> item);
    }

    class Machine : IMachine
    {
        public bool print(List<Item> item) { return true; } //Печатает все документы

        public bool staple(List<Item> item) { return true; } //Скрепляет степлером

        public bool fax(List<Item> item) { return true; } //Отправляет факсом документы

        public bool scan(List<Item> item) { return true; } //Сканирует документы

        public bool photoCopy(List<Item> item) { return true; }//Делает копии документов
    }
    //    Проблемы кода:

    //Перекомпилирование всего кода, даже, при маленьком изменении.
    //Клиент получит доступ ко многим "левым" методам, даже, если он заинтересован только в печати(например)
}
