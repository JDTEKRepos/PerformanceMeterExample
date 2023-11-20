# Performance Meter Example

## 사용 방법

### 동기 메소드

```
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

```

```
// 반환 값이 없는 메소드 측정 방법
var elapsed = PerformanceMeter.Check(() => PerformanceTimerExample(10));
Console.WriteLine($"ActionType Time elapsed: {elapsed}");

// 반환 값이 있는 메소드 측정 방법
var funcElapsed = PerformanceMeter.Check(() => PerformanceTimerFuncExample(5));
Console.WriteLine($"FuncType Time elapsed: {funcElapsed}");
```

### 비동기 메소드

```
private static async Task PerformanceTimerExample(int maxValue)
{
    double n = 0;
    for (int i = 0; i < maxValue; i++)
    {
        n *= 2;

        await Task.Delay(100);
    }
}
```

```
var asyncElapsed = await PerformanceMeter.CheckAsync(async () => await PerformanceTimerExample(13));
Console.WriteLine($"Time elapsed: {asyncElapsed}");
```

