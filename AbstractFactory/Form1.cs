using System.Runtime.CompilerServices;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Show();

            Point startCoordinates = new Point(10, 10);
            Size bSize = new Size(75, 25);
            List<string> commands = new List<string>();
            Client client1 = new Client(new Factory1());
            Client client2 = new Client(new Factory2()); 
            int coordinatesStep = 100;
            int testsNum;

            using (StreamReader reader = new StreamReader("input.txt"))
            {
                testsNum = Int32.Parse(reader.ReadLine());
                for (int i = 0; i < testsNum; i++) commands.Add(reader.ReadLine());
            }

            for(int i = 0;i<testsNum;i++)
            {
                string[] commandsPart = commands[i].Split(' ');

                if (commandsPart[0] == "L")
                {
                    AbstractLabel label = client1.Factory.CreateLabel(commandsPart[1]);
                    label.Location = new Point(startCoordinates.X
                        , startCoordinates.Y + i * coordinatesStep);
                    this.Controls.Add(label);

                    AbstractLabel label1 = client2.Factory.CreateLabel(commandsPart[1]);
                    label1.Location = new Point(startCoordinates.X + coordinatesStep
                        , startCoordinates.Y + i * coordinatesStep);
                    this.Controls.Add(label1);
                }

                if (commandsPart[0] == "B")
                {
                    AbstractButton button = client1.Factory.CreateButton(commandsPart[1]);
                    button.Location = new Point(startCoordinates.X, startCoordinates.Y + i * coordinatesStep);
                    button.Size = bSize;
                    this.Controls.Add(button);

                    AbstractButton button2 = client2.Factory.CreateButton(commandsPart[1]);
                    button2.Location = new Point(startCoordinates.X + coordinatesStep
                        , startCoordinates.Y + i * coordinatesStep);
                    button2.Size = bSize;
                    this.Controls.Add(button2);
                }
            }
        }
    }
}