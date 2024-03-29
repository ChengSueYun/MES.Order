using System;
using System.Threading;
using System.Threading.Tasks;

namespace MES.Order.UI
{
    public class AntWorkManager
    {
        private static volatile bool s_isStart;

        public static void Start(Action action, SynchronizationContext context, TimeSpan interval)
        {
            if (action == null)
            {
                throw new ArgumentNullException("action");
            }

            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            if (s_isStart)
            {
                return;
            }

            s_isStart = true;

            Task.Factory.StartNew(() =>
                                  {
                                      while (s_isStart)
                                      {
                                          try
                                          {
                                              context.Send(p => { action.Invoke(); }, null);
                                          }
                                          catch (Exception ex)
                                          {
                                              //TODO:Log 'ex.ToString()' to DB or File
                                              //任務不能中斷，但一定要記錄，否則永遠沒人知道為什麼失敗
                                              Console.WriteLine(ex.ToString());
                                          }
                                          finally
                                          {
                                              //空轉，等待
                                              SpinWait.SpinUntil(() => !s_isStart, interval);
                                          }
                                      }
                                  });
        }

        public static void Stop()
        {
            s_isStart = false;
            s_isStart = false;
        }
    }
}