namespace He_escaped
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
            components = new System.ComponentModel.Container();
            groupBoxStats = new GroupBox();
            labelThirst = new Label();
            labelHunger = new Label();
            labelMoney = new Label();
            labelEnergy = new Label();
            labelHealth = new Label();
            groupBoxMap = new GroupBox();
            labelEventText = new Label();
            pictureBoxMap = new PictureBox();
            groupBoxChoices = new GroupBox();
            buttonUseItem = new Button();
            buttonCraft = new Button();
            buttonContinue = new Button();
            buttonHunt = new Button();
            buttonScavenge = new Button();
            buttonRest = new Button();
            buttonRoll = new Button();
            textBoxLog = new TextBox();
            listBoxInventory = new ListBox();
            timerDice = new System.Windows.Forms.Timer(components);
            timerMove = new System.Windows.Forms.Timer(components);
            buttonHelp = new Button();
            groupBoxStats.SuspendLayout();
            groupBoxMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMap).BeginInit();
            groupBoxChoices.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxStats
            // 
            groupBoxStats.Controls.Add(labelThirst);
            groupBoxStats.Controls.Add(labelHunger);
            groupBoxStats.Controls.Add(labelMoney);
            groupBoxStats.Controls.Add(labelEnergy);
            groupBoxStats.Controls.Add(labelHealth);
            groupBoxStats.Location = new Point(12, 12);
            groupBoxStats.Name = "groupBoxStats";
            groupBoxStats.Size = new Size(250, 125);
            groupBoxStats.TabIndex = 0;
            groupBoxStats.TabStop = false;
            groupBoxStats.Text = "Player Stats";
            // 
            // labelThirst
            // 
            labelThirst.BorderStyle = BorderStyle.FixedSingle;
            labelThirst.Location = new Point(114, 51);
            labelThirst.Name = "labelThirst";
            labelThirst.Size = new Size(130, 28);
            labelThirst.TabIndex = 4;
            labelThirst.Text = "Thirst: 100 / 100";
            labelThirst.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHunger
            // 
            labelHunger.BorderStyle = BorderStyle.FixedSingle;
            labelHunger.Location = new Point(114, 0);
            labelHunger.Name = "labelHunger";
            labelHunger.Size = new Size(136, 23);
            labelHunger.TabIndex = 3;
            labelHunger.Text = "Hunger: 100 / 100";
            labelHunger.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMoney
            // 
            labelMoney.BorderStyle = BorderStyle.FixedSingle;
            labelMoney.Location = new Point(147, 99);
            labelMoney.Name = "labelMoney";
            labelMoney.Size = new Size(97, 23);
            labelMoney.TabIndex = 2;
            labelMoney.Text = "Money: 50";
            labelMoney.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEnergy
            // 
            labelEnergy.BorderStyle = BorderStyle.FixedSingle;
            labelEnergy.Location = new Point(0, 79);
            labelEnergy.Name = "labelEnergy";
            labelEnergy.Size = new Size(131, 29);
            labelEnergy.TabIndex = 1;
            labelEnergy.Text = "Energy: 100 / 100";
            labelEnergy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHealth
            // 
            labelHealth.BorderStyle = BorderStyle.FixedSingle;
            labelHealth.Location = new Point(0, 23);
            labelHealth.Name = "labelHealth";
            labelHealth.Size = new Size(131, 28);
            labelHealth.TabIndex = 0;
            labelHealth.Text = "Health: 100 / 100";
            labelHealth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxMap
            // 
            groupBoxMap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxMap.Controls.Add(labelEventText);
            groupBoxMap.Controls.Add(pictureBoxMap);
            groupBoxMap.Location = new Point(268, 12);
            groupBoxMap.Name = "groupBoxMap";
            groupBoxMap.Size = new Size(662, 345);
            groupBoxMap.TabIndex = 1;
            groupBoxMap.TabStop = false;
            groupBoxMap.Text = "Map";
            // 
            // labelEventText
            // 
            labelEventText.Anchor = AnchorStyles.Top;
            labelEventText.AutoSize = true;
            labelEventText.BackColor = Color.White;
            labelEventText.BorderStyle = BorderStyle.FixedSingle;
            labelEventText.Location = new Point(7, 23);
            labelEventText.Name = "labelEventText";
            labelEventText.Size = new Size(35, 22);
            labelEventText.TabIndex = 0;
            labelEventText.Text = "llllll";
            // 
            // pictureBoxMap
            // 
            pictureBoxMap.Anchor = AnchorStyles.Top;
            pictureBoxMap.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxMap.Location = new Point(3, 23);
            pictureBoxMap.Name = "pictureBoxMap";
            pictureBoxMap.Size = new Size(656, 319);
            pictureBoxMap.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMap.TabIndex = 0;
            pictureBoxMap.TabStop = false;
            // 
            // groupBoxChoices
            // 
            groupBoxChoices.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxChoices.Controls.Add(buttonUseItem);
            groupBoxChoices.Controls.Add(buttonCraft);
            groupBoxChoices.Controls.Add(buttonContinue);
            groupBoxChoices.Controls.Add(buttonHunt);
            groupBoxChoices.Controls.Add(buttonScavenge);
            groupBoxChoices.Controls.Add(buttonRest);
            groupBoxChoices.Location = new Point(268, 363);
            groupBoxChoices.Name = "groupBoxChoices";
            groupBoxChoices.Size = new Size(662, 75);
            groupBoxChoices.TabIndex = 2;
            groupBoxChoices.TabStop = false;
            groupBoxChoices.Text = "Choices:";
            groupBoxChoices.Enter += groupBoxChoices_Enter;
            // 
            // buttonUseItem
            // 
            buttonUseItem.Location = new Point(402, 20);
            buttonUseItem.Name = "buttonUseItem";
            buttonUseItem.Size = new Size(94, 55);
            buttonUseItem.TabIndex = 5;
            buttonUseItem.Text = "Use Item";
            buttonUseItem.UseVisualStyleBackColor = true;
            buttonUseItem.Click += buttonUseItem_Click;
            // 
            // buttonCraft
            // 
            buttonCraft.Location = new Point(302, 20);
            buttonCraft.Name = "buttonCraft";
            buttonCraft.Size = new Size(94, 55);
            buttonCraft.TabIndex = 4;
            buttonCraft.Text = "Craft";
            buttonCraft.UseVisualStyleBackColor = true;
            buttonCraft.Click += buttonCraft_Click;
            // 
            // buttonContinue
            // 
            buttonContinue.Location = new Point(550, 28);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(94, 29);
            buttonContinue.TabIndex = 3;
            buttonContinue.Text = "Continue";
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // buttonHunt
            // 
            buttonHunt.Location = new Point(202, 20);
            buttonHunt.Name = "buttonHunt";
            buttonHunt.Size = new Size(94, 55);
            buttonHunt.TabIndex = 2;
            buttonHunt.Text = "Hunt";
            buttonHunt.UseVisualStyleBackColor = true;
            buttonHunt.Click += buttonHunt_Click;
            // 
            // buttonScavenge
            // 
            buttonScavenge.Location = new Point(102, 20);
            buttonScavenge.Name = "buttonScavenge";
            buttonScavenge.Size = new Size(94, 55);
            buttonScavenge.TabIndex = 1;
            buttonScavenge.Text = "Scavenge";
            buttonScavenge.UseVisualStyleBackColor = true;
            buttonScavenge.Click += buttonScavenge_Click;
            // 
            // buttonRest
            // 
            buttonRest.Location = new Point(7, 20);
            buttonRest.Name = "buttonRest";
            buttonRest.Size = new Size(89, 55);
            buttonRest.TabIndex = 0;
            buttonRest.Text = "Rest";
            buttonRest.UseVisualStyleBackColor = true;
            buttonRest.Click += buttonRest_Click;
            // 
            // buttonRoll
            // 
            buttonRoll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRoll.Location = new Point(172, 363);
            buttonRoll.Name = "buttonRoll";
            buttonRoll.Size = new Size(90, 75);
            buttonRoll.TabIndex = 3;
            buttonRoll.Text = "Roll Dice!";
            buttonRoll.UseVisualStyleBackColor = true;
            buttonRoll.Click += buttonRoll_Click;
            // 
            // textBoxLog
            // 
            textBoxLog.Anchor = AnchorStyles.Left;
            textBoxLog.Location = new Point(12, 152);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ScrollBars = ScrollBars.Vertical;
            textBoxLog.Size = new Size(244, 170);
            textBoxLog.TabIndex = 5;
            // 
            // listBoxInventory
            // 
            listBoxInventory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxInventory.FormattingEnabled = true;
            listBoxInventory.Location = new Point(12, 334);
            listBoxInventory.Name = "listBoxInventory";
            listBoxInventory.Size = new Size(150, 104);
            listBoxInventory.TabIndex = 6;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(172, 328);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 29);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 450);
            Controls.Add(buttonHelp);
            Controls.Add(listBoxInventory);
            Controls.Add(textBoxLog);
            Controls.Add(buttonRoll);
            Controls.Add(groupBoxChoices);
            Controls.Add(groupBoxMap);
            Controls.Add(groupBoxStats);
            Name = "Form1";
            Text = "He Escaped";
            Load += Form1_Load;
            groupBoxStats.ResumeLayout(false);
            groupBoxMap.ResumeLayout(false);
            groupBoxMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMap).EndInit();
            groupBoxChoices.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxStats;
        private Label labelHealth;
        private Label labelThirst;
        private Label labelHunger;
        private Label labelMoney;
        private Label labelEnergy;
        private GroupBox groupBoxMap;
        private GroupBox groupBoxChoices;
        private Button buttonRest;
        private Button buttonRoll;
        private Button buttonCraft;
        private Button buttonContinue;
        private Button buttonHunt;
        private Button buttonScavenge;
        private TextBox textBoxLog;
        private Button buttonUseItem;
        private ListBox listBoxInventory;
        private PictureBox pictureBoxMap;
        private System.Windows.Forms.Timer timerDice;
        private System.Windows.Forms.Timer timerMove;
        private Button buttonHelp;
        private Label labelEventText;
    }
}
