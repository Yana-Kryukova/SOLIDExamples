using SLRExamples.Examples2.MobileStore.Good.Interfaces;

namespace SLRExamples.Examples2.MobileStore.Good
{
    internal class MobileStore
    {
        List<Phone> phones = new List<Phone>();

        public IPhoneReader Reader { get; set; }
        public IPhoneBinder Binder { get; set; }
        public IPhoneValidator Validator { get; set; }
        public IPhoneSaver Saver { get; set; }

        public MobileStore(IPhoneReader reader, IPhoneBinder binder, IPhoneValidator validator, IPhoneSaver saver)
        {
            this.Reader = reader;
            this.Binder = binder;
            this.Validator = validator;
            this.Saver = saver;
        }

        public void Process()
        {
            string?[] data = Reader.GetInputData();
            Phone phone = Binder.CreatePhone(data);
            if (Validator.IsValid(phone))
            {
                phones.Add(phone);
                Saver.Save(phone, "store.txt");
                Console.WriteLine("Данные успешно обработаны");
            }
            else
            {
                Console.WriteLine("Некорректные данные");
            }
        }
    }
    #region Комментарии
    // Теперь для каждой обязанности определен свой интерфейс.
    // Конкретные реализации обязанностей устанавливаются в виде интерфейсов в целевом классе.

    // В то же время кода стало больше, в связи с чем программа усложнилась.
    // И, возможно, подобное усложнение может показаться неоправданным при наличии одного небольшого метода,
    // который необязательно будет изменяться.
    // Однако при модификации стало гораздо проще вводить новый функционал без изменения существующего кода.
    // А все части метода Process, будучи инкапсулированными во внешних классах, теперь не зависят друг от друга и
    // могут изменяться самостоятельно.

    #endregion
}
