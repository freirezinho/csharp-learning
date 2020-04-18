using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeAPI
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        YouTubeAPI api = new YouTubeAPI();
        List<Videos> videos = api.GetVideos("User_1");
      }
      catch (Exception e)
      {

        Console.WriteLine(e.Message);
      }
    }
  }
  public class YouTubeAPI
  {
    public List<Video> GetVideos(string user)
    {
      try
      {
        throw new Exception("Some low-level YouTube error.");
      }
      catch (Exception e)
      {

        throw new YouTubeException("Could not fetch videos from YouTube.", e);
      }
    }
  }
  public class YouTubeException : Exception
  {
    public YouTubeException(string message, Exception innerException) : base(message, innerException)
    {

    }
  }
}
