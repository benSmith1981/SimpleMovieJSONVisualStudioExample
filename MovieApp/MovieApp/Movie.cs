using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

[Serializable]
class Response
{
    [JsonProperty("Search")]
    public List<Movie> search { get; set; }
}

[Serializable]
class Movie
{
    [JsonProperty("Title")]
    public string Title { get; set; }
    private string certificate;
    private string director;
    private string mainStar;
    private int runningTime;

    public Movie(string Title, string certificate, string director, string mainStar, int runningTime)
    {
        this.Title = Title;
        this.certificate = certificate;
        this.director = director;
        this.mainStar = mainStar;
        this.runningTime = runningTime;
    }

/*    public string Name
    {
        get { return name; }

        set { name = value; }
    }*/

    public string Certificate
    {
        get { return certificate; }

        set { certificate = value; }
    }

    public string Director
    {
        get { return director; }

        set { director = value; }
    }

    public string MainStar
    {
        get { return mainStar; }

        set { mainStar = value; }
    }

    public int RunningTime
    {
        get { return runningTime; }

        set { runningTime = value; }
    }
}

