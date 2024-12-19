namespace XanderUIDemoApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xuiBanner1 = new XanderUI.XUIBanner();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.xuiBarGraph1 = new XanderUI.XUIBarGraph();
            this.xuiCard1 = new XanderUI.XUICard();
            this.xuiCircleProgressBar1 = new XanderUI.XUICircleProgressBar();
            this.xuiCircleProgressBar2 = new XanderUI.XUICircleProgressBar();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.xuiSwitch1 = new XanderUI.XUISwitch();
            this.SuspendLayout();
            // 
            // xuiBanner1
            // 
            this.xuiBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner1.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiBanner1.BorderColor = System.Drawing.Color.White;
            this.xuiBanner1.ForeColor = System.Drawing.Color.White;
            this.xuiBanner1.Location = new System.Drawing.Point(12, 12);
            this.xuiBanner1.Name = "xuiBanner1";
            this.xuiBanner1.Size = new System.Drawing.Size(148, 92);
            this.xuiBanner1.TabIndex = 0;
            this.xuiBanner1.Text = "xuiBanner1";
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "Button";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(166, 13);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(176, 91);
            this.xuiButton1.TabIndex = 1;
            this.xuiButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiBarGraph1
            // 
            this.xuiBarGraph1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.xuiBarGraph1.GraphOrientation = XanderUI.XUIBarGraph.Orientation.Vertical;
            this.xuiBarGraph1.GraphStyle = XanderUI.XUIBarGraph.Style.Material;
            this.xuiBarGraph1.Items = ((System.Collections.Generic.List<int>)(resources.GetObject("xuiBarGraph1.Items")));
            this.xuiBarGraph1.Location = new System.Drawing.Point(358, 12);
            this.xuiBarGraph1.Name = "xuiBarGraph1";
            this.xuiBarGraph1.ShowGrid = false;
            this.xuiBarGraph1.Size = new System.Drawing.Size(187, 91);
            this.xuiBarGraph1.Sorting = XanderUI.XUIBarGraph.SortStyle.Normal;
            this.xuiBarGraph1.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.xuiBarGraph1.TabIndex = 2;
            this.xuiBarGraph1.Text = "xuiBarGraph1";
            this.xuiBarGraph1.TextAlignment = XanderUI.XUIBarGraph.Aligning.Far;
            this.xuiBarGraph1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.xuiBarGraph1.UnfilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            // 
            // xuiCard1
            // 
            this.xuiCard1.BackColor = System.Drawing.Color.Transparent;
            this.xuiCard1.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuiCard1.Color2 = System.Drawing.Color.LimeGreen;
            this.xuiCard1.ForeColor = System.Drawing.Color.White;
            this.xuiCard1.Location = new System.Drawing.Point(12, 119);
            this.xuiCard1.Name = "xuiCard1";
            this.xuiCard1.Size = new System.Drawing.Size(337, 121);
            this.xuiCard1.TabIndex = 3;
            this.xuiCard1.Text = "xuiCard1";
            this.xuiCard1.Text1 = "Alijonv Muhammadqodir";
            this.xuiCard1.Text2 = "8600 3129 7981 7961";
            this.xuiCard1.Text3 = "Exp: 01/02 - 03/04";
            // 
            // xuiCircleProgressBar1
            // 
            this.xuiCircleProgressBar1.AnimationSpeed = 5;
            this.xuiCircleProgressBar1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.xuiCircleProgressBar1.FilledColorAlpha = 130;
            this.xuiCircleProgressBar1.FilledThickness = 40;
            this.xuiCircleProgressBar1.IsAnimated = false;
            this.xuiCircleProgressBar1.Location = new System.Drawing.Point(564, 13);
            this.xuiCircleProgressBar1.Name = "xuiCircleProgressBar1";
            this.xuiCircleProgressBar1.Percentage = 63;
            this.xuiCircleProgressBar1.ShowText = true;
            this.xuiCircleProgressBar1.Size = new System.Drawing.Size(238, 101);
            this.xuiCircleProgressBar1.TabIndex = 4;
            this.xuiCircleProgressBar1.TextColor = System.Drawing.Color.Gray;
            this.xuiCircleProgressBar1.TextSize = 25;
            this.xuiCircleProgressBar1.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.xuiCircleProgressBar1.UnfilledThickness = 24;
            // 
            // xuiCircleProgressBar2
            // 
            this.xuiCircleProgressBar2.AnimationSpeed = 5;
            this.xuiCircleProgressBar2.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.xuiCircleProgressBar2.FilledColorAlpha = 130;
            this.xuiCircleProgressBar2.FilledThickness = 40;
            this.xuiCircleProgressBar2.IsAnimated = false;
            this.xuiCircleProgressBar2.Location = new System.Drawing.Point(2, 246);
            this.xuiCircleProgressBar2.Name = "xuiCircleProgressBar2";
            this.xuiCircleProgressBar2.Percentage = 70;
            this.xuiCircleProgressBar2.ShowText = true;
            this.xuiCircleProgressBar2.Size = new System.Drawing.Size(193, 160);
            this.xuiCircleProgressBar2.TabIndex = 5;
            this.xuiCircleProgressBar2.TextColor = System.Drawing.Color.Gray;
            this.xuiCircleProgressBar2.TextSize = 25;
            this.xuiCircleProgressBar2.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.xuiCircleProgressBar2.UnfilledThickness = 24;
            // 
            // xuiClock1
            // 
            this.xuiClock1.CircleThickness = 6;
            this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuiClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.xuiClock1.Font = new System.Drawing.Font("Impact", 15F);
            this.xuiClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.Location = new System.Drawing.Point(282, 199);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(143, 128);
            this.xuiClock1.TabIndex = 6;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // xuiSwitch1
            // 
            this.xuiSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.xuiSwitch1.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiSwitch1.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(120)))));
            this.xuiSwitch1.Location = new System.Drawing.Point(575, 212);
            this.xuiSwitch1.Name = "xuiSwitch1";
            this.xuiSwitch1.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(129)))), ((int)(((byte)(136)))));
            this.xuiSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSwitch1.Size = new System.Drawing.Size(134, 79);
            this.xuiSwitch1.SwitchState = XanderUI.XUISwitch.State.On;
            this.xuiSwitch1.SwitchStyle = XanderUI.XUISwitch.Style.Horizontal;
            this.xuiSwitch1.TabIndex = 7;
            this.xuiSwitch1.Text = "xuiSwitch1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 459);
            this.Controls.Add(this.xuiSwitch1);
            this.Controls.Add(this.xuiClock1);
            this.Controls.Add(this.xuiCircleProgressBar2);
            this.Controls.Add(this.xuiCircleProgressBar1);
            this.Controls.Add(this.xuiCard1);
            this.Controls.Add(this.xuiBarGraph1);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.xuiBanner1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIBanner xuiBanner1;
        private XanderUI.XUIButton xuiButton1;
        private XanderUI.XUIBarGraph xuiBarGraph1;
        private XanderUI.XUICard xuiCard1;
        private XanderUI.XUICircleProgressBar xuiCircleProgressBar1;
        private XanderUI.XUICircleProgressBar xuiCircleProgressBar2;
        private XanderUI.XUIClock xuiClock1;
        private XanderUI.XUISwitch xuiSwitch1;
    }
}

