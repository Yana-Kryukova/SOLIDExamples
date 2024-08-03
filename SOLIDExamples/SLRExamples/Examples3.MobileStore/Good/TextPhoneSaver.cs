using SLRExamples.Examples2.MobileStore.Good.Interfaces;

namespace SLRExamples.Examples2.MobileStore.Good
{
    internal class TextPhoneSaver : IPhoneSaver
    {
        public void Save(Phone phone, string fileName)
        {
            using StreamWriter writer = new StreamWriter(fileName, true);
            writer.WriteLine(phone.Model);
            writer.WriteLine(phone.Price);
        }
    }
}
