using ISPExamples.Example2.Machine.Bad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ISPExamples.Example2.Machine.Good
{
    //    По принципу ISP нам нужно разделить один интерфейс на несколько: IPrinter , IStaple , IFax , IScan , IPhotoCopy

    //И, раз уж, у нас есть универсальная машина которая имплементирует все перечисленные, то создать под нее интерфейс, который унаследуется от них.

    public class Item { }
    public interface IPrinter
    {
        public bool print(List<Item> item);
    }
    public interface IFax
    {
        public bool staple(List<Item> item);
    }
    public interface IScan
    {
        public bool fax(List<Item> item);
    }
    public interface IPhotoCopy
    {
        public bool scan(List<Item> item);
    }
    public interface IStaple
    {
        public bool photoCopy(List<Item> item);
    }
    public interface IMachine : IPrinter, IFax, IScan, IPhotoCopy, IStaple
    {
        public bool print(List<Item> item);
        public bool staple(List<Item> item);
        public bool fax(List<Item> item);
        public bool scan(List<Item> item);
        public bool photoCopy(List<Item> item);
    }
    // А так же добавить конструктор класса в Machine

    public class UniversalMachine : IMachine
    {
        IPrinter printer;
        IFax fax;
        IScan scan;
        IPhotoCopy photoCopy;
        IStaple staple;
        public UniversalMachine(IPrinter printer, IFax fax, IScan scan, IPhotoCopy photoCopy, IStaple staple)
        {
            this.printer = printer;
            this.fax = fax;
            this.scan = scan;
            this.photoCopy = photoCopy;
            this.staple = staple;
        }

        bool IMachine.fax(List<Item> item)
        {
            throw new NotImplementedException();
        }

        bool IScan.fax(List<Item> item)
        {
            throw new NotImplementedException();
        }

        bool IMachine.photoCopy(List<Item> item)
        {
            throw new NotImplementedException();
        }

        bool IStaple.photoCopy(List<Item> item)
        {
            throw new NotImplementedException();
        }

        bool IMachine.print(List<Item> item)
        {
            throw new NotImplementedException();
        }

        bool IPrinter.print(List<Item> item)
        {
            throw new NotImplementedException();
        }

        bool IMachine.scan(List<Item> item)
        {
            throw new NotImplementedException();
        }

        bool IPhotoCopy.scan(List<Item> item)
        {
            throw new NotImplementedException();
        }

        bool IMachine.staple(List<Item> item)
        {
            throw new NotImplementedException();
        }

        bool IFax.staple(List<Item> item)
        {
            throw new NotImplementedException();
        }
    }
    //    Тогда создание такой универсальной машины будет таким:

    //var allOneClient = new Machine(
    //                        new Printer(),
    //    new Fax(),
    //                        new Scanner(),
    //                        new PhotoCopy(),
    //                        new Staple());
    //    Реализуя так, мы получаем следующие преимущества:

    //Клиент имеет доступ исключительно к тем методам, которые нужны клиенту.Про другие он не знает.
    //При повторном компилировании проэкта будут перекомпилированы лишь те блоки, в которых были изменения.

}
