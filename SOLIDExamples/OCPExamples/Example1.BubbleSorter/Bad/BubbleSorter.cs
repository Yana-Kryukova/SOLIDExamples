namespace OCPExamples.Example1.BubbleSorter.Bad
{
    public class BubbleSorter
    {
        public void Sort(int[] data)
        {
            int n = data.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
        }
    }
}
#region Комментарии
// Этот метод умеет сортировать только целые числа.
// Если наша программа уже сейчас нуждается в таком же методе но не только для целых чисел
// (или будет нуждатся в будущем наверняка) -- это и есть наша точка расширения.
#endregion