using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KrestikAndNolik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int player;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            sender.GetType().GetProperty("Content").SetValue(sender, "x");
            sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
            chekwin();
            bot();
        }
        public void bot()
        {
            Random random = new Random();
            List<Button> buttons = new List<Button>() { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            int ind = random.Next(buttons.Count);

            while (buttons[ind].IsEnabled == false && buttons.Any(x => x.IsEnabled == true))
            {
                ind = random.Next(buttons.Count);
            }
            buttons[ind].IsEnabled = false;
            buttons[ind].Content = "o";
            buttons.RemoveAt(ind);
            chekwin();
        }
        private void chekwin()
        {
            if (button1.Content == button2.Content && button2.Content == button3.Content)
            {

                if (button1.Content != null)
                {
                    MessageBox.Show("Вы победили!");
                    button1.IsEnabled = false;
                    button2.IsEnabled = false;
                    button3.IsEnabled = false;
                    button4.IsEnabled = false;
                    button5.IsEnabled = false;
                    button6.IsEnabled = false;
                    button7.IsEnabled = false;
                    button8.IsEnabled = false;
                    button9.IsEnabled = false;
                }
            }
            else if (button4.Content == button5.Content && button5.Content == button6.Content)
            {
                if (button4.Content != null)
                {
                    MessageBox.Show("Вы победили!");
                    button1.IsEnabled = false;
                    button2.IsEnabled = false;
                    button3.IsEnabled = false;
                    button4.IsEnabled = false;
                    button5.IsEnabled = false;
                    button6.IsEnabled = false;
                    button7.IsEnabled = false;
                    button8.IsEnabled = false;
                    button9.IsEnabled = false;
                }
            }
            else if (button7.Content == button8.Content && button8.Content == button9.Content)
            {
                if (button7.Content != null)
                {
                    MessageBox.Show("Вы победили!");
                    button1.IsEnabled = false;
                    button2.IsEnabled = false;
                    button3.IsEnabled = false;
                    button4.IsEnabled = false;
                    button5.IsEnabled = false;
                    button6.IsEnabled = false;
                    button7.IsEnabled = false;
                    button8.IsEnabled = false;
                    button9.IsEnabled = false;
                }
            }
            else if (button1.Content == button4.Content && button4.Content == button7.Content)
            {
                if (button1.Content != null)
                {
                    MessageBox.Show("Вы победили!");

                    button1.IsEnabled = false;
                    button2.IsEnabled = false;
                    button3.IsEnabled = false;
                    button4.IsEnabled = false;
                    button5.IsEnabled = false;
                    button6.IsEnabled = false;
                    button7.IsEnabled = false;
                    button8.IsEnabled = false;
                    button9.IsEnabled = false;
                }
            }
            else if (button2.Content == button5.Content && button5.Content == button8.Content)
            {
                if (button2.Content != null)
                {
                    MessageBox.Show("Вы победили!");
                    button1.IsEnabled = false;
                    button2.IsEnabled = false;
                    button3.IsEnabled = false;
                    button4.IsEnabled = false;
                    button5.IsEnabled = false;
                    button6.IsEnabled = false;
                    button7.IsEnabled = false;
                    button8.IsEnabled = false;
                    button9.IsEnabled = false;
                }
            }
            else if (button3.Content == button6.Content && button6.Content == button9.Content)
            {
                if (button3.Content != null)
                {
                    MessageBox.Show("Вы победили!");
                    button1.IsEnabled = false;
                    button2.IsEnabled = false;
                    button3.IsEnabled = false;
                    button4.IsEnabled = false;
                    button5.IsEnabled = false;
                    button6.IsEnabled = false;
                    button7.IsEnabled = false;
                    button8.IsEnabled = false;
                    button9.IsEnabled = false;
                }
            }
            else if (button1.Content == button5.Content && button5.Content == button9.Content)
            {
                if (button1.Content != null)
                {
                    MessageBox.Show("Вы победили!");
                    button1.IsEnabled = false;
                    button2.IsEnabled = false;
                    button3.IsEnabled = false;
                    button4.IsEnabled = false;
                    button5.IsEnabled = false;
                    button6.IsEnabled = false;
                    button7.IsEnabled = false;
                    button8.IsEnabled = false;
                    button9.IsEnabled = false;
                }
            }
            else if (button3.Content == button5.Content && button5.Content == button7.Content)
            {
                if (button3.Content != null)
                {
                    MessageBox.Show("Вы победили!");
                    button1.IsEnabled = false;
                    button2.IsEnabled = false;
                    button3.IsEnabled = false;
                    button4.IsEnabled = false;
                    button5.IsEnabled = false;
                    button6.IsEnabled = false;
                    button7.IsEnabled = false;
                    button8.IsEnabled = false;
                    button9.IsEnabled = false;
                }
            }
            else if (button1.Content != null && button2.Content != null && button3.Content != null && button4.Content != null && button5.Content != null && button6.Content != null && button7.Content != null && button8.Content != null && button9.Content != null)
            {
                MessageBox.Show("Ничья");
                button1.IsEnabled = false;
                button2.IsEnabled = false;
                button3.IsEnabled = false;
                button4.IsEnabled = false;
                button5.IsEnabled = false;
                button6.IsEnabled = false;
                button7.IsEnabled = false;
                button8.IsEnabled = false;
                button9.IsEnabled = false;
            }
        }
        private void replay_Click_1(object sender, RoutedEventArgs e)
        {
            play.Content = "Restart";
            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;

            button1.Content = null;
            button2.Content = null;
            button3.Content = null;
            button4.Content = null;
            button5.Content = null;
            button6.Content = null;
            button7.Content = null;
            button8.Content = null;
            button9.Content = null;
        }
    }
}
