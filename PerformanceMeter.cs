using System.Diagnostics;

namespace PerformanceMeterExample;

public class PerformanceMeter
{
    /// <summary>
    /// 동기 방식의 반환 값이 없는 void형 메서드의 성능을 측정
    /// </summary>
    /// <param name="action">성능을 측정할 메소드</param>
    /// <returns>수행된 작업의 경과 시간</returns>
    public static TimeSpan Check(Action action)
    {
        Stopwatch watch = Stopwatch.StartNew();
        action();
        watch.Stop();

        return watch.Elapsed;
    }

    /// <summary>
    /// 동기 방식의 반환 값이 있는 메서드의 성능을 측정
    /// </summary>
    /// <typeparam name="T">반환 값의 타입</typeparam>
    /// <param name="func">성능을 측정할 Func 메소드</param>
    /// <returns>수행된 작업의 경과 시간</returns>
    public static TimeSpan Check<T>(Func<T> func)
    {
        Stopwatch watch = Stopwatch.StartNew();
        func();
        watch.Stop();

        return watch.Elapsed;
    }

    /// <summary>
    /// 비동기 방식의 메서드의 성능을 측정
    /// </summary>
    /// <param name="func">성능을 측정할 비동기 메소드</param>
    /// <returns>비동기 작업 완료 후 경과 시간</returns>
    public static async Task<TimeSpan> CheckAsync(Func<Task> func)
    {
        Stopwatch watch = Stopwatch.StartNew();
        await func();
        watch.Stop();

        return watch.Elapsed;
    }

}
