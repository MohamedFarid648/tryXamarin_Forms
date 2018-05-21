using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EApp3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class tryPage1 : ContentPage
	{
        List<Question> questions = null; int QuestionIndex = 0;

        public tryPage1 ()
		{
            InitializeComponent();
            btnPrev.IsEnabled = false;

            questions = new List<Question>()
                {

                    new Question(){Id=1,Title="Q1",Content="What is your Favourit PL?"},
                    new Question(){Id=2,Title="Q2",Content="What is your Favourit Fruit?"},
                    new Question(){Id=3,Title="Q3",Content="What is your Favourit Sport?"},
                    new Question(){Id=4,Title="Q4",Content="What is your Favourit Pet?"},
                    new Question(){Id=5,Title="Q5",Content="What is your Favourit Cartoon?"},


                };
            QuestionLabel.Text = questions.ElementAt(0).Content;
            QuestionIndex++;

        }

        private void OnNextClick(object sender, EventArgs e)
        {

            if (QuestionIndex != questions.Count)
            {
                QuestionLabel.Text = questions.ElementAt(QuestionIndex).Content;
                QuestionIndex++;
            }
            else if (QuestionIndex == questions.Count)
            {
                QuestionIndex = questions.Count - 2;//QuestionIndex=3 because questions[4] already appeared so when user click on Prev Button Apper questions[3]
                btnPrev.IsEnabled = true;
                btnNext.IsEnabled = false;


            }
        }
        private void OnPrevClick(object sender, EventArgs e)
        {


            if (QuestionIndex != -1)
            {
                QuestionLabel.Text = questions.ElementAt(QuestionIndex).Content;
                QuestionIndex--;
            }
            else if (QuestionIndex == -1)
            {
                QuestionIndex = 1;
                btnPrev.IsEnabled = false;
                btnNext.IsEnabled = true;

            }
            /* else
             {
                 QuestionIndex++;
                 btnNext.IsEnabled = false;
             }*/

        }


    }


    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }
}