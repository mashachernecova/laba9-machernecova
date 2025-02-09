
class MarkArray()
{
    Mark[] arr = new Mark[0];
    public Mark this[int index] // Индексатор
    {
        get
        {
            // если индекс имеется в массиве
            if (index >= 0 && index < arr.Length)
                return arr[index]; // то возвращаем объект Mark по индексу
            else
                throw new ArgumentOutOfRangeException(); // иначе генерируем исключение
        }
        set
        {
            // если индекс есть в массиве
            if (index >= 0 && index < arr.Length)
            {
                arr[index].name = value.name;    // переустанавливаем значение по индексу
                arr[index].mark = value.mark;
            }
            else
            {
                throw new ArgumentOutOfRangeException(); // иначе генерируем исключение
            }
        }
    }
    public void Pr()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Название: {arr[i].name}  Оценка: {arr[i].mark}");
        }

    }
    public int l()
    {
        return arr.Length;
    }

    public void PuBa(Mark l)
    {
        Mark[] new_arr = new Mark[arr.Length + 1];
        for (int i =0; i < arr.Length;i++)
        {
            new_arr[i] = arr[i];
        }
        new_arr[arr.Length] = l;
        arr = new_arr;
    }
    public void RandGen(int len)
    {
        string[] arr_name = ["Matan", "Linal", "Litra", "Ingligh", "Fizra", "Proga", "Chemist", "Fizika", "Russ", "OkrMir", "Music"];
        arr = new Mark[len];
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            int ind1 = rnd.Next(arr_name.Length);
            Mark r = new Mark(arr_name[ind1], rnd.Next(11));
            arr[i] = r;
        }
    }
    public void Clone(MarkArray a)
    {
        arr = new Mark[a.l()];
        for (int i = 0; i<arr.Length; i++)
        {
            arr[i] = a[i];
        }
    }
    public MarkArray SrZnach()
    {
        MarkArray a = new MarkArray();
        int sum = 0;
        for (int i = 0;i < arr.Length; i++)
        {
            sum += arr[i].mark;
        }
        for (int j = 0; j < arr.Length; j++)
        {
            if (sum/arr.Length < arr[j].mark)
            {
                a.PuBa(arr[j]);
            }
        }
        return a;
        
    }
}