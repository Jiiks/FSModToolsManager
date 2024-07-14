namespace FSModToolsManager.Controls;

partial class FormMain {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        tableLayoutPanel1 = new TableLayoutPanel();
        launchersLayoutPanel = new TableLayoutPanel();
        ddContainer = new Panel();
        menuStrip1 = new MenuStrip();
        tableLayoutPanel2 = new TableLayoutPanel();
        btnPin = new Label();
        btnClose = new Label();
        btnMax = new Label();
        btnMin = new Label();
        label1 = new Label();
        pictureBox1 = new PictureBox();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
        tableLayoutPanel1.Controls.Add(launchersLayoutPanel, 1, 1);
        tableLayoutPanel1.Controls.Add(ddContainer, 2, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(3, 74);
        tableLayoutPanel1.Margin = new Padding(10);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
        tableLayoutPanel1.Size = new Size(1194, 723);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // launchersLayoutPanel
        // 
        launchersLayoutPanel.AutoScroll = true;
        launchersLayoutPanel.ColumnCount = 1;
        launchersLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        launchersLayoutPanel.Dock = DockStyle.Fill;
        launchersLayoutPanel.Location = new Point(8, 8);
        launchersLayoutPanel.Name = "launchersLayoutPanel";
        launchersLayoutPanel.RowCount = 1;
        launchersLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        launchersLayoutPanel.Size = new Size(704, 707);
        launchersLayoutPanel.TabIndex = 0;
        // 
        // ddContainer
        // 
        ddContainer.Location = new Point(718, 8);
        ddContainer.Name = "ddContainer";
        ddContainer.Size = new Size(427, 612);
        ddContainer.TabIndex = 1;
        // 
        // menuStrip1
        // 
        menuStrip1.BackColor = Color.FromArgb(80, 80, 80);
        menuStrip1.ImageScalingSize = new Size(32, 32);
        menuStrip1.Location = new Point(3, 50);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(0);
        menuStrip1.Size = new Size(1194, 24);
        menuStrip1.TabIndex = 1;
        menuStrip1.Text = "menuStrip1";
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        tableLayoutPanel2.BackColor = Color.FromArgb(31, 31, 31);
        tableLayoutPanel2.ColumnCount = 7;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
        tableLayoutPanel2.Controls.Add(btnPin, 0, 0);
        tableLayoutPanel2.Controls.Add(btnClose, 6, 0);
        tableLayoutPanel2.Controls.Add(btnMax, 4, 0);
        tableLayoutPanel2.Controls.Add(btnMin, 2, 0);
        tableLayoutPanel2.Location = new Point(848, 0);
        tableLayoutPanel2.Margin = new Padding(0);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(349, 50);
        tableLayoutPanel2.TabIndex = 2;
        // 
        // btnPin
        // 
        btnPin.BackColor = Color.FromArgb(31, 31, 31);
        btnPin.BackgroundImage = Properties.Resources.notpinned_normal;
        btnPin.BackgroundImageLayout = ImageLayout.Stretch;
        btnPin.Dock = DockStyle.Fill;
       // btnPin.FlatAppearance.BorderSize = 0;
        btnPin.FlatStyle = FlatStyle.Flat;
        btnPin.Font = new Font("Calibri", 9F, FontStyle.Bold);
        btnPin.ForeColor = Color.FromArgb(87, 79, 87);
        btnPin.Location = new Point(3, 3);
        btnPin.Name = "btnPin";
        btnPin.Size = new Size(74, 44);
        btnPin.TabIndex = 3;
       // btnPin.UseVisualStyleBackColor = false;
        btnPin.Click += btnPin_Click;
        btnPin.MouseEnter += btnPin_MouseEnter;
        btnPin.MouseLeave += btnPin_MouseLeave;
        // 
        // btnClose
        // 
        btnClose.BackColor = Color.FromArgb(31, 31, 31);
        btnClose.BackgroundImage = Properties.Resources.close_normal;
        btnClose.BackgroundImageLayout = ImageLayout.Stretch;
        btnClose.Dock = DockStyle.Fill;
      //  btnClose.FlatAppearance.BorderSize = 0;
        btnClose.FlatStyle = FlatStyle.Flat;
        btnClose.Font = new Font("Calibri", 9F);
        btnClose.ForeColor = Color.FromArgb(87, 79, 87);
        btnClose.Location = new Point(273, 3);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(74, 44);
        btnClose.TabIndex = 2;
       // btnClose.UseVisualStyleBackColor = false;
        btnClose.Click += btnClose_Click;
        btnClose.MouseEnter += btnClose_MouseEnter;
        btnClose.MouseLeave += btnClose_MouseLeave;
        // 
        // btnMax
        // 
        btnMax.BackColor = Color.FromArgb(31, 31, 31);
        btnMax.BackgroundImage = Properties.Resources.maximize_normal;
        btnMax.BackgroundImageLayout = ImageLayout.Stretch;
        btnMax.Dock = DockStyle.Fill;
       // btnMax.FlatAppearance.BorderSize = 0;
        btnMax.FlatStyle = FlatStyle.Flat;
        btnMax.Font = new Font("Calibri", 9F);
        btnMax.ForeColor = Color.FromArgb(87, 79, 87);
        btnMax.Location = new Point(183, 3);
        btnMax.Name = "btnMax";
        btnMax.Size = new Size(74, 44);
        btnMax.TabIndex = 1;
        //btnMax.UseVisualStyleBackColor = false;
        btnMax.Click += btnMax_Click;
        btnMax.MouseEnter += btnMax_MouseEnter;
        btnMax.MouseLeave += btnMax_MouseLeave;
        // 
        // btnMin
        // 
        btnMin.BackColor = Color.FromArgb(31, 31, 31);
        btnMin.BackgroundImage = Properties.Resources.minimize_normal;
        btnMin.BackgroundImageLayout = ImageLayout.Stretch;
        btnMin.Dock = DockStyle.Fill;
      //  btnMin.FlatAppearance.BorderSize = 0;
        btnMin.FlatStyle = FlatStyle.Flat;
        btnMin.Font = new Font("Calibri", 9F, FontStyle.Bold);
        btnMin.ForeColor = Color.FromArgb(87, 79, 87);
        btnMin.Location = new Point(93, 3);
        btnMin.Name = "btnMin";
        btnMin.Size = new Size(74, 44);
        btnMin.TabIndex = 0;
       // btnMin.UseVisualStyleBackColor = false;
        btnMin.Click += btnMin_Click;
        btnMin.MouseEnter += btnMin_MouseEnter;
        btnMin.MouseLeave += btnMin_MouseLeave;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = Color.FromArgb(31, 31, 31);
        label1.Font = new Font("Calibri", 9F);
        label1.ForeColor = Color.FromArgb(174, 174, 174);
        label1.Location = new Point(48, 11);
        label1.Name = "label1";
        label1.Size = new Size(222, 29);
        label1.TabIndex = 3;
        label1.Text = "FSModToolsManager";
        // 
        // pictureBox1
        // 
        pictureBox1.ErrorImage = null;
        pictureBox1.Image = Properties.Resources.fstm;
        pictureBox1.Location = new Point(5, 5);
        pictureBox1.Margin = new Padding(0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(40, 40);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 4;
        pictureBox1.TabStop = false;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(48, 48, 48);
        BorderColour = Color.FromArgb(31, 31, 31);
        BorderWidth = 3;
        CaptionColour = Color.FromArgb(31, 31, 31);
        ClientSize = new Size(1200, 800);
        Controls.Add(pictureBox1);
        Controls.Add(label1);
        Controls.Add(tableLayoutPanel2);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(menuStrip1);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MainMenuStrip = menuStrip1;
        Name = "FormMain";
        Padding = new Padding(3, 50, 3, 3);
        Text = "FormMain";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private MenuStrip menuStrip1;
    private TableLayoutPanel tableLayoutPanel2;
    private Label btnClose;
    private Label btnMax;
    private Label btnMin;
    private Label label1;
    private TableLayoutPanel launchersLayoutPanel;
    private Panel ddContainer;
    private PictureBox pictureBox1;
    private Label btnPin;
}