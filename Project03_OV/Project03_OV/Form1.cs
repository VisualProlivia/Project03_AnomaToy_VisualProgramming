using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project03_OV
{
    public partial class GameFrame : Form
    {
        public GameFrame()
        {
            InitializeComponent();
        }

        // Declarations
        const int FINISHED_TOYS = 3;
        decimal points = 0;
        string toyType = "";
        static Random rand = new Random();
        TeddyBear base1 = new TeddyBear();      TeddyBear compare1 = new TeddyBear();
        SpinningTop base2 = new SpinningTop();  SpinningTop compare2 = new SpinningTop();
        Doll base3 = new Doll();                Doll compare3 = new Doll();
        Pinwheel base4 = new Pinwheel();        Pinwheel compare4 = new Pinwheel();
        StickHorse base5 = new StickHorse();    StickHorse compare5 = new StickHorse();

        // Not all objs are used in the current demo.
        // Further iterations will make use of these objects.

        // Run when Game is first loaded
        private void GameFrame_Load(object sender, EventArgs e)
        {
            // Call to set game up on load
            SetGameUp();
        }

        // If button that leads to Toy Manual is clicked
        private void btnManual_Click(object sender, EventArgs e)
        {
            // Open and show Toy Manual form if Manual is not open yet
            ManualFrame manual = new ManualFrame();

            // Check to see if Manual form is already open. Avoid multiple instances
            foreach (Form form in Application.OpenForms)
            {
                if(form.Name == "ManualFrame")
                {
                    form.Dispose();
                    break;
                }
            }
            
            // Open instance
            manual.Show();
        }

        // If picture of toy is clicked 
        private void pboxToy_Click(object sender, EventArgs e)
        {
            // Get information about the toy and display
            if (toyType == "TeddyBear")
            {
                tBoxHeight.Text = compare1.height.ToString();
                tBoxWeight.Text = compare1.weight.ToString();

                // If the toy has an accessory, show that info
                if (compare1.accessory)
                {
                    pboxAccessoryYN.Image = Properties.Resources.Checkmark;
                }
                else
                {
                    pboxAccessoryYN.Image = Properties.Resources.XonRedBG;
                }
            }
            else if (toyType == "SpinningTop")
            {
                tBoxHeight.Text = compare2.height.ToString();
                tBoxWeight.Text = compare2.weight.ToString();

                // If the toy has an accessory, show that info
                if (compare2.accessory)
                {
                    pboxAccessoryYN.Image = Properties.Resources.Checkmark;
                }
                else
                {
                    pboxAccessoryYN.Image = Properties.Resources.XonRedBG;
                }
            }
            else if (toyType == "Doll")
            {
                tBoxHeight.Text = compare3.height.ToString();
                tBoxWeight.Text = compare3.weight.ToString();

                // If the toy has an accessory, show that info
                if (compare3.accessory)
                {
                    pboxAccessoryYN.Image = Properties.Resources.Checkmark;
                }
                else
                {
                    pboxAccessoryYN.Image = Properties.Resources.XonRedBG;
                }
            }
            else if (toyType == "Pinwheel")
            {
                tBoxHeight.Text = compare4.height.ToString();
                tBoxWeight.Text = compare4.weight.ToString();

                // If the toy has an accessory, show that info
                if (compare4.accessory)
                {
                    pboxAccessoryYN.Image = Properties.Resources.Checkmark;
                }
                else
                {
                    pboxAccessoryYN.Image = Properties.Resources.XonRedBG;
                }
            }
            else if (toyType == "StickHorse")
            {
                tBoxHeight.Text = compare5.height.ToString();
                tBoxWeight.Text = compare5.weight.ToString();

                // If the toy has an accessory, show that info
                if (compare5.accessory)
                {
                    pboxAccessoryYN.Image = Properties.Resources.Checkmark;
                }
                else
                {
                    pboxAccessoryYN.Image = Properties.Resources.XonRedBG;
                }
            }
            else
            {
                // Something went wrong, tell user
                MessageBox.Show("Error Caught", "Error found.");
            }
        }

        // If button to mark toy as bad/anomalous is clicked
        private void btnBad_Click(object sender, EventArgs e)
        {
            // Figure out if the item has something wrong with it
            bool found = CompareWithBase(toyType);

            // If a difference is found, the player is correct to push this button
            // They gain points
            if (found)
            {
                // Add to points and display
                points += 50;
                lblScoreNum.Text = points.ToString("000000");
            }
            else
            {
                // A difference was not found, this click was incorrect
                // Deduct points and display
                points -= 25;
                if (points < 0)
                { points = 0; }
                lblScoreNum.Text = points.ToString("000000");
            }

            // Re-set up game
            SetGameUp();
        }

        // If button to mark toy as good is clicked
        private void btnGood_Click(object sender, EventArgs e)
        {
            // Figure out if the item has something wrong with it
            bool found = CompareWithBase(toyType);

            // If a difference is not found, the player is correct to push this button
            // They gain points
            if (!found)
            {
                // Add to points and display
                points += 50;
                lblScoreNum.Text = points.ToString("000000");
            }
            else
            {
                // A difference was found, this click was incorrect
                // Deduct points and display
                points -= 25;
                if (points < 0)
                { points = 0; }
                lblScoreNum.Text = points.ToString("000000");
            }

            // Re-set up game
            SetGameUp();
        }

        // Methods and Functions
        public void SetGameUp()
        {
            // Make sure all text boxes are clear at first
            tBoxHeight.Text = string.Empty;
            tBoxWeight.Text = string.Empty;

            // Get random number to pick toy
            int pick = rand.Next(0, FINISHED_TOYS);
            
            // Pick toy to generate based on random number
            switch (pick)
            {
                case 0:     // Display Teddy Bear
                    pboxToy.Image = Properties.Resources.TeddyBear_var01;
                    toyType = "TeddyBear";
                    break;
                case 1:     // Display Spinning Top
                    pboxToy.Image = Properties.Resources.SpinningTop_var01;
                    toyType = "SpinningTop";
                    break;
                case 2:     // Display Doll
                    pboxToy.Image = Properties.Resources.Doll_var01;
                    toyType = "Doll";
                    break;
                case 3:     // Display Pinwheel
                    // pboxToy.Image = Properties.Resources.;
                    toyType = "Pinwheel";
                    break;
                case 4:     // Display Stick Horse
                    // pboxToy.Image = Properties.Resources.;
                    toyType = "StickHorse";
                    break;
            }

            // Make one of the parts anomalous if number is picked
            // Less likely to find anomalous toys based on rand
            pick = rand.Next(0, FINISHED_TOYS+10);

            switch (pick)
            {
                case 0:     // Alter .accessory
                    compare1.accessory = false;
                    compare2.accessory = true;
                    compare3.accessory = false;
                    compare4.accessory = true;
                    compare5.accessory = true;
                    break;
                case 1:     // Alter .height by increasing
                    compare1.height += 2f;
                    compare2.height += 2f;
                    compare3.height += 5.5f;
                    compare4.height += 0.5f;
                    compare5.height += 2f;
                    break;
                case 2:     // Alter .weight by increasing
                    compare1.weight += 2f;
                    compare2.weight += 2f;
                    compare3.weight += 2f;
                    compare4.weight += 2f;
                    compare5.weight += 31f;
                    break;
                case 3:     // Alter .height by decreasing
                    compare1.height -= 1f;
                    compare2.height -= 1f;
                    compare3.height -= 1f;
                    compare4.height -= 0.5f;
                    compare5.height -= 3f;
                    break;
                case 4:     // Alter .weight by decreasing
                    compare1.weight -= 0.5f;
                    compare2.weight -= 1f;
                    compare3.weight -= 2f;
                    compare4.weight -= 1.5f;
                    compare5.weight -= 6f;
                    break;
                default:
                    // No changes
                    break;
            }
        }

        public bool CompareWithBase(string toy)
        {
            // This will check all values in compare(#) and base(#)
            // then return if they are all the same (result false)
            // or if there is a difference found (result true)
            bool isAnomalous = true;

            // Get toy and compare to base version
            if (toy == "TeddyBear")
            {
                // Start comparing comparable to base
                if (compare1.color.Equals(base1.color))
                {
                    if (compare1.height == base1.height)
                    {
                        if (compare1.weight == base1.weight)
                        {
                            if (compare1.accessory)
                            {
                                // base1 accessory is always true, short-circuit last if
                                // All items match, no anomalous properties found
                                isAnomalous = false;
                            }
                        }
                    }
                }
            }
            else if (toy == "SpinningTop")
            {
                // Start comparing comparable to base
                if (compare2.color.Equals(base2.color))
                {
                    if (compare2.height == base2.height)
                    {
                        if (compare2.weight == base2.weight)
                        {
                            if (!compare2.accessory)
                            {
                                // base2 accessory is always false, short-circuit last if
                                // All items match, no anomalous properties found
                                isAnomalous = false;
                            }
                        }
                    }
                }
            }
            else if (toy == "Doll")
            {
                // Start comparing comparable to base
                if (compare3.color.Equals(base3.color))
                {
                    if (compare3.height == base3.height)
                    {
                        if (compare3.weight == base3.weight)
                        {
                            if (compare3.accessory)
                            {
                                // base3 accessory is always true, short-circuit last if
                                // All items match, no anomalous properties found
                                isAnomalous = false;
                            }
                        }
                    }
                }
            }
            else if (toy == "Pinwheel")
            {
                // Start comparing comparable to base
                if (compare4.color.Equals(base4.color))
                {
                    if (compare4.height == base4.height)
                    {
                        if (compare4.weight == base4.weight)
                        {
                            if (!compare4.accessory)
                            {
                                // base4 accessory is always false, short-circuit last if
                                // All items match, no anomalous properties found
                                isAnomalous = false;
                            }
                        }
                    }
                }
            }
            else if (toy == "StickHorse")
            {
                // Start comparing comparable to base
                if (compare5.color.Equals(base5.color))
                {
                    if (compare5.height == base5.height)
                    {
                        if (compare5.weight == base5.weight)
                        {
                            if (!compare5.accessory)
                            {
                                // base5 accessory is always false, short-circuit last if
                                // All items match, no anomalous properties found
                                isAnomalous = false;
                            }
                        }
                    }
                }
            }
            else
            {
                // Something has gone wrong, time to deliver a messagebox
                MessageBox.Show("Uhh ohhh","Stinkyyy");
            }
            
            // Return the boolean value
            return isAnomalous;
        }

    }
}

// Classes / Objects
class Toy
{
    private string _color;
    private float _height, _weight;
    private bool _accessory;
    public string color
    {
        set { _color = value; }
        get { return _color; }
    }

    public float height
    {
        set { _height = value; }
        get { return _height; }
    }

    public float weight
    {
        set { _weight = value; }
        get { return _weight; }
    }

    public bool accessory
    {
        set { _accessory = value; }
        get { return _accessory; }
    }
}

class TeddyBear : Toy
{
    // Basic constructor using "correct" params
    public TeddyBear()
    {
        this.color = "Brown";
        this.height = 12f;
        this.weight = 5.5f;
        this.accessory = true;
    }
}

class SpinningTop : Toy
{
    // Basic constructor using "correct" params
    public SpinningTop()
    {
        this.color = "Yellow";
        this.height = 4f;
        this.weight = 2f;
        this.accessory = false;
    }
}

class Doll : Toy
{
    // Basic constructor using "correct" params
    public Doll()
    {
        this.color = "Pink";
        this.height = 10f;
        this.weight = 4.5f;
        this.accessory = true;
    }
}

class Pinwheel : Toy
{
    // Use for later versions
    // Basic constructor using "correct" params
    public Pinwheel()
    {
        this.color = "Red";
        this.height = 6f;
        this.weight = 1f;
        this.accessory = false;
    }
}

class StickHorse : Toy
{
    // Use for later versions
    // Basic constructor using "correct" params
    public StickHorse()
    {
        this.color = "Brown";
        this.height = 36f;
        this.weight = 5f;
        this.accessory = false;
    }
}