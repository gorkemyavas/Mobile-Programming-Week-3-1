using Xamarin.Forms;

namespace Week_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            var formattedString = new FormattedString();

            formattedString.Spans.Add(
                new Span()
                {
                    Text = "\tI\t",

                });
            formattedString.Spans.Add(
                new Span()
                {
                    Text = "\tLove\t",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    FontAttributes = FontAttributes.Bold

                });
            formattedString.Spans.Add(
                new Span()
                {
                    Text = "\tXamarin.Forms!!!\t",
                    //FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    BackgroundColor = Color.Tomato,
                    ForegroundColor = Color.White,
                    FontAttributes = FontAttributes.Italic

                });

            Content = new Label
            {
                FormattedText = formattedString,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            }; ;






            InitializeComponent();
        }
    }
}