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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace OOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        car auto1;
        car auto2;
        DispatcherTimer timer;
        public MainWindow()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Tick += Timer_Tick;

            InitializeComponent();



            auto1 = new car("Škoda");
            auto1.Type = "osobní auto";
            ShowVehicle(auto1, txt1);

            auto2 = new car("VW");
            auto2.Type = "Dodávka";
            ShowVehicle(auto2, txt2);


        }
        public void ShowVehicle(car car, TextBox textBox)
        {
            textBox.Text = $"Brand: {car.Brand}\n";
            textBox.Text += $"Type: {car.Type}\n";
            textBox.Text += $"Fuel: {car.Fuel}\n";
            textBox.Text += $"Engine volume: {car.EngineVolume}\n";
            textBox.Text += $"Fuel level: {car.FuelLevel}\n";
            textBox.Text += $"Distance: {car.Distance}\n";
            textBox.Text += $"Pneu stav: {Math.Round(car.PneuState, 2)}\n";
            textBox.Text += $"Speedometr: {car.Speedometer}km/h\n";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            auto1.Move();
            auto2.Move();
            ShowVehicle(auto1, txt1);
            ShowVehicle(auto2, txt2);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            auto1.Move();
            auto2.Move();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            auto1.FuelLevel = 100;
            auto2.FuelLevel = 100;
            ShowVehicle(auto1, txt1);
            ShowVehicle(auto2, txt2);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            auto1.PneuState = 100;
            auto2.PneuState = 100;
            ShowVehicle(auto1, txt1);
            ShowVehicle(auto2, txt2);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            auto1.SpeedometrUp();
            ShowVehicle(auto1, txt1);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            auto1.SpeedometrDown();
            ShowVehicle(auto1, txt1);
            ShowVehicle(auto2, txt2);
        }
    }
}
