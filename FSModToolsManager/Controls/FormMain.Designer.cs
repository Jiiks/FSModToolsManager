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
        tableLayoutPanel1 = new TableLayoutPanel();
        launchersLayoutPanel = new TableLayoutPanel();
        menuStrip1 = new MenuStrip();
        tableLayoutPanel2 = new TableLayoutPanel();
        btnClose = new Button();
        btnMax = new Button();
        btnMin = new Button();
        label1 = new Label();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
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
        tableLayoutPanel2.ColumnCount = 5;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
        tableLayoutPanel2.Controls.Add(btnClose, 5, 0);
        tableLayoutPanel2.Controls.Add(btnMax, 2, 0);
        tableLayoutPanel2.Controls.Add(btnMin, 0, 0);
        tableLayoutPanel2.Location = new Point(1000, 0);
        tableLayoutPanel2.Margin = new Padding(0);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(200, 50);
        tableLayoutPanel2.TabIndex = 2;
        // 
        // btnClose
        // 
        btnClose.Dock = DockStyle.Fill;
        btnClose.FlatStyle = FlatStyle.Flat;
        btnClose.Font = new Font("Calibri", 9F);
        btnClose.ForeColor = Color.FromArgb(174, 174, 174);
        btnClose.Location = new Point(143, 3);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(54, 44);
        btnClose.TabIndex = 2;
        btnClose.Text = "X";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // btnMax
        // 
        btnMax.Dock = DockStyle.Fill;
        btnMax.FlatStyle = FlatStyle.Flat;
        btnMax.Font = new Font("Calibri", 9F);
        btnMax.ForeColor = Color.FromArgb(174, 174, 174);
        btnMax.Location = new Point(73, 3);
        btnMax.Name = "btnMax";
        btnMax.Size = new Size(54, 44);
        btnMax.TabIndex = 1;
        btnMax.Text = "[]";
        btnMax.UseVisualStyleBackColor = true;
        btnMax.Click += btnMax_Click;
        // 
        // btnMin
        // 
        btnMin.Dock = DockStyle.Fill;
        btnMin.FlatStyle = FlatStyle.Flat;
        btnMin.Font = new Font("Calibri", 9F, FontStyle.Bold);
        btnMin.ForeColor = Color.FromArgb(174, 174, 174);
        btnMin.Location = new Point(3, 3);
        btnMin.Name = "btnMin";
        btnMin.Size = new Size(54, 44);
        btnMin.TabIndex = 0;
        btnMin.Text = "-";
        btnMin.UseVisualStyleBackColor = true;
        btnMin.Click += btnMin_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Calibri", 9F);
        label1.ForeColor = Color.FromArgb(174, 174, 174);
        label1.Location = new Point(6, 9);
        label1.Name = "label1";
        label1.Size = new Size(222, 29);
        label1.TabIndex = 3;
        label1.Text = "FSModToolsManager";
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(48, 48, 48);
        BorderColour = Color.FromArgb(48, 48, 48);
        BorderWidth = 3;
        CaptionColour = Color.FromArgb(48, 48, 48);
        ClientSize = new Size(1200, 800);
        Controls.Add(label1);
        Controls.Add(tableLayoutPanel2);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(menuStrip1);
        FormBorderStyle = FormBorderStyle.None;
        MainMenuStrip = menuStrip1;
        Name = "FormMain";
        Padding = new Padding(3, 50, 3, 3);
        Text = "FormMain";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private MenuStrip menuStrip1;
    private TableLayoutPanel tableLayoutPanel2;
    private Button btnClose;
    private Button btnMax;
    private Button btnMin;
    private Label label1;
    private TableLayoutPanel launchersLayoutPanel;
}