using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BTL_Nhom11_Animation
{
    public partial class MainWindow : Window
    {
        private readonly Storyboard myStoryboard;
        public MainWindow()
        {
            InitializeComponent();

            StackPanel myPanel = new StackPanel();

            #region txtbl1
            TextBlock textBlock1 = new TextBlock();
            textBlock1.Name = "txtbl1";
            this.RegisterName(textBlock1.Name, txtbl1);
            textBlock1.Width = 100;
            textBlock1.Height = 20;
            //textBlock1.Background=Color.FromValues(GreenYellow);

            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = 1.0;
            myDoubleAnimation.To = 0.0;
            myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(2));
            myDoubleAnimation.AutoReverse = true;
            //myDoubleAnimation.RepeatBehavior = RepeatBehavior.Forever;
            myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);
            Storyboard.SetTargetName(myDoubleAnimation, textBlock1.Name);
            Storyboard.SetTargetProperty(myDoubleAnimation, new PropertyPath(TextBlock.OpacityProperty));
            #endregion

            #region txtbl2
            TextBlock textBlock2 = new TextBlock();
            textBlock2.Name = "txtbl2";
            this.RegisterName(txtbl2.Name, txtbl2);
            txtbl2.Height = 20;
            txtbl2.Width = 100;

            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 20.0;
            doubleAnimation.To = 1.0;
            doubleAnimation.AutoReverse = true;
            myStoryboard = new Storyboard();
            myStoryboard.Children.Add(doubleAnimation);
            Storyboard.SetTargetName(doubleAnimation, txtbl2.Name);
            Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(TextBlock.MinHeightProperty));
            #endregion

            #region txtbl3
            TextBlock textBlock3 = new TextBlock();
            textBlock3.Name = "txtbl3";
            this.RegisterName(txtbl3.Name, txtbl3);
            txtbl3.Height = 20;
            txtbl3.Width = 100;
            DoubleAnimation doubleAnimation3 = new DoubleAnimation();
            doubleAnimation3.From = 0.0;
            doubleAnimation3.To = 1.0;
            doubleAnimation3.AutoReverse = true;

            #endregion

            #region txtbl4
            TextBlock textBlock4 = new TextBlock();
            textBlock4.Name = "txtbl4";
            this.RegisterName(txtbl4.Name, txtbl4);
            txtbl4.Height = 20;
            txtbl4.Width = 100;
            txtbl4.Foreground = Brushes.Green;
            ColorAnimationUsingKeyFrames colorAnimation = new ColorAnimationUsingKeyFrames();
            colorAnimation.Duration = TimeSpan.FromSeconds(6);
            Color orangecolor = new Color();
            orangecolor = Color.FromRgb(255, 140, 0);
            Color bluecolor = new Color();
            bluecolor = Color.FromRgb(70, 130, 180);
            Color redcolor = new Color();
            redcolor = Color.FromArgb(255, 0, 255, 0);
            colorAnimation.KeyFrames.Add(new LinearColorKeyFrame(orangecolor, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2.0))));
            colorAnimation.KeyFrames.Add(new DiscreteColorKeyFrame(bluecolor, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2.5))));
            colorAnimation.KeyFrames.Add(new SplineColorKeyFrame(redcolor, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(4.5)), new KeySpline(0.6, 0.0, 0.9, 0.0)));
            colorAnimation.AutoReverse = true;
            myStoryboard = new Storyboard();
            myStoryboard.Children.Add(colorAnimation);
            Storyboard.SetTargetName(colorAnimation, "MySolidColorBrush");
            Storyboard.SetTargetProperty(colorAnimation, new PropertyPath(SolidColorBrush.ColorProperty));
            #endregion

            #region txtbl5
            TextBlock textBlock5 = new TextBlock();
            textBlock5.Name = "txtbl5";
            this.RegisterName(txtbl5.Name, txtbl5);
            txtbl5.Height = 20;
            txtbl5.Width = 100;
            DoubleAnimation doubleAnimation5 = new DoubleAnimation();
            doubleAnimation5.From = 0.0;
            doubleAnimation5.To = 180.0;
            doubleAnimation5.AutoReverse = true;
            myStoryboard = new Storyboard();
            myStoryboard.Children.Add(doubleAnimation5);
            Storyboard.SetTargetName(doubleAnimation5, txtbl5.Name);
            Storyboard.SetTargetProperty(doubleAnimation5, new PropertyPath(TextBlock.LayoutTransformProperty));
            #endregion

            #region txtbl6
            //TextBlock textBlock6 = new TextBlock();
            //textBlock6.Name = "txtbl6";
            //this.RegisterName(txtbl6.Name, txtbl6);
            //txtbl6.Height = 20;
            //txtbl6.Width = 100;
            //Canvas containerCanvas = new Canvas();
            //containerCanvas.Height = 200;
            //containerCanvas.Width = 200;
            //containerCanvas.Children.Add(textBlock6);
            //Canvas.SetTop(textBlock6, 100);
            //Canvas.SetLeft(textBlock6, 10);
            //TranslateTransform Transtf = new TranslateTransform();
            //textBlock6.RenderTransform = Transtf;
            //this.RegisterName("MyTranslatetf",Transtf );
            //DoubleAnimationUsingKeyFrames translationAnimation = new DoubleAnimationUsingKeyFrames();
            //translationAnimation.Duration = TimeSpan.FromSeconds(6);
            //translationAnimation.KeyFrames.Add(new LinearDoubleKeyFrame(50, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(3))));
            //translationAnimation.KeyFrames.Add(new DiscreteDoubleKeyFrame(40, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(4))));
            //translationAnimation.KeyFrames.Add(new SplineDoubleKeyFrame(0, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(6)),new KeySpline(0.6,0.0,0.9,0.0)));
            //translationAnimation.AutoReverse = true;
            //Storyboard.SetTargetProperty(translationAnimation, new PropertyPath(TranslateTransform.XProperty));
            //Storyboard translationStoryboard = new Storyboard();
            //translationStoryboard.Children.Add(translationAnimation);
            //Content = containerCanvas;
            #endregion

            #region txtbl6
            TextBlock textBlock6 = new TextBlock();
            textBlock6.Name = "txtbl6";
            //this.RegisterName(txtbl7.Name, textBlock7);
            textBlock6.Height = 20;
            textBlock6.Width = 100;
            Canvas contCanvas = new Canvas();
            contCanvas.Height = 100;
            contCanvas.Width = 400;
            contCanvas.Children.Add(textBlock6);
            Canvas.SetTop(textBlock6, 10);
            Canvas.SetLeft(textBlock6, 145);
            DoubleAnimation doubleAnimation6 = new DoubleAnimation();
            doubleAnimation6.From = 0.0;
            doubleAnimation6.To = 200.0;
            doubleAnimation6.AutoReverse = true;
            doubleAnimation6.Duration = TimeSpan.FromSeconds(5);
            DoubleAnimationUsingKeyFrames usingKeyFrames6 = new DoubleAnimationUsingKeyFrames();
            usingKeyFrames6.AutoReverse = true;
            usingKeyFrames6.Duration = TimeSpan.FromSeconds(2);
            usingKeyFrames6.KeyFrames.Add(new LinearDoubleKeyFrame(0, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))));
            usingKeyFrames6.KeyFrames.Add(new LinearDoubleKeyFrame(50, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(5))));
            usingKeyFrames6.KeyFrames.Add(new LinearDoubleKeyFrame(100, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))));
            usingKeyFrames6.KeyFrames.Add(new LinearDoubleKeyFrame(50, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.5))));
            usingKeyFrames6.KeyFrames.Add(new LinearDoubleKeyFrame(0, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2))));
            myStoryboard = new Storyboard();
            myStoryboard.Children.Add(usingKeyFrames6);
            Storyboard.SetTargetName(usingKeyFrames6, txtbl6.Name);
            Storyboard.SetTargetProperty(usingKeyFrames6, new PropertyPath(TextBlock.RenderTransformProperty));
            #endregion

            #region txtl7
            TextBlock textBlock7 = new TextBlock();
            textBlock7.Name = "txtbl7";
            this.RegisterName(txtbl7.Name, txtbl7);
            txtbl7.Height = 20;
            txtbl7.Width = 100;
            DoubleAnimation doubleAnimation7 = new DoubleAnimation();
            doubleAnimation7.From = 100;
            doubleAnimation7.To = 0;
            doubleAnimation7.AutoReverse = true;
            myStoryboard = new Storyboard();
            myStoryboard.Children.Add(doubleAnimation7);
            Storyboard.SetTargetName(myStoryboard, txtbl7.Name);
            Storyboard.SetTargetProperty(doubleAnimation7, new PropertyPath(TextBlock.MinWidthProperty));
            #endregion

            #region txtbl8
            TextBlock textBlock8 = new TextBlock();
            textBlock8.Name = "txtbl8";
            this.RegisterName(txtbl8.Name, txtbl8);
            txtbl8.Height = 20;
            txtbl8.Width = 100;
            DoubleAnimation doubleAnimation8 = new DoubleAnimation();
            doubleAnimation8.AutoReverse = true;
            myStoryboard = new Storyboard();
            myStoryboard.Children.Add(doubleAnimation8);
            Storyboard.SetTargetName(myStoryboard, txtbl8.Name);
            Storyboard.SetTargetProperty(doubleAnimation8, new PropertyPath(TextBlock.MarginProperty));
            #endregion

            #region txtbl9
            TextBlock textBlock9 = new TextBlock();
            textBlock9.Name = "txtbl9";
            this.RegisterName(txtbl9.Name, txtbl9);
            txtbl9.Height = 20;
            txtbl9.Width = 100;
            DoubleAnimation doubleAnimation9 = new DoubleAnimation();
            doubleAnimation9.AutoReverse = true;
            myStoryboard = new Storyboard();
            myStoryboard.Children.Add(doubleAnimation9);
            Storyboard.SetTargetName(myStoryboard, txtbl9.Name);
            Storyboard.SetTargetProperty(doubleAnimation9, new PropertyPath(TextBlock.TextAlignmentProperty));
            #endregion
        }
        #region txtbl11
        private void ckFloatIn_Checked(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation animation = new ThicknessAnimation
            {
                To = new Thickness(txtblFloatIn.Margin.Left, txtblFloatIn.Margin.Top - 20, txtblFloatIn.Margin.Right, txtblFloatIn.Margin.Bottom),
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = false,
                RepeatBehavior = RepeatBehavior.Forever
            };
            txtblFloatIn.BeginAnimation(Button.MarginProperty, animation);
        }
        private void ckFloatIn_Unchecked(object sender, RoutedEventArgs e)
        {
            txtblFloatIn.BeginAnimation(Button.MarginProperty, null);
        }
        #endregion

        #region txtbl12
        private void ckFloatOut_Checked(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation animation = new ThicknessAnimation
            {
                To = new Thickness(txtblFloatOut.Margin.Left, txtblFloatOut.Margin.Top + 20, txtblFloatOut.Margin.Right, txtblFloatOut.Margin.Bottom),
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = false,
                RepeatBehavior = RepeatBehavior.Forever
            };
            txtblFloatOut.BeginAnimation(Button.MarginProperty, animation);
        }
        private void ckFloatOut_Unchecked(object sender, RoutedEventArgs e)
        {
            txtblFloatOut.BeginAnimation(Button.MarginProperty, null);
        }
        #endregion
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            myStoryboard.Begin(this);
        }

        private void ckFloatIn_(object sender, RoutedEventArgs e)
        {

        }
    }
}
