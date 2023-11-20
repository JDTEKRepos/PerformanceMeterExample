namespace PerformanceMeterExample;

public class Program
{
    /// <summary>
    /// 동기 방식의 메소드 측정 에제
    /// </summary>
    static void Main()
    {
        Console.WriteLine("============= start ==============");

        var elapsed = PerformanceMeter.Check(() => PerformanceTimerExample(100));
        Console.WriteLine($"ActionType Time elapsed: {elapsed}");

        // 반환 값이 있는 메소드 측정 방법
        var funcElapsed = PerformanceMeter.Check(() => PerformanceTimerFuncExample(5));
        Console.WriteLine($"FuncType Time elapsed: {funcElapsed}");

        Console.WriteLine("=============  end  ==============");
        Console.ReadLine();
    }

    private static void PerformanceTimerExample(int maxValue)
    {
        double n = 0;
        for (int i = 0; i < maxValue; i++)
        {
            n *= 2;

            Thread.Sleep(100);
        }
    }

    private static double PerformanceTimerFuncExample(int maxValue) 
    {
        double n = 0;
        for (int i = 0; i < maxValue; i++)
        {
            n *= 2;

            Thread.Sleep(100);
        }

        return n;
    }

    #region 비동기 방식 측정 예제
    /*
     
    /// <summary>
    /// 비동기 방식의 메소드 측정 예제
    /// </summary>
    static async Task Main()
    {
        Console.WriteLine("============= start ==============");

        var asyncElapsed = await PerformanceMeter.CheckAsync(async () => await PerformanceTimerExample(13));
        Console.WriteLine($"Time elapsed: {asyncElapsed}");

        Console.WriteLine("=============  end  ==============");

        Console.ReadLine();
    }

    private static async Task PerformanceTimerExample(int maxValue)
    {
        double n = 0;
        for (int i = 0; i < maxValue; i++)
        {
            n *= 2;

            await Task.Delay(100);
        }
    }

    */
    #endregion
}