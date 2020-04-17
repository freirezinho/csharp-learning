using System;

namespace events2
{
  public delegate void ProgressChangeHandler(int percent, int changedValue);
  class Program
  {
    static void Main(string[] args)
    {
      ProgressBar progressBar = new ProgressBar(30);
      progressBar.Progress = 30;
      progressBar.ProgressChanged += OnProgressChanged;
      progressBar.Progress = 30;
      progressBar.Progress = 60;
    }
    private static void OnProgressChanged(int percent, int changedValue)
    {
      Console.WriteLine("OnProgressChanged event");
      Console.WriteLine("Progressed from {0} to {1}", percent, changedValue);
    }
  }

  class ProgressBar
  {
    int percent;
    int oldPercent;

    public ProgressBar(int _percent)
    {
      percent = _percent;
    }

    public event ProgressChangeHandler ProgressChanged;

    public int Progress
    {
      get
      {
        return percent;
      }
      set
      {
        if (percent == value)
          return;
        if (ProgressChanged != null)
          ProgressChanged(percent, value);

        oldPercent = percent;
        percent = value;

      }
    }
  }
}
