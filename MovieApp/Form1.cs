using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MovieApp
{
    public partial class Form1 : Form
    {
        List<Movie> movies = new List<Movie>();
        int currentIndex = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                movies = await MovieDataService.GetMoviesString();
                Console.WriteLine(movies[0].Name);
                displayData(movies[0]);
            });


/*            
            movies.Add(new Movie("Creed II", "12A", "Steven Caple Jr.", "Michael B. Jordan", 130,"creed2.jpg",Properties.Resources.creed2));
            movies.Add(new Movie("A Star is Born", "15", "Bradley Cooper", "Lady Gaga", 136, "StarIsBorn.jpg", Properties.Resources.creed2));
            movies.Add(new Movie("Robin Hood", "12A", "Marc Forster", "Taron Egerton", 116, "Grinch.jpg", Properties.Resources.creed2));
            movies.Add(new Movie("The Grinch", "U", "Peter Candeland", "Benedict Cumberbatch", 90, "Grinch.jpg", Properties.Resources.creed2));
            movies.Add(new Movie("Aquaman", "12A", "James Wan", "Jason Momoa", 143, "Grinch.jpg", Properties.Resources.creed2));
            movies.Add(new Movie("Bohemian Rhapsody", "12A", "Bryan Singer", "Rami Malek", 134, "Grinch.jpg", Properties.Resources.creed2));
*/
            //displayData(movies[0]);

        }

        private void displayData(Movie movie)
        {
            movieTitleTextBox.Text = movie.Name;
            directorTextBox.Text = movie.Director;

            //pictureBox1.ImageLocation = "C:/Users/bsmith/source/repos/MovieApp/MovieApp/Resources/" + movie.ImageName;
            //pictureBox1.Image = movie.MovieImage;
            pictureBox1.LoadAsync(movie.ImageName);
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            currentIndex = currentIndex + 1;
            if (currentIndex >= movies.Count)
            {
                currentIndex = 0;
            }
            displayData(movies[currentIndex]);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            
            currentIndex = currentIndex - 1;
            if(currentIndex < 0)
            {
                currentIndex = movies.Count-1;
            }
            displayData(movies[currentIndex]);
        }
    }
}
