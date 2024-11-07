namespace ConsoleApp1.GameLife;

public class Game
{
    public int Tick = 100;
    public bool IsEnabledStatistic = true;

    private int _height;
    private int _width;

    private char[][] _firstField;
    private char[][] _secondField;
    
    private readonly char _aliveCell = '█';
    private readonly char _deadCell = ' ';

    private bool _isFirstField = true;
    private int _cycle = 1;

    public Game(char[][] initialField)
    {
        _height = initialField.Length;
        _width = initialField[0].Length;
        
        _firstField = initialField;
        _secondField = new char[_height][];

        for (var i = 0; i < _height; i++)
        {
            _secondField[i] = new char[_width];
            Array.Fill(_secondField[i], _deadCell);
        }
    }

    public void StartGame()
    {
        while (true)
        {
            Task.WaitAll(Update(), Task.Delay(Tick));
        }
    }

    private async Task Update()
    {
        var currentField = _isFirstField ? _firstField : _secondField;
        
        Console.Clear();
        
        foreach (var row in currentField)
        {
            Console.WriteLine(row);
        }

        var watch = System.Diagnostics.Stopwatch.StartNew();
        
        Process();
        watch.Stop();
        
        var elapsedMs = watch.Elapsed.TotalMilliseconds;
        
        if (IsEnabledStatistic)
            ShowStatistic(elapsedMs);

        _isFirstField = !_isFirstField;
        _cycle++;
    }

    private void Process()
    {
        var (current, next) = _isFirstField ? (_firstField, _secondField) : (_secondField, _firstField);

        for (var y = 0; y < _height; y++)
        {
            for (var x = 0; x < _width; x++)
            {
                next[y][x] = LifeCheck(current, x, y);
            }
        }
    }

    private char LifeCheck(char[][] field, int x, int y)
    {
        var xFrom = x - 1 >= 0 ? x - 1 : 0;
        var xTo = x + 2 < _width ? x + 2 : _width;
        var yFrom = y - 1 >= 0 ? y - 1 : 0;
        var yTo = y + 2 < _height ? y + 2 : _height;

        var neighbourCount = 0;

        for (var yCurrent = yFrom; yCurrent < yTo; yCurrent++)
        {
            for (var xCurrent = xFrom; xCurrent < xTo; xCurrent++)
            { 
                if (xCurrent != x || yCurrent != y)
                    neighbourCount += field[yCurrent][xCurrent] == _aliveCell ? 1 : 0;
            }
        }
        
        if (field[y][x] == _deadCell)
            return neighbourCount == 3 ? _aliveCell : _deadCell;
        
        return neighbourCount < 2 ||  neighbourCount > 3 ? _deadCell : _aliveCell;
    }

    private void ShowStatistic(double elapsedMs)
    {
        Console.WriteLine($"Cycle: {_cycle}");
        Console.WriteLine($"Process time: {elapsedMs} ms");
    }
}