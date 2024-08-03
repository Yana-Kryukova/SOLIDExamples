using SLRExamples.Examples2.MobileStore.Good.Interfaces;

namespace SLRExamples.Examples2.MobileStore.Good
{
    internal class GeneralPhoneValidator : IPhoneValidator
    {
        public bool IsValid(Phone phone) =>
            !string.IsNullOrEmpty(phone.Model) && phone.Price > 0;
    }
}
