namespace ataletmakinesonn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxM = new ComboBox();
            comboBoxS = new ComboBox();
            buttonH = new Button();
            buttonS = new Button();
            labela = new Label();
            labelb = new Label();
            labelh = new Label();
            labelr = new Label();
            labelMass = new Label();
            labelVolume = new Label();
            labelMassOut = new Label();
            labelVolumeOut = new Label();
            labelInertia = new Label();
            labelInertiaOut = new Label();
            textBoxa = new TextBox();
            textBoxb = new TextBox();
            textBoxh = new TextBox();
            textBoxr = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxM
            // 
            comboBoxM.FormattingEnabled = true;
            comboBoxM.Items.AddRange(new object[] { "Alüminyum ", "Bakır", "Altın ", "Gümüş", "Çelik ", "Ahşap", "Kauçuk", "Plastik", "Titanyum", "Cam " });
            comboBoxM.Location = new Point(34, 77);
            comboBoxM.Name = "comboBoxM";
            comboBoxM.Size = new Size(182, 33);
            comboBoxM.TabIndex = 0;
            // 
            // comboBoxS
            // 
            comboBoxS.FormattingEnabled = true;
            comboBoxS.Items.AddRange(new object[] { "Küp", "Dikdörtgen Prizma", "Küre", "Silindir", "Konik Prizma", "Piramit", "Paralelkenar Prizma", "Tetraedar", "Koni", "Dodekaedron" });
            comboBoxS.Location = new Point(34, 170);
            comboBoxS.Name = "comboBoxS";
            comboBoxS.Size = new Size(182, 33);
            comboBoxS.TabIndex = 1;
            // 
            // buttonH
            // 
            buttonH.Location = new Point(34, 254);
            buttonH.Name = "buttonH";
            buttonH.Size = new Size(182, 34);
            buttonH.TabIndex = 2;
            buttonH.Text = "Hesapla";
            buttonH.UseVisualStyleBackColor = true;
            buttonH.Click += buttonH_Click;
            // 
            // buttonS
            // 
            buttonS.Location = new Point(34, 321);
            buttonS.Name = "buttonS";
            buttonS.Size = new Size(182, 34);
            buttonS.TabIndex = 3;
            buttonS.Text = "Sil";
            buttonS.UseVisualStyleBackColor = true;
            buttonS.Click += buttonS_Click;
            // 
            // labela
            // 
            labela.AutoSize = true;
            labela.Location = new Point(298, 75);
            labela.Name = "labela";
            labela.Size = new Size(134, 25);
            labela.TabIndex = 4;
            labela.Text = "Uzunluk (mm)=";
            // 
            // labelb
            // 
            labelb.AutoSize = true;
            labelb.Location = new Point(289, 117);
            labelb.Name = "labelb";
            labelb.Size = new Size(136, 25);
            labelb.TabIndex = 5;
            labelb.Text = " Genişlik (mm)=";
            // 
            // labelh
            // 
            labelh.AutoSize = true;
            labelh.Location = new Point(298, 173);
            labelh.Name = "labelh";
            labelh.Size = new Size(143, 25);
            labelh.TabIndex = 6;
            labelh.Text = "Yükseklik (mm)=";
            // 
            // labelr
            // 
            labelr.AutoSize = true;
            labelr.Location = new Point(298, 220);
            labelr.Name = "labelr";
            labelr.Size = new Size(121, 25);
            labelr.TabIndex = 7;
            labelr.Text = "Yarıçap(mm)=";
            // 
            // labelMass
            // 
            labelMass.AutoSize = true;
            labelMass.Location = new Point(321, 279);
            labelMass.Name = "labelMass";
            labelMass.Size = new Size(78, 25);
            labelMass.TabIndex = 8;
            labelMass.Text = "Kütle   =";
            // 
            // labelVolume
            // 
            labelVolume.AutoSize = true;
            labelVolume.Location = new Point(321, 321);
            labelVolume.Name = "labelVolume";
            labelVolume.Size = new Size(79, 25);
            labelVolume.TabIndex = 9;
            labelVolume.Text = "Hacim =";
            // 
            // labelMassOut
            // 
            labelMassOut.AutoSize = true;
            labelMassOut.Location = new Point(456, 280);
            labelMassOut.Name = "labelMassOut";
            labelMassOut.Size = new Size(0, 25);
            labelMassOut.TabIndex = 10;
            // 
            // labelVolumeOut
            // 
            labelVolumeOut.AutoSize = true;
            labelVolumeOut.Location = new Point(456, 321);
            labelVolumeOut.Name = "labelVolumeOut";
            labelVolumeOut.Size = new Size(0, 25);
            labelVolumeOut.TabIndex = 11;
            // 
            // labelInertia
            // 
            labelInertia.AutoSize = true;
            labelInertia.Location = new Point(321, 360);
            labelInertia.Name = "labelInertia";
            labelInertia.Size = new Size(78, 25);
            labelInertia.TabIndex = 12;
            labelInertia.Text = "Sonuç =";
            // 
            // labelInertiaOut
            // 
            labelInertiaOut.AutoSize = true;
            labelInertiaOut.Location = new Point(455, 360);
            labelInertiaOut.Name = "labelInertiaOut";
            labelInertiaOut.Size = new Size(0, 25);
            labelInertiaOut.TabIndex = 13;
            // 
            // textBoxa
            // 
            textBoxa.Location = new Point(455, 67);
            textBoxa.Name = "textBoxa";
            textBoxa.Size = new Size(150, 31);
            textBoxa.TabIndex = 14;
            // 
            // textBoxb
            // 
            textBoxb.Location = new Point(455, 111);
            textBoxb.Name = "textBoxb";
            textBoxb.Size = new Size(150, 31);
            textBoxb.TabIndex = 15;
            // 
            // textBoxh
            // 
            textBoxh.Location = new Point(455, 167);
            textBoxh.Name = "textBoxh";
            textBoxh.Size = new Size(150, 31);
            textBoxh.TabIndex = 16;
            // 
            // textBoxr
            // 
            textBoxr.Location = new Point(455, 217);
            textBoxr.Name = "textBoxr";
            textBoxr.Size = new Size(150, 31);
            textBoxr.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 40);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 18;
            label1.Text = "Malzemeler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 142);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 19;
            label2.Text = "Şekiller";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(665, 422);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxr);
            Controls.Add(textBoxh);
            Controls.Add(textBoxb);
            Controls.Add(textBoxa);
            Controls.Add(labelInertiaOut);
            Controls.Add(labelInertia);
            Controls.Add(labelVolumeOut);
            Controls.Add(labelMassOut);
            Controls.Add(labelVolume);
            Controls.Add(labelMass);
            Controls.Add(labelr);
            Controls.Add(labelh);
            Controls.Add(labelb);
            Controls.Add(labela);
            Controls.Add(buttonS);
            Controls.Add(buttonH);
            Controls.Add(comboBoxS);
            Controls.Add(comboBoxM);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxM;
        private ComboBox comboBoxS;
        private Button buttonH;
        private Button buttonS;
        private Label labela;
        private Label labelb;
        private Label labelh;
        private Label labelr;
        private Label labelMass;
        private Label labelVolume;
        private Label labelMassOut;
        private Label labelVolumeOut;
        private Label labelInertia;
        private Label labelInertiaOut;
        private TextBox textBoxa;
        private TextBox textBoxb;
        private TextBox textBoxh;
        private TextBox textBoxr;
        private Label label1;
        private Label label2;
    }
}
