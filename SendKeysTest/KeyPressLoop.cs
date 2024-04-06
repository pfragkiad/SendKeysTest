using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendKeysTest;

public class KeyPressLoop
{
    private CancellationTokenSource? _cancelSource;


    public bool IsRunning => _cancelSource is not null;

    public int DelayBetweenLoopsInMs { get; set; }
    public Dictionary<Keys, int>? KeyDurationsInMs { get; private set; }

    #region Loop timing

    public DateTime? LastStartTime { get; private set; }
    public DateTime? NextLoopStartTime =>
        LastStartTime?.AddMilliseconds(DelayBetweenLoopsInMs);

    public TimeSpan? RemainingTimeUntilNextLoopStartTime =>
        LastStartTime is null ? null :  NextLoopStartTime - DateTime.Now;

    #endregion


    public async Task<bool> StartMultipleKeysLoop(
        Dictionary<Keys, int> keyDurationsInMs,
        int delayBetweenLoopsInMs,
        string windowCaption)
    {
        try
        {
            //property values are allowed to change externally
            KeyDurationsInMs = keyDurationsInMs;
            DelayBetweenLoopsInMs = delayBetweenLoopsInMs;

            _cancelSource = new();
            while (true)
            {
                LastStartTime = DateTime.Now;
                if (!await KeyPresser.SendMultipleKeys(KeyDurationsInMs, windowCaption))
                    return false;

                await Task.Delay(DelayBetweenLoopsInMs, _cancelSource.Token);
            }
        }
        catch (TaskCanceledException)
        {
            return true;
        }
        finally
        {
            _cancelSource = null;
            LastStartTime = null;
        }
    }

    public void CancelLoop() => _cancelSource?.Cancel();

}
