using System.Diagnostics.Eventing.Reader;

namespace ataletmakinesonn
{
    public partial class Form1 : Form
    {
        string tempParam = "";
        public string Temporary
        {
            get { return tempParam; }
        }




        public Form1()
        {
            InitializeComponent();


            comboBoxS.SelectedIndexChanged += ComboBoxS_SelectedIndexChanged;

        }

        private void ComboBoxS_SelectedIndexChanged(object sender, EventArgs e)
        {

            var comboBoxValue2 = comboBoxS.GetItemText(comboBoxS.SelectedItem);
            if (comboBoxValue2 != null && comboBoxValue2 == "Küp")
            {
                textBoxa.Visible = true;
                labela.Visible = true;
                textBoxb.Visible = false;
                labelb.Visible = false;
                textBoxh.Visible = false;
                labelh.Visible = false;
                textBoxr.Visible = false;
                labelr.Visible = false;


            }
            if (comboBoxValue2 != null && comboBoxValue2 == "Dikdörtgen Prizma")
            {
                textBoxa.Visible = true;
                labela.Visible = true;
                textBoxb.Visible = true;
                labelb.Visible = true;
                textBoxh.Visible = true;
                labelh.Visible = true;
                textBoxr.Visible = false;
                labelr.Visible = false;


            }
            if (comboBoxValue2 != null && comboBoxValue2 == "Küre")
            {
                textBoxa.Visible = false;
                labela.Visible = false;
                textBoxb.Visible = false;
                labelb.Visible = false;
                textBoxh.Visible = false;
                labelh.Visible = false;
                textBoxr.Visible = true;
                labelr.Visible = true;


            }
            if (comboBoxValue2 != null && comboBoxValue2 == "Silindir")
            {
                textBoxa.Visible = false;
                labela.Visible = false;
                textBoxb.Visible = false;
                labelb.Visible = false;
                textBoxh.Visible = true;
                labelh.Visible = true;
                textBoxr.Visible = true;
                labelr.Visible = true;


            }
            if (comboBoxValue2 != null && comboBoxValue2 == "Konik Prizma")
            {
                textBoxa.Visible = false;
                labela.Visible = false;
                textBoxb.Visible = false;
                labelb.Visible = false;
                textBoxh.Visible = true;
                labelh.Visible = true;
                textBoxr.Visible = true;
                labelr.Visible = true;



            }
            if (comboBoxValue2 != null && comboBoxValue2 == "Piramit")
            {
                textBoxa.Visible = true;
                labela.Visible = true;
                textBoxb.Visible = true;
                labelb.Visible = true;
                textBoxh.Visible = true;
                labelh.Visible = true;
                textBoxr.Visible = false;
                labelr.Visible = false;



            }
            if (comboBoxValue2 != null && comboBoxValue2 == "Paralelkenar Prizma")
            {
                textBoxa.Visible = true;
                labela.Visible = true;
                textBoxb.Visible = true;
                labelb.Visible = true;
                textBoxh.Visible = true;
                labelh.Visible = true;
                textBoxr.Visible = false;
                labelr.Visible = false;



            }
            if (comboBoxValue2 != null && comboBoxValue2 == "Tetraedar")
            {
                textBoxa.Visible = true;
                labela.Visible = true;
                textBoxb.Visible = true;
                labelb.Visible = true;
                textBoxh.Visible = false;
                labelh.Visible = false;
                textBoxr.Visible = false;
                labelr.Visible = false;


            }
            if (comboBoxValue2 != null && comboBoxValue2 == "Koni")
            {
                textBoxa.Visible = false;
                labela.Visible = false;
                textBoxb.Visible = false;
                labelb.Visible = false;
                textBoxh.Visible = true;
                labelh.Visible = true;
                textBoxr.Visible = true;
                labelr.Visible = true;



            }
            if (comboBoxValue2 != null && comboBoxValue2 == "Dodekaedron")
            {
                textBoxa.Visible = true;
                labela.Visible = true;
                textBoxb.Visible = true;
                labelb.Visible = true;
                textBoxh.Visible = false;
                labelh.Visible = false;
                textBoxr.Visible = true;
                labelr.Visible = true;


            }
        }

        public void buttonH_Click(object sender, EventArgs e)
        {

            double V;
            double Density;
            double Mass;
            double Inertia;
            double a = 0;
            double b = 0;
            double h = 0;
            double r = 0;



            string texta = textBoxa.Text;
            if (!string.IsNullOrWhiteSpace(texta) && !double.TryParse(texta, out a))
            {
                MessageBox.Show("Hatalı giriş yaptınız. Lütfen sayı giriniz.");
            }


            string textb = textBoxb.Text; 

                if (!string.IsNullOrWhiteSpace(textb) && !double.TryParse(textb, out b))
                {
                    MessageBox.Show("Hatalı giriş yaptınız. Lütfen sayı giriniz.");

                }

            string textr = textBoxr.Text;
            if (!string.IsNullOrWhiteSpace(textr) && !double.TryParse(textr, out r))
            {
                MessageBox.Show("Hatalı giriş yaptınız. Lütfen sayı giriniz.");
            }


            string texth = textBoxh.Text;
            if (!string.IsNullOrWhiteSpace(texth) && !double.TryParse(texth, out h))
            {
                MessageBox.Show("Hatalı giriş yaptınız. Lütfen sayı giriniz.");
                
            }



            var comboBoxValue1 = comboBoxM.GetItemText(comboBoxM.SelectedItem);

            Density = 1;

            if (comboBoxValue1 != null && comboBoxValue1 == "Çelik")
            {
                Density = 7.85;

            }
            else if (comboBoxValue1 != null && comboBoxValue1 == "Ahşap")
            {
                Density = 0.75;
            }
            else if (comboBoxValue1 != null && comboBoxValue1 == "Kauçuk")
            {
                Density = 1.20;
            }
            else if (comboBoxValue1 != null && comboBoxValue1 == "Plastik")
            {
                Density = 1.10;
            }
            else if (comboBoxValue1 != null && comboBoxValue1 == "Titanyum")
            {
                Density = 4.51;
            }
            else if (comboBoxValue1 != null && comboBoxValue1 == "Cam")
            {
                Density = 2.48;
            }
            else if (comboBoxValue1 != null && comboBoxValue1 == "Alüminyum")
            {
                Density = 2.7;
            }
            else if (comboBoxValue1 != null && comboBoxValue1 == "Bakır")
            {
                Density = 8.96;
            }
            else if (comboBoxValue1 != null && comboBoxValue1 == "Altın")
            {
                Density = 19.32;
            }
            else if (comboBoxValue1 != null && comboBoxValue1 == "Gümüş")
            {
                Density = 10.49;
            }



            var comboBoxValue2 = comboBoxS.GetItemText(comboBoxS.SelectedItem);


            if (comboBoxValue2 != null && comboBoxValue2 == "Küp")
            {





                tempParam = "Küp";
                V = Math.Pow(a, 3);
                Mass = V * Density;
                Inertia = (1.0 / 6.0) * Mass * a * a;

                labelVolumeOut.Text = Convert.ToString(V);
                labelMassOut.Text = Convert.ToString(Mass);
                labelInertiaOut.Text = Convert.ToString(Inertia);




            }
            else
            if (comboBoxValue2 != null && comboBoxValue2 == "Dikdörtgen Prizma")


            {


                tempParam = "Dikdörtgen Prizma";
                V = a * b * h;
                Mass = V * Density;
                Inertia = (1.0 / 12.0) * Mass * (a * a + b * b);

                labelVolumeOut.Text = Convert.ToString(V);
                labelMassOut.Text = Convert.ToString(Mass);
                labelInertiaOut.Text = Convert.ToString(Inertia);
            }
            else
            if (comboBoxValue2 != null && comboBoxValue2 == "Küre")
            {


                tempParam = "Küre";

                V = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
                Mass = V * Density;
                Inertia = (2.0 / 5.0) * Mass * r * r;

                labelVolumeOut.Text = Convert.ToString(V);
                labelMassOut.Text = Convert.ToString(Mass);
                labelInertiaOut.Text = Convert.ToString(Inertia);
            }
            else
            if (comboBoxValue2 != null && comboBoxValue2 == "Silindir")
            {


                tempParam = "Silindir";
                V = Math.PI * Math.Pow(r, 2) * h;
                Mass = V * Density;
                Inertia = (1.0 / 2.0) * Mass * r * r;

                labelVolumeOut.Text = Convert.ToString(V);
                labelMassOut.Text = Convert.ToString(Mass);
                labelInertiaOut.Text = Convert.ToString(Inertia);

            }
            else if (comboBoxValue2 != null && comboBoxValue2 == "Konik Prizma")
            {


                tempParam = "Konik Prizma";
                V = (1.0 / 3.0) * Math.PI * Math.Pow(r, 2) * h;
                Mass = V * Density;
                Inertia = (3.0 / 10.0) * Mass * r * r;

                labelVolumeOut.Text = Convert.ToString(V);
                labelMassOut.Text = Convert.ToString(Mass);
                labelInertiaOut.Text = Convert.ToString(Inertia);
            }
            else if (comboBoxValue2 != null && comboBoxValue2 == "Piramit")
            {




                tempParam = "Piramit";
                V = (1.0 / 3.0) * a * b * h;
                Mass = V * Density;
                Inertia = (1.0 / 3.0) * Mass * a * b * h;

                labelVolumeOut.Text = Convert.ToString(V);
                labelMassOut.Text = Convert.ToString(Mass);
                labelInertiaOut.Text = Convert.ToString(Inertia);
            }
            else if (comboBoxValue2 != null && comboBoxValue2 == "Paralelkenar Prizma")
            {


                tempParam = "Paralelkenar Prizma";
                V = a * b * h;
                Mass = V * Density;
                Inertia = (1 / 3) * Mass * (a * b) * h * (a * a + b * b) / 12;

                labelVolumeOut.Text = Convert.ToString(V);
                labelMassOut.Text = Convert.ToString(Mass);
                labelInertiaOut.Text = Convert.ToString(Inertia);
            }
            else if (comboBoxValue2 != null && comboBoxValue2 == "Tetraedar")
            {
                tempParam = "Tetraedar";
                V = (1.0 / 6.0) * Math.Sqrt(2) * Math.Pow(a, 3);
                Mass = V * Density;
                Inertia = Mass * ((b * b) / 12);

                labelVolumeOut.Text = Convert.ToString(V);
                labelMassOut.Text = Convert.ToString(Mass);
                labelInertiaOut.Text = Convert.ToString(Inertia);
            }
            else if (comboBoxValue2 != null && comboBoxValue2 == "Koni")
            {
                tempParam = "Koni";
                V = (1.0 / 3.0) * Math.PI * Math.Pow(r, 2) * h;
                Mass = V * Density;
                Inertia = (1.0 / 6.0) * Mass * Math.Pow(r, 2) * h;
                labelVolumeOut.Text = Convert.ToString(V);
                labelMassOut.Text = Convert.ToString(Mass);
                labelInertiaOut.Text = Convert.ToString(Inertia);
            }
            else if (comboBoxValue2 != null && comboBoxValue2 == "Dodekaedron")
            {
                tempParam = "Dodekaedron";
                V = (1.0 / 4.0) * (15 + 7 * Math.Sqrt(5)) * Math.Pow(a, 3);
                Mass = V * Density;
                Inertia = Mass * (Math.Pow(b, 2) + 15 + Math.Pow(r, 2)) / 12;
                labelVolumeOut.Text = Convert.ToString(V);
                labelMassOut.Text = Convert.ToString(Mass);
                labelInertiaOut.Text = Convert.ToString(Inertia);
            }






        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            textBoxa.Clear();
            textBoxb.Clear();
            textBoxh.Clear();
            textBoxr.Clear();
            comboBoxM.SelectedIndex = -1;
            comboBoxS.SelectedIndex = -1;

            textBoxa.Visible = true;
            labela.Visible = true;
            textBoxb.Visible = true;
            labelb.Visible = true;
            textBoxh.Visible = true;
            labelh.Visible = true;
            textBoxr.Visible = true;
            labelr.Visible = true;



            labelVolumeOut.Text = "";
            labelMassOut.Text = "";
            labelInertiaOut.Text = "";

            tempParam = "";

        }

      
    }
}
