namespace OCPExamples.Example1.BubbleSorter.Good
{
    public class BubbleSorter<T>
    {
        IComparer<T> _comparer;

        public BubbleSorter(IComparer<T> comparer)
        {
            _comparer = comparer;
        }

        public void Sort(T[] data)
        {
            int n = data.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (_comparer.Compare(data[j], data[j + 1]) > 0)
                    {
                        var temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
        }
    }
}

#region Комментарии
// IComparer<T> Определяет метод, реализуемый типом для сравнения двух объектов.
// Метод Compare(T, T) - Сравнение двух объектов и возврат значения, указывающего, является ли один объект меньшим,
// равным или большим другого.

// Этими изменениями мы добились многого, а именно:
// Все что можно сортировать мы можем сортировать через наш метод:
// целые числа, числа с плавающей точкой, строки.
// если нужно сортировать по убыванию, а не возрастанию,
// нам не нужно менять код сортировщика или создавать такую же функцию для обратной сортировки.
#endregion
