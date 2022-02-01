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
    private string name;
    private string certificate;
    private string director;
    private string mainStar;
    [JsonProperty("Poster")]
    private string imageName;
    private System.Drawing.Image movieimage;
    private int runningTime;

    public Movie(string name, string certificate, string director, string mainStar, int runningTime, string imageName, System.Drawing.Image movieimage)
    {
        this.name = name;
        this.imageName = imageName;
        this.certificate = certificate;
        this.director = director;
        this.mainStar = mainStar;
        this.runningTime = runningTime;
        this.movieimage = movieimage;
    }

    public System.Drawing.Image MovieImage
    {
        get { return movieimage; }

        set { movieimage = value; }
    }
    public string ImageName
    {
        get { return imageName; }

        set { imageName = value; }
    }
    public string Name
    {
        get { return name; }

        set { name = value; }
    }

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

