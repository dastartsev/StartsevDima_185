using System;


class Square
{
    private int[][] _square;

    public Square(int size) //Создаёт новый квадрат указанного размера
    {
        _square = new int[size][];
        for (int i = 0; i < size; ++i)
        {
            _square[i] = new int[size];
        }
    }

    public int SumRow(int row) //Возвращает сумму элементов указанной строки
    {
        int sum = 0;
        for (int i = 0; i < _square.Length; ++i)
        {
            sum += _square[row - 1][i];
        }
        return sum;
    }

    public int SumCol(int col) //Возвращает сумму элементов указанного столбца
    {
        int sum = 0;
        for (int i = 0; i < _square.Length; ++i)
        {
            sum += _square[i][col - 1];
        }
        return sum;
    }

    public int SumMainDiag()
    {
        int sum = 0;
        for (int i = 0; i < _square.Length; ++i)
        {
            sum += _square[i][i];
        }
        return sum;
    }

    public int SumOtherDiag()
    {
        int sum = 0;
        for (int i = 0; i < _square.Length; ++i)
        {
            sum += _square[i][_square.Length - 1 - i];
        }
        return sum;
    }
    public bool Magic() // Возвращает, является ли текущий квадрат магическим
    {
        int num = this.SumMainDiag();
        if (num == this.SumOtherDiag())
        {
            for (int i = 0; i < _square.Length; ++i)
            {
                if (num != this.SumRow(i) || num != this.SumCol(i))
                {
                    return false;
                }
            }
        }
        else
        {
            return false;
        }
        return true;
    }

    public void ReadSquare(string[] lines, int lineIndex) // Считывает значения элементов квадрата из консоли
    {
        for (int row = 0; row < _square.Length; row++)
        {
            string[] line = lines[lineIndex + row].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (line.Length != _square.Length)
                Console.WriteLine($"Ошибка при чтении квадрата: строка должна содержать {_square.Length} значений, а содержит {line.Length}");
            for (int i = 0; i < _square.Length; i++)
                int.TryParse(line[i], out _square[row][i]);
        }
    }

    public void PrintSquare()
    {
        for (int i = 0; i < _square.Length; ++i)
        {
            for (int j = 0; j < _square.Length; ++j, Console.WriteLine())
            {
                Console.WriteLine($"{_square[i][j]} ");
            }
        }
    }
}